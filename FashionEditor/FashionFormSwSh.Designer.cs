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
      cancelButton = new Button();
      saveButton = new Button();
      tabControl = new TabControl();
      topsPage = new TabPage();
      jacketsPage = new TabPage();
      bottomsPage = new TabPage();
      dressesPage = new TabPage();
      socksPage = new TabPage();
      shoesPage = new TabPage();
      bagsPage = new TabPage();
      hatsPage = new TabPage();
      glassesPage = new TabPage();
      glovesPage = new TabPage();
      tabControl.SuspendLayout();
      SuspendLayout();
      // 
      // cancelButton
      // 
      cancelButton.Location = new Point(12, 106);
      cancelButton.Name = "cancelButton";
      cancelButton.Size = new Size(75, 23);
      cancelButton.TabIndex = 0;
      cancelButton.Text = "Cancel";
      cancelButton.UseVisualStyleBackColor = true;
      cancelButton.Click += cancelButton_Click;
      // 
      // saveButton
      // 
      saveButton.Location = new Point(93, 106);
      saveButton.Name = "saveButton";
      saveButton.Size = new Size(75, 23);
      saveButton.TabIndex = 1;
      saveButton.Text = "Save";
      saveButton.UseVisualStyleBackColor = true;
      saveButton.Click += saveButton_Click;
      // 
      // tabControl
      // 
      tabControl.Controls.Add(topsPage);
      tabControl.Controls.Add(jacketsPage);
      tabControl.Controls.Add(bottomsPage);
      tabControl.Controls.Add(dressesPage);
      tabControl.Controls.Add(socksPage);
      tabControl.Controls.Add(shoesPage);
      tabControl.Controls.Add(bagsPage);
      tabControl.Controls.Add(glovesPage);
      tabControl.Controls.Add(hatsPage);
      tabControl.Controls.Add(glassesPage);
      tabControl.Location = new Point(0, 0);
      tabControl.Name = "tabControl";
      tabControl.SelectedIndex = 0;
      tabControl.Size = new Size(517, 100);
      tabControl.TabIndex = 2;
      // 
      // topsPage
      // 
      topsPage.Location = new Point(4, 24);
      topsPage.Name = "topsPage";
      topsPage.Padding = new Padding(3);
      topsPage.Size = new Size(509, 72);
      topsPage.TabIndex = 0;
      topsPage.Text = "Tops";
      topsPage.UseVisualStyleBackColor = true;
      // 
      // jacketsPage
      // 
      jacketsPage.Location = new Point(4, 24);
      jacketsPage.Name = "jacketsPage";
      jacketsPage.Padding = new Padding(3);
      jacketsPage.Size = new Size(509, 72);
      jacketsPage.TabIndex = 1;
      jacketsPage.Text = "Jackets";
      jacketsPage.UseVisualStyleBackColor = true;
      // 
      // bottomsPage
      // 
      bottomsPage.Location = new Point(4, 24);
      bottomsPage.Name = "bottomsPage";
      bottomsPage.Size = new Size(509, 72);
      bottomsPage.TabIndex = 2;
      bottomsPage.Text = "Bottoms";
      bottomsPage.UseVisualStyleBackColor = true;
      // 
      // dressesPage
      // 
      dressesPage.Location = new Point(4, 24);
      dressesPage.Name = "dressesPage";
      dressesPage.Size = new Size(509, 72);
      dressesPage.TabIndex = 9;
      dressesPage.Text = "Dresses";
      dressesPage.UseVisualStyleBackColor = true;
      // 
      // socksPage
      // 
      socksPage.Location = new Point(4, 24);
      socksPage.Name = "socksPage";
      socksPage.Size = new Size(509, 72);
      socksPage.TabIndex = 3;
      socksPage.Text = "Socks";
      socksPage.UseVisualStyleBackColor = true;
      // 
      // shoesPage
      // 
      shoesPage.Location = new Point(4, 24);
      shoesPage.Name = "shoesPage";
      shoesPage.Size = new Size(509, 72);
      shoesPage.TabIndex = 4;
      shoesPage.Text = "Shoes";
      shoesPage.UseVisualStyleBackColor = true;
      // 
      // bagsPage
      // 
      bagsPage.Location = new Point(4, 24);
      bagsPage.Name = "bagsPage";
      bagsPage.Size = new Size(509, 72);
      bagsPage.TabIndex = 5;
      bagsPage.Text = "Bag";
      bagsPage.UseVisualStyleBackColor = true;
      // 
      // hatsPage
      // 
      hatsPage.Location = new Point(4, 24);
      hatsPage.Name = "hatsPage";
      hatsPage.Size = new Size(509, 72);
      hatsPage.TabIndex = 6;
      hatsPage.Text = "Hats";
      hatsPage.UseVisualStyleBackColor = true;
      // 
      // glassesPage
      // 
      glassesPage.Location = new Point(4, 24);
      glassesPage.Name = "glassesPage";
      glassesPage.Size = new Size(509, 72);
      glassesPage.TabIndex = 7;
      glassesPage.Text = "Glasses";
      glassesPage.UseVisualStyleBackColor = true;
      // 
      // glovesPage
      // 
      glovesPage.Location = new Point(4, 24);
      glovesPage.Name = "glovesPage";
      glovesPage.Padding = new Padding(3);
      glovesPage.Size = new Size(509, 72);
      glovesPage.TabIndex = 8;
      glovesPage.Text = "Gloves";
      glovesPage.UseVisualStyleBackColor = true;
      // 
      // FashionFormSwSh
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(529, 136);
      Controls.Add(tabControl);
      Controls.Add(saveButton);
      Controls.Add(cancelButton);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FashionFormSwSh";
      ShowIcon = false;
      Text = "SwSh Fashion Editor";
      tabControl.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Button cancelButton;
    private Button saveButton;
    private TabControl tabControl;
    private TabPage topsPage;
    private TabPage jacketsPage;
    private TabPage bottomsPage;
    private TabPage dressesPage;
    private TabPage socksPage;
    private TabPage shoesPage;
    private TabPage bagsPage;
    private TabPage hatsPage;
    private TabPage glassesPage;
    private TabPage glovesPage;
  }
}
