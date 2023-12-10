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
      Cancel = new Button();
      SaveButton = new Button();
      TabControl = new TabControl();
      HatsPage = new TabPage();
      TopsPage = new TabPage();
      BottomsPage = new TabPage();
      UniformsPage = new TabPage();
      ShoesPage = new TabPage();
      GlassesPage = new TabPage();
      TabControl.SuspendLayout();
      SuspendLayout();
      // 
      // Cancel
      // 
      Cancel.Location = new Point(12, 117);
      Cancel.Name = "Cancel";
      Cancel.Size = new Size(75, 23);
      Cancel.TabIndex = 0;
      Cancel.Text = "Cancel";
      Cancel.UseVisualStyleBackColor = true;
      Cancel.Click += CancelButton_Click;
      // 
      // SaveButton
      // 
      SaveButton.Location = new Point(93, 117);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(75, 23);
      SaveButton.TabIndex = 1;
      SaveButton.Text = "Save";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // TabControl
      // 
      TabControl.Controls.Add(HatsPage);
      TabControl.Controls.Add(TopsPage);
      TabControl.Controls.Add(BottomsPage);
      TabControl.Controls.Add(UniformsPage);
      TabControl.Controls.Add(ShoesPage);
      TabControl.Controls.Add(GlassesPage);
      TabControl.Location = new Point(12, 12);
      TabControl.Name = "TabControl";
      TabControl.SelectedIndex = 0;
      TabControl.Size = new Size(327, 99);
      TabControl.TabIndex = 2;
      // 
      // HatsPage
      // 
      HatsPage.Location = new Point(4, 24);
      HatsPage.Name = "HatsPage";
      HatsPage.Padding = new Padding(3);
      HatsPage.Size = new Size(319, 71);
      HatsPage.TabIndex = 0;
      HatsPage.Text = "Hats";
      HatsPage.UseVisualStyleBackColor = true;
      // 
      // TopsPage
      // 
      TopsPage.Location = new Point(4, 24);
      TopsPage.Name = "TopsPage";
      TopsPage.Padding = new Padding(3);
      TopsPage.Size = new Size(319, 71);
      TopsPage.TabIndex = 1;
      TopsPage.Text = "Tops";
      TopsPage.UseVisualStyleBackColor = true;
      // 
      // BottomsPage
      // 
      BottomsPage.Location = new Point(4, 24);
      BottomsPage.Name = "BottomsPage";
      BottomsPage.Size = new Size(319, 71);
      BottomsPage.TabIndex = 2;
      BottomsPage.Text = "Bottoms";
      BottomsPage.UseVisualStyleBackColor = true;
      // 
      // UniformsPage
      // 
      UniformsPage.Location = new Point(4, 24);
      UniformsPage.Name = "UniformsPage";
      UniformsPage.Size = new Size(319, 71);
      UniformsPage.TabIndex = 3;
      UniformsPage.Text = "Uniforms";
      UniformsPage.UseVisualStyleBackColor = true;
      // 
      // ShoesPage
      // 
      ShoesPage.Location = new Point(4, 24);
      ShoesPage.Name = "ShoesPage";
      ShoesPage.Size = new Size(319, 71);
      ShoesPage.TabIndex = 4;
      ShoesPage.Text = "Shoes";
      ShoesPage.UseVisualStyleBackColor = true;
      // 
      // GlassesPage
      // 
      GlassesPage.Location = new Point(4, 24);
      GlassesPage.Name = "GlassesPage";
      GlassesPage.Size = new Size(319, 71);
      GlassesPage.TabIndex = 5;
      GlassesPage.Text = "Glasses";
      GlassesPage.UseVisualStyleBackColor = true;
      // 
      // FashionFormLA
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(344, 151);
      Controls.Add(TabControl);
      Controls.Add(SaveButton);
      Controls.Add(Cancel);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FashionFormLA";
      ShowIcon = false;
      Text = "LA Fashion Editor";
      TabControl.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Button Cancel;
    private Button SaveButton;
    private TabControl TabControl;
    private TabPage HatsPage;
    private TabPage TopsPage;
    private TabPage BottomsPage;
    private TabPage UniformsPage;
    private TabPage ShoesPage;
    private TabPage GlassesPage;
  }
}
