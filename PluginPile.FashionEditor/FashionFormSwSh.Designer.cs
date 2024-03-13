namespace PluginPile.FashionEditor {
  partial class FashionFormSwSh {
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
      TopsPage = new TabPage();
      JacketsPage = new TabPage();
      BottomsPage = new TabPage();
      SocksPage = new TabPage();
      ShoesPage = new TabPage();
      BagsPage = new TabPage();
      HatsPage = new TabPage();
      GlassesPage = new TabPage();
      GlovesPage = new TabPage();
      TabControl.SuspendLayout();
      SuspendLayout();
      //
      // Cancel
      //
      Cancel.Location = new Point(12, 106);
      Cancel.Name = "Cancel";
      Cancel.Size = new Size(75, 23);
      Cancel.TabIndex = 0;
      Cancel.Text = "Cancel";
      Cancel.UseVisualStyleBackColor = true;
      Cancel.Click += CancelButton_Click;
      //
      // SaveButton
      //
      SaveButton.Location = new Point(93, 106);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(75, 23);
      SaveButton.TabIndex = 1;
      SaveButton.Text = "Save";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      //
      // TabControl
      //
      TabControl.Controls.Add(TopsPage);
      TabControl.Controls.Add(JacketsPage);
      TabControl.Controls.Add(BottomsPage);
      TabControl.Controls.Add(SocksPage);
      TabControl.Controls.Add(ShoesPage);
      TabControl.Controls.Add(BagsPage);
      TabControl.Controls.Add(HatsPage);
      TabControl.Controls.Add(GlassesPage);
      TabControl.Controls.Add(GlovesPage);
      TabControl.Location = new Point(0, 0);
      TabControl.Name = "TabControl";
      TabControl.SelectedIndex = 0;
      TabControl.Size = new Size(517, 100);
      TabControl.TabIndex = 2;
      //
      // TopsPage
      //
      TopsPage.Location = new Point(4, 24);
      TopsPage.Name = "TopsPage";
      TopsPage.Padding = new Padding(3);
      TopsPage.Size = new Size(509, 72);
      TopsPage.TabIndex = 0;
      TopsPage.Text = "Tops";
      TopsPage.UseVisualStyleBackColor = true;
      //
      // JacketsPage
      //
      JacketsPage.Location = new Point(4, 24);
      JacketsPage.Name = "JacketsPage";
      JacketsPage.Padding = new Padding(3);
      JacketsPage.Size = new Size(509, 72);
      JacketsPage.TabIndex = 1;
      JacketsPage.Text = "Jackets";
      JacketsPage.UseVisualStyleBackColor = true;
      //
      // BottomsPage
      //
      BottomsPage.Location = new Point(4, 24);
      BottomsPage.Name = "BottomsPage";
      BottomsPage.Size = new Size(509, 72);
      BottomsPage.TabIndex = 2;
      BottomsPage.Text = "Bottoms";
      BottomsPage.UseVisualStyleBackColor = true;
      //
      // SocksPage
      //
      SocksPage.Location = new Point(4, 24);
      SocksPage.Name = "SocksPage";
      SocksPage.Size = new Size(509, 72);
      SocksPage.TabIndex = 3;
      SocksPage.Text = "Socks";
      SocksPage.UseVisualStyleBackColor = true;
      //
      // ShoesPage
      //
      ShoesPage.Location = new Point(4, 24);
      ShoesPage.Name = "ShoesPage";
      ShoesPage.Size = new Size(509, 72);
      ShoesPage.TabIndex = 4;
      ShoesPage.Text = "Shoes";
      ShoesPage.UseVisualStyleBackColor = true;
      //
      // BagsPage
      //
      BagsPage.Location = new Point(4, 24);
      BagsPage.Name = "BagsPage";
      BagsPage.Size = new Size(509, 72);
      BagsPage.TabIndex = 5;
      BagsPage.Text = "Bag";
      BagsPage.UseVisualStyleBackColor = true;
      //
      // HatsPage
      //
      HatsPage.Location = new Point(4, 24);
      HatsPage.Name = "HatsPage";
      HatsPage.Size = new Size(509, 72);
      HatsPage.TabIndex = 6;
      HatsPage.Text = "Hats";
      HatsPage.UseVisualStyleBackColor = true;
      //
      // GlassesPage
      //
      GlassesPage.Location = new Point(4, 24);
      GlassesPage.Name = "GlassesPage";
      GlassesPage.Size = new Size(509, 72);
      GlassesPage.TabIndex = 7;
      GlassesPage.Text = "Glasses";
      GlassesPage.UseVisualStyleBackColor = true;
      //
      // GlovesPage
      //
      GlovesPage.Location = new Point(4, 24);
      GlovesPage.Name = "GlovesPage";
      GlovesPage.Padding = new Padding(3);
      GlovesPage.Size = new Size(509, 72);
      GlovesPage.TabIndex = 8;
      GlovesPage.Text = "Gloves";
      GlovesPage.UseVisualStyleBackColor = true;
      //
      // FashionFormSwSh
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(529, 136);
      Controls.Add(TabControl);
      Controls.Add(SaveButton);
      Controls.Add(Cancel);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FashionFormSwSh";
      ShowIcon = false;
      Text = "SwSh Fashion Editor";
      TabControl.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Button Cancel;
    private Button SaveButton;
    private TabControl TabControl;
    private TabPage TopsPage;
    private TabPage JacketsPage;
    private TabPage BottomsPage;
    private TabPage SocksPage;
    private TabPage ShoesPage;
    private TabPage BagsPage;
    private TabPage HatsPage;
    private TabPage GlassesPage;
    private TabPage GlovesPage;
  }
}
