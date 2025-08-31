using System.ComponentModel;
using System.Configuration;

namespace PluginPile.Sorting;

public sealed partial class PluginSettings : ApplicationSettingsBase {

  private static readonly PluginSettings defaultInstance = ((PluginSettings)(Synchronized(new PluginSettings())));

  public static PluginSettings Default {
    get {
      return defaultInstance;
    }
  }

  /// <summary>
  /// Show the individual area Pokédexes for those that have it.
  /// </summary>
  [UserScopedSetting()]
  [Description("Show the individual area Pokédexes for those that have it.")]
  [DefaultSettingValue("False")]
  public bool ShowIndividualPokédexes {
    get {
      return (bool)this[nameof(ShowIndividualPokédexes)];
    }
    set {
      this[nameof(ShowIndividualPokédexes)] = value;
    }
  }

  /// <summary>
  /// The box to begin sorting from.
  /// </summary>
  [UserScopedSetting()]
  [Description("The box to begin sorting from.")]
  [DefaultSettingValue("1")]
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
  [UserScopedSetting()]
  [Description("The box to ending sorting in. -1 can be used to specify the last box.")]
  [DefaultSettingValue("-1")]
  public int SortEndBox {
    get {
      return (int)this[nameof(SortEndBox)];
    }
    set {
      this[nameof(SortEndBox)] = value;
    }
  }

  /// <summary>
  /// Only accept forms from the regional Pokédex that are being sorted
  /// </summary>
  [UserScopedSetting()]
  [Description("Only accept forms from the regional Pokédex that are being sorted")]
  [DefaultSettingValue("True")]
  public bool CheckForms {
    get {
      return (bool)this[nameof(CheckForms)];
    }
    set {
      this[nameof(CheckForms)] = value;
    }
  }

  [Serializable()]
  public enum SortOptions {
    LevelAsc,
    LevelDesc,
    MetDateAsc,
    //MetDateDesc,
    ShinyAsc,
    ShinyDesc,
    GenderAsc,
    GenderDesc,
  }

  /// <summary>
  /// Additional sorting options to be applied after Pokédex sorting
  /// </summary>
  [UserScopedSetting()]
  [Description("Additional sorting options to be applied after Pokédex sorting")]
  public SortOptions[] AdditionalSortOptions {
    get {
      return (SortOptions[])this[nameof(AdditionalSortOptions)];
    }
    set {
      this[nameof(AdditionalSortOptions)] = value;
    }
  }

}
