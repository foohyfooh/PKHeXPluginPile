namespace PluginPile.StartDateEditor {
  partial class DateEditorForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      startDateLabel = new Label();
      startDatePicker = new DateTimePicker();
      cancelButton = new Button();
      saveButton = new Button();
      SuspendLayout();
      //
      // startDateLabel
      //
      startDateLabel.AutoSize = true;
      startDateLabel.Location = new Point(12, 9);
      startDateLabel.Name = "startDateLabel";
      startDateLabel.Size = new Size(58, 15);
      startDateLabel.TabIndex = 0;
      startDateLabel.Text = "Start Date";
      startDateLabel.Click += startDateLabel_Click;
      //
      // startDatePicker
      //
      startDatePicker.Location = new Point(12, 27);
      startDatePicker.Name = "startDatePicker";
      startDatePicker.Size = new Size(216, 23);
      startDatePicker.TabIndex = 1;
      startDatePicker.Value = new DateTime(2023, 3, 28, 17, 25, 55, 0);
      //
      // cancelButton
      //
      cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      cancelButton.Location = new Point(12, 56);
      cancelButton.Name = "cancelButton";
      cancelButton.Size = new Size(75, 23);
      cancelButton.TabIndex = 2;
      cancelButton.Text = "Cancel";
      cancelButton.UseVisualStyleBackColor = true;
      cancelButton.Click += cancelButton_Click;
      //
      // saveButton
      //
      saveButton.Location = new Point(93, 56);
      saveButton.Name = "saveButton";
      saveButton.Size = new Size(75, 23);
      saveButton.TabIndex = 3;
      saveButton.Text = "Save";
      saveButton.UseVisualStyleBackColor = true;
      saveButton.Click += saveButton_Click;
      //
      // DateEditorForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      ClientSize = new Size(240, 88);
      Controls.Add(saveButton);
      Controls.Add(cancelButton);
      Controls.Add(startDatePicker);
      Controls.Add(startDateLabel);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "DateEditorForm";
      ShowIcon = false;
      Text = "Start Date Editor";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label startDateLabel;
    private DateTimePicker startDatePicker;
    private Button cancelButton;
    private Button saveButton;
  }
}
