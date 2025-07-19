using System.ComponentModel;
using System.Configuration;

namespace PluginPile.Sorting;

internal sealed partial class PluginSettings : ApplicationSettingsBase {

  private static readonly PluginSettings defaultInstance = ((PluginSettings)(Synchronized(new PluginSettings())));

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
      return (bool)this[nameof(ShowIndividualPokedéxes)];
    }
    set {
      this[nameof(ShowIndividualPokedéxes)] = value;
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
      return (int)this[nameof(SortBeginBox)];
    }
    set {
      this[nameof(SortBeginBox)] = value;
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
      return (int)this[nameof(SortEndBox)];
    }
    set {
      this[nameof(SortEndBox)] = value;
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
      return (bool)this[nameof(CheckForms)];
    }
    set {
      this[nameof(CheckForms)] = value;
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
      return (SortOptions)this[nameof(AdditionalSortOptions)];
    }
    set {
      this[nameof(AdditionalSortOptions)] = value;
    }
  }

}
