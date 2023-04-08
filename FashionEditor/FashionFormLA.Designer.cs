namespace PluginPile.FashionEditor {
  partial class FashionFormLA {
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
      cancelButton = new Button();
      saveButton = new Button();
      tabControl = new TabControl();
      hatsPage = new TabPage();
      topsPage = new TabPage();
      bottomsPage = new TabPage();
      uniformsPage = new TabPage();
      shoesPage = new TabPage();
      glassesPage = new TabPage();
      tabControl.SuspendLayout();
      SuspendLayout();
      //
      // cancelButton
      //
      cancelButton.Location = new Point(12, 117);
      cancelButton.Name = "cancelButton";
      cancelButton.Size = new Size(75, 23);
      cancelButton.TabIndex = 0;
      cancelButton.Text = "Cancel";
      cancelButton.UseVisualStyleBackColor = true;
      cancelButton.Click += cancelButton_Click;
      //
      // saveButton
      //
      saveButton.Location = new Point(93, 117);
      saveButton.Name = "saveButton";
      saveButton.Size = new Size(75, 23);
      saveButton.TabIndex = 1;
      saveButton.Text = "Save";
      saveButton.UseVisualStyleBackColor = true;
      saveButton.Click += saveButton_Click;
      //
      // tabControl
      //
      tabControl.Controls.Add(hatsPage);
      tabControl.Controls.Add(topsPage);
      tabControl.Controls.Add(bottomsPage);
      tabControl.Controls.Add(uniformsPage);
      tabControl.Controls.Add(shoesPage);
      tabControl.Controls.Add(glassesPage);
      tabControl.Location = new Point(12, 12);
      tabControl.Name = "tabControl1";
      tabControl.SelectedIndex = 0;
      tabControl.Size = new Size(327, 99);
      tabControl.TabIndex = 2;
      //
      // hatsPage
      //
      hatsPage.Location = new Point(4, 24);
      hatsPage.Name = "hatsPage";
      hatsPage.Padding = new Padding(3);
      hatsPage.Size = new Size(319, 71);
      hatsPage.TabIndex = 0;
      hatsPage.Text = "Hats";
      hatsPage.UseVisualStyleBackColor = true;
      //
      // topsPage
      //
      topsPage.Location = new Point(4, 24);
      topsPage.Name = "topsPage";
      topsPage.Padding = new Padding(3);
      topsPage.Size = new Size(319, 115);
      topsPage.TabIndex = 1;
      topsPage.Text = "Tops";
      topsPage.UseVisualStyleBackColor = true;
      //
      // bottomsPage
      //
      bottomsPage.Location = new Point(4, 24);
      bottomsPage.Name = "bottomsPage";
      bottomsPage.Size = new Size(319, 115);
      bottomsPage.TabIndex = 2;
      bottomsPage.Text = "Bottoms";
      bottomsPage.UseVisualStyleBackColor = true;
      //
      // uniformsPage
      //
      uniformsPage.Location = new Point(4, 24);
      uniformsPage.Name = "uniformsPage";
      uniformsPage.Size = new Size(319, 115);
      uniformsPage.TabIndex = 3;
      uniformsPage.Text = "Uniforms";
      uniformsPage.UseVisualStyleBackColor = true;
      //
      // shoesPage
      //
      shoesPage.Location = new Point(4, 24);
      shoesPage.Name = "shoesPage";
      shoesPage.Size = new Size(319, 115);
      shoesPage.TabIndex = 4;
      shoesPage.Text = "Shoes";
      shoesPage.UseVisualStyleBackColor = true;
      //
      // glassesPage
      //
      glassesPage.Location = new Point(4, 24);
      glassesPage.Name = "glassesPage";
      glassesPage.Size = new Size(319, 115);
      glassesPage.TabIndex = 5;
      glassesPage.Text = "Glasses";
      glassesPage.UseVisualStyleBackColor = true;
      //
      // FashionFormLA
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(344, 151);
      Controls.Add(tabControl);
      Controls.Add(saveButton);
      Controls.Add(cancelButton);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FashionFormLA";
      ShowIcon = false;
      Text = "LA Fashion Editor";
      tabControl.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Button cancelButton;
    private Button saveButton;
    private TabControl tabControl;
    private TabPage hatsPage;
    private TabPage topsPage;
    private TabPage bottomsPage;
    private TabPage uniformsPage;
    private TabPage shoesPage;
    private TabPage glassesPage;
  }
}
