namespace PluginPile.Common;
public static class FormExtensions {

  public static DialogResult ShowDialogInParent(this Form form, Form parent) {
    form.Parent = parent;
    form.StartPosition = FormStartPosition.CenterParent;
    return form.ShowDialog();
  }

  // Hack: Keep a static copy of the main PKHeX window in PluginBase to not have specify it each time
  //       since extension methods have to be static methods
  public static DialogResult ShowDialogInParent(this Form form) {
    return form.ShowDialogInParent(PluginBase.MainWindow);
  }

}
