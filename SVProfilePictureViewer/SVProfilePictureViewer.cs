using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.SVProfilePictureViewer {
  internal class SVProfilePictureViewer : PluginBase {
    public override string Name => nameof(SVProfilePictureViewer);
    protected override Assembly PluginAssembly => typeof(SVProfilePictureViewer).Assembly;
    private ToolStripMenuItem ImageViewerButton = null!;
    private bool IsSaveCompatable => SaveFileEditor.SAV is SAV9SV;
    
    protected override void LoadMenu(ToolStripDropDownItem tools) {
      ImageViewerButton = new ToolStripMenuItem(Language.PluginName);
      ImageViewerButton.Available = IsSaveCompatable;
      ImageViewerButton.Click += (s, e) => new PictureViewerForm((SAV9SV)SaveFileEditor.SAV).ShowDialogInParent();
      tools.DropDownItems.Add(ImageViewerButton);
    }

    protected override void HandleSaveLoaded() => ImageViewerButton.Available = IsSaveCompatable;
  }
}
