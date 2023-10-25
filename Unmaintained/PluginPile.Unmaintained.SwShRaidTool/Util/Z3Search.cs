using Microsoft.Z3;
using PKHeX.Core;
using System.Runtime.CompilerServices;

namespace PluginPile.Unmaintained.SwShRaidTool;
public static class Z3Search {
  public static IEnumerable<ulong> GetSeeds(uint ec, uint pid, int[] ivs) {
    foreach (ulong seed in FindPotentialSeeds(ec, pid, false, ivs))
      yield return seed;
    foreach (ulong seed in FindPotentialSeeds(ec, pid ^ 0x10000000, false, ivs))
      yield return seed;
    foreach (ulong seed in FindPotentialSeeds(ec, pid, true, ivs))
      yield return seed;
  }

  public static IEnumerable<ulong> FindPotentialSeeds(uint ec, uint pid, bool shiny, int[] ivs) {
    using Context ctx = new Context(new Dictionary<string, string> { { "model", "true" } });
    BoolExpr exp = CreateModel(ctx, ec, pid, shiny, out BitVecExpr s0);

    Model? m;
    while ((m = Check(ctx, exp)) != null) {
      foreach (KeyValuePair<FuncDecl, Expr> kvp in m.Consts) {
        BitVecNum tmp = (BitVecNum)kvp.Value;
        yield return tmp.UInt64; // TODO: Something nicer
        exp = ctx.MkAnd(exp, ctx.MkNot(ctx.MkEq(s0, m.Evaluate(s0))));
      }
    }
  }

  private static BoolExpr CreateModel(Context ctx, uint ec, uint pid, bool shiny, out BitVecExpr s0) {
    s0 = ctx.MkBVConst("s0", 64);
    BitVecExpr s1 = ctx.MkBV(Xoroshiro128Plus.XOROSHIRO_CONST, 64);

    BitVecNum and_val = ctx.MkBV(0xFFFFFFFF, 64);
    BitVecNum and_val16 = ctx.MkBV(0xFFFF, 64);
    BitVecNum bit16 = ctx.MkBV(1 << 16, 64);
    BitVecNum comp_with = ctx.MkBV(0xF, 64);

    BitVecNum real_ec = ctx.MkBV(ec, 64);
    BitVecNum real_pid = ctx.MkBV(pid, 64);

    BitVecExpr ec_check = AdvanceSymbolic(ctx, ref s0, ref s1);
    BitVecExpr tidsid = AdvanceSymbolic(ctx, ref s0, ref s1);
    BitVecExpr pid_check = AdvanceSymbolic(ctx, ref s0, ref s1);

    BoolExpr exp = ctx.MkEq(ec_check, real_ec);

    if (shiny) {
      exp = ctx.MkAnd(exp, ctx.MkEq(ctx.MkBVAND(pid_check, and_val16), ctx.MkBVAND(real_pid, and_val16)));
      BitVecExpr st = ctx.MkBVAND(tidsid, and_val);
      BitVecExpr tsv = ctx.MkBVXOR(ctx.MkBVUDiv(st, bit16), ctx.MkBVAND(st, and_val16));
      BitVecExpr psv = ctx.MkBVXOR(ctx.MkBVUDiv(pid_check, bit16), ctx.MkBVAND(pid_check, and_val16));
      return ctx.MkAnd(exp, ctx.MkBVSLE(ctx.MkBVXOR(tsv, psv), comp_with));
    } else {
      return ctx.MkAnd(exp, ctx.MkEq(pid_check, real_pid));
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static BitVecExpr AdvanceSymbolic(Context ctx, ref BitVecExpr s0, ref BitVecExpr s1) {
    BitVecNum and_val = ctx.MkBV(0xFFFFFFFF, 64);
    BitVecExpr res = ctx.MkBVAND(ctx.MkBVAdd(s0, s1), and_val);
    s1 = ctx.MkBVXOR(s0, s1);
    BitVecExpr tmp = ctx.MkBVRotateLeft(24, s0);
    BitVecNum tmp2 = ctx.MkBV(1 << 16, 64);
    s0 = ctx.MkBVXOR(tmp, ctx.MkBVXOR(s1, ctx.MkBVMul(s1, tmp2)));
    s1 = ctx.MkBVRotateLeft(37, s1);
    return res;
  }

  private static Model? Check(Context ctx, BoolExpr cond) {
    Solver solver = ctx.MkSolver();
    solver.Assert(cond);
    Status q = solver.Check();
    if (q != Status.SATISFIABLE)
      return null;
    return solver.Model;
  }
}
