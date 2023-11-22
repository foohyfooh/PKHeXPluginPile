namespace PluginPile.Unmaintained.BWTool {
  partial class TrainerRecordsForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.NumericUpDown record_value;
    private System.Windows.Forms.ComboBox record_index;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    private void InitializeComponent() {
      record_value = new NumericUpDown();
      record_index = new ComboBox();
      ((System.ComponentModel.ISupportInitialize)record_value).BeginInit();
      SuspendLayout();
      //
      // record_value
      //
      record_value.Location = new Point(331, 58);
      record_value.Margin = new Padding(4, 3, 4, 3);
      record_value.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
      record_value.Name = "record_value";
      record_value.Size = new Size(140, 23);
      record_value.TabIndex = 0;
      //
      // record_index
      //
      record_index.FormattingEnabled = true;
      record_index.Items.AddRange(new object[] { "001", "002", "003", "004", "005 - Wild Pokémon Encounters", "006 - Trainers Battled", "007", "008", "009", "010", "011", "012", "013", "014", "015", "016", "017", "018", "019", "020", "021", "022", "023", "024", "025", "026", "027", "028", "029", "030", "031", "032", "033", "034", "035", "036", "037", "038", "039", "040", "041", "042", "043", "044", "045", "046", "047", "048", "049", "050", "051", "052", "053", "054", "055", "056", "057", "058", "059", "060", "061", "062", "063", "064", "065", "066", "067", "068", "069", "070", "071", "072", "073", "074", "075", "076", "077", "078", "079", "080", "081", "082", "083", "084", "085", "086", "087", "088", "089", "090", "091", "092", "093", "094", "095", "096", "097", "098", "099", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118" });
      record_index.Location = new Point(65, 57);
      record_index.Margin = new Padding(4, 3, 4, 3);
      record_index.Name = "record_index";
      record_index.Size = new Size(140, 23);
      record_index.TabIndex = 1;
      record_index.SelectedIndexChanged += Record_indexSelectedIndexChanged;
      //
      // TrainerRecordsForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(831, 330);
      Controls.Add(record_index);
      Controls.Add(record_value);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "TrainerRecordsForm";
      Text = "Trainer Card Records Editor";
      ((System.ComponentModel.ISupportInitialize)record_value).EndInit();
      ResumeLayout(false);
    }
  }
}
