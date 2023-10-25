using System.Reflection;

namespace PluginPile.Unmaintained.SwShRaidTool;
public static class WinFormsUtil {
  /// <summary>
  /// Centers the <see cref="child"/> horizontally and vertically so that its center is the same as the <see cref="parent"/>'s center.
  /// </summary>
  /// <param name="child"></param>
  /// <param name="parent"></param>
  internal static void CenterToForm(this Control child, Control parent) {
    int x = parent.Location.X + ((parent.Width - child.Width) / 2);
    int y = parent.Location.Y + ((parent.Height - child.Height) / 2);
    child.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
  }

  public static void DoubleBuffered(this DataGridView dgv, bool setting) {
    Type dgvType = dgv.GetType();
    PropertyInfo? pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
    pi?.SetValue(dgv, setting, null);
  }

  /// <summary>
  /// Displays a dialog showing the details of an error.
  /// </summary>
  /// <param name="lines">User-friendly message about the error.</param>
  /// <returns>The <see cref="DialogResult"/> associated with the dialog.</returns>
  internal static DialogResult Error(params string[] lines) {
    System.Media.SystemSounds.Hand.Play();
    string msg = string.Join(Environment.NewLine + Environment.NewLine, lines);
    return MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }

  internal static DialogResult Alert(params string[] lines) {
    System.Media.SystemSounds.Asterisk.Play();
    string msg = string.Join(Environment.NewLine + Environment.NewLine, lines);
    return MessageBox.Show(msg, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
  }

  internal static DialogResult Prompt(MessageBoxButtons btn, params string[] lines) {
    System.Media.SystemSounds.Question.Play();
    string msg = string.Join(Environment.NewLine + Environment.NewLine, lines);
    return MessageBox.Show(msg, "Prompt", btn, MessageBoxIcon.Asterisk);
  }
}
