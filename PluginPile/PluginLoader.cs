using System.Reflection;
using PluginPile.Common;
using PluginPile.Sorting;
using PluginPile.RaidImporter;
using PluginPile.SVivillon;
using PluginPile.FashionEditor;
using PluginPile.SVProfilePictureViewer;
using PluginPile.XYRoamerTool;
using PluginPile.RentalViewer;

namespace PluginPile; 
public class PluginLoader : PluginBase {
  public override string Name => "Plugin Pile";
  protected override Assembly PluginAssembly => typeof(PluginLoader).Assembly;

  private readonly SortingPlugin sortingPlugin;
  private readonly RaidImportPlugin raidImportPlugin;
  private readonly SVivillonPlugin svVivillonPlugin;
  private readonly FashionEditorPlugin fashionEditorPlugin;
  private readonly SVProfilePictureViewerPlugin svProfilePictureViewerPlugin;
  private readonly XYRoamerPlugin xyRoamerPlugin;
  private readonly RentalViewerPlugin rentalViewerPlugin;

  public PluginLoader() {
    sortingPlugin = new SortingPlugin();
    raidImportPlugin = new RaidImportPlugin();
    svVivillonPlugin = new SVivillonPlugin();
    fashionEditorPlugin = new FashionEditorPlugin();
    svProfilePictureViewerPlugin = new SVProfilePictureViewerPlugin();
    xyRoamerPlugin = new XYRoamerPlugin();
    rentalViewerPlugin = new RentalViewerPlugin();
  }

  public override void Initialize(params object[] args) {
    sortingPlugin.Initialize(args);
    raidImportPlugin.Initialize(args);
    svVivillonPlugin.Initialize(args);
    fashionEditorPlugin.Initialize(args);
    svProfilePictureViewerPlugin.Initialize(args);
    xyRoamerPlugin.Initialize(args);
    rentalViewerPlugin.Initialize(args);
  }

  public override void NotifySaveLoaded() {
    sortingPlugin.NotifySaveLoaded();
    raidImportPlugin.NotifySaveLoaded();
    svVivillonPlugin.NotifySaveLoaded();
    fashionEditorPlugin.NotifySaveLoaded();
    svProfilePictureViewerPlugin.NotifySaveLoaded();
    xyRoamerPlugin.NotifySaveLoaded();
    rentalViewerPlugin.NotifySaveLoaded();
  }

}
