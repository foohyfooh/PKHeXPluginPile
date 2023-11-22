namespace PluginPile.Unmaintained.BWTool;

public class FileIO {
  /// <summary>
  /// Reads data into a complete array, throwing an EndOfStreamException
  /// if the stream runs out of data first, or if an IOException
  /// naturally occurs.
  /// </summary>
  /// <param name="stream">The stream to read data from</param>
  /// <param name="data">The array to read bytes into. The array
  /// will be completely filled from the stream, so an appropriate
  /// size must be given.</param>
  private static void ReadWholeArray(Stream stream, ref byte[] data) {
    int offset = 0;
    int remaining = data.Length;
    while (remaining > 0) {
      int read = stream.Read(data, offset, remaining);
      if (read <= 0)
        throw new EndOfStreamException
            (string.Format("End of stream reached with {0} bytes left to read", remaining));
      remaining -= read;
      offset += read;
    }
  }

  private static void ReadData(ref byte[]? buffer, string path) {
    FileStream file;
    file = new FileStream(path, FileMode.Open);
    if (file.Length < 1) {
      MessageBox.Show("Invalid file length", "Error");
      return;
    }
    buffer = new byte[file.Length];
    ReadWholeArray(file, ref buffer);
    file.Close();
  }

  public static int LoadFile(ref byte[]? buffer, ref string? path, string filter) {
    if (path == null) {
      OpenFileDialog openFD = new OpenFileDialog();
      openFD.Filter = filter;
      if (openFD.ShowDialog() == DialogResult.OK) {
        path = openFD.FileName;
        ReadData(ref buffer, path);
        return buffer != null ? buffer.Length : -1;
      } else {
        return -1;
      }
    } else {
      ReadData(ref buffer, path);
      return buffer != null ? buffer.Length : -1;
    }
  }

  public static void SaveFile(byte[] buffer, string filter) {
    if (buffer == null) return;
    SaveFileDialog saveFD = new SaveFileDialog();
    saveFD.Filter = filter;
    if (saveFD.ShowDialog() == DialogResult.OK) {
      FileStream saveFile;
      saveFile = new FileStream(saveFD.FileName, FileMode.Create);
      saveFile.Write(buffer, 0, buffer.Length);
      saveFile.Close();
      MessageBox.Show("File Saved.", "Save file");
    }
  }
}
