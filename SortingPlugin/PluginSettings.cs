using System.ComponentModel;
using System.Configuration;

namespace PluginPile.SortingPlugin {

  internal sealed partial class PluginSettings : ApplicationSettingsBase {

    private static PluginSettings defaultInstance = ((PluginSettings)(Synchronized(new PluginSettings())));

    public static PluginSettings Default {
      get {
        return defaultInstance;
      }
    }

    /// <summary>
    /// Show the individual area Pokedéxes for those that have it.
    /// </summary>
    [UserScopedSettingAttribute()]
    [Description("Show the individual area Pokedéxes for those that have it.")]
    [DefaultSettingValueAttribute("False")]
    public bool ShowIndividualPokedéxes {
      get {
        return (bool)this["ShowIndividualPokedéxes"];
      }
      set {
        this["ShowIndividualPokedéxes"] = value;
      }
    }

    /// <summary>
    /// The box to begin sorting from.
    /// </summary>
    [UserScopedSettingAttribute()]
    [Description("The box to begin sorting from.")]
    [DefaultSettingValueAttribute("1")]
    public int SortBeginBox {
      get {
        return (int)this["SortBeginBox"];
      }
      set {
        this["SortBeginBox"] = value;
      }
    }

    /// <summary>
    /// The box to ending sorting in. -1 can be used to specify the last box.
    /// </summary>
    [UserScopedSettingAttribute()]
    [Description("The box to ending sorting in. -1 can be used to specify the last box.")]
    [DefaultSettingValueAttribute("-1")]
    public int SortEndBox {
      get {
        return (int)this["SortEndBox"];
      }
      set {
        this["SortEndBox"] = value;
      }
    }

    /// <summary>
    /// Only accept forms from the regional Pokedéx that are being sorted
    /// </summary>
    [UserScopedSettingAttribute()]
    [Description("Only accept forms from the regional Pokedéx that are being sorted")]
    [DefaultSettingValueAttribute("True")]
    public bool CheckForms {
      get {
        return (bool)this["CheckForms"];
      }
      set {
        this["CheckForms"] = value;
      }
    }

    internal enum SortOptions {
      None,
      Level,
      MetDate,
      LevelThenMetDate,
      MetDateThenLevel,
    }

    [UserScopedSettingAttribute()]
    [Description("Additional sorting options to be applied after Pokedéx sorting")]
    [DefaultSettingValueAttribute("0")]
    public SortOptions AdditionalSortOptions {
      get {
        return (SortOptions)this["AdditionalSortOptions"];
      }
      set {
        this["AdditionalSortOptions"] = value;
      }
    }

  }
}
