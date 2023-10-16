using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.SVProfilePictureViewer {
  public class SVProfilePictureViewerPlugin : PluginBase {
    public override string Name => nameof(SVProfilePictureViewerPlugin);
    protected override Assembly PluginAssembly => typeof(SVProfilePictureViewerPlugin).Assembly;
    private readonly ToolStripMenuItem ImageViewerButton;
    private bool IsSaveCompatable => SaveFileEditor.SAV is SAV9SV;

    public SVProfilePictureViewerPlugin() {
      ImageViewerButton = new ToolStripMenuItem(Language.PluginName);
      ImageViewerButton.Click += (s, e) => new PictureViewerForm((SAV9SV)SaveFileEditor.SAV).ShowDialogInParent();
    }

    
    protected override void LoadMenu(ToolStripDropDownItem tools) {
      ImageViewerButton.Available = IsSaveCompatable;
      tools.DropDownItems.Add(ImageViewerButton);
    }

    protected override void HandleSaveLoaded() => ImageViewerButton.Available = IsSaveCompatable;
  }
}
