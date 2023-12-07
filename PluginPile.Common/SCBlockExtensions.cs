using PKHeX.Core;

namespace PluginPile.Common;
public static class SCBlockExtensions {

  public static bool IsTrue(this SCBlock scBlock) => scBlock.Type == SCTypeCode.Bool2;

  public static bool IsFalse(this SCBlock scBlock) => scBlock.Type == SCTypeCode.Bool1;

  public static bool GetBooleanValue(this SCBlock scBlock) => scBlock.IsTrue();

  public static void ChangeBooleanValue(this SCBlock scBlock, bool newValue) => scBlock.ChangeBooleanType(newValue ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

}
