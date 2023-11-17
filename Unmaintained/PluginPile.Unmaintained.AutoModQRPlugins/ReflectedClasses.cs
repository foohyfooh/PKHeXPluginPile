using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.Unmaintained.AutoModQRPlugins;

internal class WinFormsUtil {
  private static readonly Type WinFormsUtilType = AssemblyUtil.GetTypeFromAssembly("AutoModPlugins", "AutoModPlugins.WinFormsUtil");

  public static DialogResult Error(params string[] lines) {
    MethodInfo errorMethodInfo = WinFormsUtilType.GetMethod("Error")!;
    return (DialogResult)errorMethodInfo.Invoke(null, new object[] { lines })!;
  }
}

internal class ShowdownSetLoader {
  private static readonly Type ShowdownSetLoaderType = AssemblyUtil.GetTypeFromAssembly("AutoModPlugins", "AutoModPlugins.ShowdownSetLoader");

  public static void Import(IReadOnlyList<ShowdownSet> sets, bool skipDialog = false) {
    MethodInfo importMethodInfo = ShowdownSetLoaderType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Single(m => m.Name == "Import" && m.GetParameters().Length == 2);
    importMethodInfo.Invoke(null, new object[] { sets, skipDialog });
  }
}
