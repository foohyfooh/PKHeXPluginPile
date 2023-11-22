namespace PluginPile.Unmaintained.BWTool {
  partial class MemoryLinkForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button Exit_but;
    private System.Windows.Forms.Button Saveexit_but;
    private System.Windows.Forms.Button b1_export;
    private System.Windows.Forms.Button b1m_export;
    private System.Windows.Forms.Button b2_export;
    private System.Windows.Forms.Button b2_import;
    private System.Windows.Forms.Button b1m_import;
    private System.Windows.Forms.Button b1_import;
    private System.Windows.Forms.Button memory_export;
    private System.Windows.Forms.Button memory_import;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown sid;
    private System.Windows.Forms.NumericUpDown tid;
    private System.Windows.Forms.CheckBox flag8;
    private System.Windows.Forms.CheckBox flag7;
    private System.Windows.Forms.CheckBox flag6;
    private System.Windows.Forms.CheckBox flag5;
    private System.Windows.Forms.CheckBox flag4;
    private System.Windows.Forms.CheckBox flag3;
    private System.Windows.Forms.CheckBox flag2;
    private System.Windows.Forms.CheckBox flag1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button import_bw1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;

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
    /// </summary>
    private void InitializeComponent() {
      Exit_but = new Button();
      Saveexit_but = new Button();
      b1_export = new Button();
      b1m_export = new Button();
      b2_export = new Button();
      b2_import = new Button();
      b1m_import = new Button();
      b1_import = new Button();
      memory_export = new Button();
      memory_import = new Button();
      groupBox1 = new GroupBox();
      PROP = new Label();
      label11 = new Label();
      name = new TextBox();
      sid = new NumericUpDown();
      tid = new NumericUpDown();
      label3 = new Label();
      label2 = new Label();
      label1 = new Label();
      flag8 = new CheckBox();
      flag7 = new CheckBox();
      flag6 = new CheckBox();
      flag5 = new CheckBox();
      flag4 = new CheckBox();
      flag3 = new CheckBox();
      flag2 = new CheckBox();
      flag1 = new CheckBox();
      label4 = new Label();
      import_bw1 = new Button();
      label5 = new Label();
      label6 = new Label();
      label7 = new Label();
      label8 = new Label();
      label9 = new Label();
      starter = new ComboBox();
      label10 = new Label();
      PropUnlockBut = new Button();
      groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)sid).BeginInit();
      ((System.ComponentModel.ISupportInitialize)tid).BeginInit();
      SuspendLayout();
      // 
      // Exit_but
      // 
      Exit_but.Location = new Point(35, 325);
      Exit_but.Margin = new Padding(4, 3, 4, 3);
      Exit_but.Name = "Exit_but";
      Exit_but.Size = new Size(119, 27);
      Exit_but.TabIndex = 21;
      Exit_but.Text = "Exit";
      Exit_but.UseVisualStyleBackColor = true;
      Exit_but.Click += Exit_butClick;
      // 
      // Saveexit_but
      // 
      Saveexit_but.Location = new Point(160, 325);
      Saveexit_but.Margin = new Padding(4, 3, 4, 3);
      Saveexit_but.Name = "Saveexit_but";
      Saveexit_but.Size = new Size(119, 27);
      Saveexit_but.TabIndex = 20;
      Saveexit_but.Text = "Save and Exit";
      Saveexit_but.UseVisualStyleBackColor = true;
      Saveexit_but.Click += Saveexit_butClick;
      // 
      // b1_export
      // 
      b1_export.Location = new Point(7, 22);
      b1_export.Margin = new Padding(4, 3, 4, 3);
      b1_export.Name = "b1_export";
      b1_export.Size = new Size(139, 43);
      b1_export.TabIndex = 22;
      b1_export.Text = "Export Block 1 (decrypted)";
      b1_export.UseVisualStyleBackColor = true;
      b1_export.Click += B1_exportClick;
      // 
      // b1m_export
      // 
      b1m_export.Location = new Point(7, 72);
      b1m_export.Margin = new Padding(4, 3, 4, 3);
      b1m_export.Name = "b1m_export";
      b1m_export.Size = new Size(139, 43);
      b1m_export.TabIndex = 23;
      b1m_export.Text = "Export Block 1 Mirror (decrypted)";
      b1m_export.UseVisualStyleBackColor = true;
      b1m_export.Click += B1m_exportClick;
      // 
      // b2_export
      // 
      b2_export.Location = new Point(7, 121);
      b2_export.Margin = new Padding(4, 3, 4, 3);
      b2_export.Name = "b2_export";
      b2_export.Size = new Size(139, 43);
      b2_export.TabIndex = 24;
      b2_export.Text = "Export Block 2";
      b2_export.UseVisualStyleBackColor = true;
      b2_export.Click += B2_exportClick;
      // 
      // b2_import
      // 
      b2_import.Location = new Point(153, 121);
      b2_import.Margin = new Padding(4, 3, 4, 3);
      b2_import.Name = "b2_import";
      b2_import.Size = new Size(139, 43);
      b2_import.TabIndex = 27;
      b2_import.Text = "Import Block 2";
      b2_import.UseVisualStyleBackColor = true;
      b2_import.Click += B2_importClick;
      // 
      // b1m_import
      // 
      b1m_import.Location = new Point(153, 72);
      b1m_import.Margin = new Padding(4, 3, 4, 3);
      b1m_import.Name = "b1m_import";
      b1m_import.Size = new Size(139, 43);
      b1m_import.TabIndex = 26;
      b1m_import.Text = "Import Block 1 Mirror (decrypted)";
      b1m_import.UseVisualStyleBackColor = true;
      b1m_import.Click += B1m_importClick;
      // 
      // b1_import
      // 
      b1_import.Location = new Point(153, 22);
      b1_import.Margin = new Padding(4, 3, 4, 3);
      b1_import.Name = "b1_import";
      b1_import.Size = new Size(139, 43);
      b1_import.TabIndex = 25;
      b1_import.Text = "Import Block 1 (decrypted)";
      b1_import.UseVisualStyleBackColor = true;
      b1_import.Click += B1_importClick;
      // 
      // memory_export
      // 
      memory_export.Location = new Point(14, 14);
      memory_export.Margin = new Padding(4, 3, 4, 3);
      memory_export.Name = "memory_export";
      memory_export.Size = new Size(139, 43);
      memory_export.TabIndex = 29;
      memory_export.Text = "Export Memories";
      memory_export.UseVisualStyleBackColor = true;
      memory_export.Click += Memory_exportClick;
      // 
      // memory_import
      // 
      memory_import.Location = new Point(160, 14);
      memory_import.Margin = new Padding(4, 3, 4, 3);
      memory_import.Name = "memory_import";
      memory_import.Size = new Size(139, 43);
      memory_import.TabIndex = 28;
      memory_import.Text = "Import Memories";
      memory_import.UseVisualStyleBackColor = true;
      memory_import.Click += Memory_importClick;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(PROP);
      groupBox1.Controls.Add(label11);
      groupBox1.Controls.Add(b2_import);
      groupBox1.Controls.Add(b1m_import);
      groupBox1.Controls.Add(b1_import);
      groupBox1.Controls.Add(b2_export);
      groupBox1.Controls.Add(b1m_export);
      groupBox1.Controls.Add(b1_export);
      groupBox1.Location = new Point(464, 162);
      groupBox1.Margin = new Padding(4, 3, 4, 3);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(4, 3, 4, 3);
      groupBox1.Size = new Size(297, 190);
      groupBox1.TabIndex = 30;
      groupBox1.TabStop = false;
      groupBox1.Text = "Research Purposes";
      // 
      // PROP
      // 
      PROP.Location = new Point(64, 164);
      PROP.Margin = new Padding(4, 0, 4, 0);
      PROP.Name = "PROP";
      PROP.Size = new Size(227, 23);
      PROP.TabIndex = 55;
      PROP.Text = "0";
      // 
      // label11
      // 
      label11.Location = new Point(7, 164);
      label11.Margin = new Padding(4, 0, 4, 0);
      label11.Name = "label11";
      label11.Size = new Size(78, 23);
      label11.TabIndex = 54;
      label11.Text = "Props: 0x";
      // 
      // name
      // 
      name.Location = new Point(135, 85);
      name.Margin = new Padding(4, 3, 4, 3);
      name.MaxLength = 8;
      name.Name = "name";
      name.Size = new Size(139, 23);
      name.TabIndex = 36;
      // 
      // sid
      // 
      sid.Location = new Point(136, 145);
      sid.Margin = new Padding(4, 3, 4, 3);
      sid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
      sid.Name = "sid";
      sid.Size = new Size(140, 23);
      sid.TabIndex = 35;
      // 
      // tid
      // 
      tid.Location = new Point(136, 115);
      tid.Margin = new Padding(4, 3, 4, 3);
      tid.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
      tid.Name = "tid";
      tid.Size = new Size(140, 23);
      tid.TabIndex = 34;
      // 
      // label3
      // 
      label3.Location = new Point(40, 148);
      label3.Margin = new Padding(4, 0, 4, 0);
      label3.Name = "label3";
      label3.Size = new Size(59, 27);
      label3.TabIndex = 33;
      label3.Text = "SID";
      // 
      // label2
      // 
      label2.Location = new Point(40, 118);
      label2.Margin = new Padding(4, 0, 4, 0);
      label2.Name = "label2";
      label2.Size = new Size(59, 27);
      label2.TabIndex = 32;
      label2.Text = "TID";
      // 
      // label1
      // 
      label1.Location = new Point(40, 89);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(59, 27);
      label1.TabIndex = 31;
      label1.Text = "Name";
      // 
      // flag8
      // 
      flag8.Location = new Point(239, 285);
      flag8.Margin = new Padding(4, 3, 4, 3);
      flag8.Name = "flag8";
      flag8.Size = new Size(191, 33);
      flag8.TabIndex = 44;
      flag8.Text = "flag 8";
      flag8.UseVisualStyleBackColor = true;
      // 
      // flag7
      // 
      flag7.Location = new Point(239, 255);
      flag7.Margin = new Padding(4, 3, 4, 3);
      flag7.Name = "flag7";
      flag7.Size = new Size(146, 33);
      flag7.TabIndex = 43;
      flag7.Text = "flag 7";
      flag7.UseVisualStyleBackColor = true;
      // 
      // flag6
      // 
      flag6.Location = new Point(239, 225);
      flag6.Margin = new Padding(4, 3, 4, 3);
      flag6.Name = "flag6";
      flag6.Size = new Size(146, 33);
      flag6.TabIndex = 42;
      flag6.Text = "flag 6";
      flag6.UseVisualStyleBackColor = true;
      // 
      // flag5
      // 
      flag5.Location = new Point(239, 195);
      flag5.Margin = new Padding(4, 3, 4, 3);
      flag5.Name = "flag5";
      flag5.Size = new Size(146, 33);
      flag5.TabIndex = 41;
      flag5.Text = "flag 5";
      flag5.UseVisualStyleBackColor = true;
      // 
      // flag4
      // 
      flag4.Location = new Point(62, 285);
      flag4.Margin = new Padding(4, 3, 4, 3);
      flag4.Name = "flag4";
      flag4.Size = new Size(146, 33);
      flag4.TabIndex = 40;
      flag4.Text = "flag 4";
      flag4.UseVisualStyleBackColor = true;
      // 
      // flag3
      // 
      flag3.Location = new Point(62, 255);
      flag3.Margin = new Padding(4, 3, 4, 3);
      flag3.Name = "flag3";
      flag3.Size = new Size(146, 33);
      flag3.TabIndex = 39;
      flag3.Text = "flag 3";
      flag3.UseVisualStyleBackColor = true;
      // 
      // flag2
      // 
      flag2.Location = new Point(62, 225);
      flag2.Margin = new Padding(4, 3, 4, 3);
      flag2.Name = "flag2";
      flag2.Size = new Size(146, 33);
      flag2.TabIndex = 38;
      flag2.Text = "flag 2";
      flag2.UseVisualStyleBackColor = true;
      // 
      // flag1
      // 
      flag1.Location = new Point(62, 195);
      flag1.Margin = new Padding(4, 3, 4, 3);
      flag1.Name = "flag1";
      flag1.Size = new Size(146, 33);
      flag1.TabIndex = 37;
      flag1.Text = "A Triple Team";
      flag1.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      label4.Location = new Point(14, 174);
      label4.Margin = new Padding(4, 0, 4, 0);
      label4.Name = "label4";
      label4.Size = new Size(357, 22);
      label4.TabIndex = 45;
      label4.Text = "Unlocked Memories: (still under research, better not to touch)";
      label4.TextAlign = ContentAlignment.BottomLeft;
      // 
      // import_bw1
      // 
      import_bw1.Location = new Point(318, 14);
      import_bw1.Margin = new Padding(4, 3, 4, 3);
      import_bw1.Name = "import_bw1";
      import_bw1.Size = new Size(139, 43);
      import_bw1.TabIndex = 46;
      import_bw1.Text = "Import data from BW";
      import_bw1.UseVisualStyleBackColor = true;
      import_bw1.Click += Import_bw1Click;
      // 
      // label5
      // 
      label5.Location = new Point(462, 32);
      label5.Margin = new Padding(4, 0, 4, 0);
      label5.Name = "label5";
      label5.Size = new Size(172, 43);
      label5.TabIndex = 47;
      label5.Text = "Will import:";
      // 
      // label6
      // 
      label6.Location = new Point(540, 6);
      label6.Margin = new Padding(4, 0, 4, 0);
      label6.Name = "label6";
      label6.Size = new Size(154, 27);
      label6.TabIndex = 48;
      label6.Text = "- Trainer name, TID, SID";
      // 
      // label7
      // 
      label7.Location = new Point(540, 22);
      label7.Margin = new Padding(4, 0, 4, 0);
      label7.Name = "label7";
      label7.Size = new Size(154, 27);
      label7.TabIndex = 49;
      label7.Text = "- Hall of Fame";
      // 
      // label8
      // 
      label8.Location = new Point(540, 39);
      label8.Margin = new Padding(4, 0, 4, 0);
      label8.Name = "label8";
      label8.Size = new Size(154, 27);
      label8.TabIndex = 50;
      label8.Text = "- Starter Pokémon";
      // 
      // label9
      // 
      label9.Location = new Point(282, 89);
      label9.Margin = new Padding(4, 0, 4, 0);
      label9.Name = "label9";
      label9.Size = new Size(59, 27);
      label9.TabIndex = 51;
      label9.Text = "Starter";
      // 
      // starter
      // 
      starter.FormattingEnabled = true;
      starter.Items.AddRange(new object[] { "Snivy", "Tepig", "Oshawott" });
      starter.Location = new Point(329, 85);
      starter.Margin = new Padding(4, 3, 4, 3);
      starter.Name = "starter";
      starter.Size = new Size(140, 23);
      starter.TabIndex = 52;
      // 
      // label10
      // 
      label10.Location = new Point(540, 55);
      label10.Margin = new Padding(4, 0, 4, 0);
      label10.Name = "label10";
      label10.Size = new Size(154, 27);
      label10.TabIndex = 53;
      label10.Text = "- Props";
      // 
      // PropUnlockBut
      // 
      PropUnlockBut.Location = new Point(329, 119);
      PropUnlockBut.Margin = new Padding(4, 3, 4, 3);
      PropUnlockBut.Name = "PropUnlockBut";
      PropUnlockBut.Size = new Size(141, 27);
      PropUnlockBut.TabIndex = 54;
      PropUnlockBut.Text = "Unlock All Props";
      PropUnlockBut.UseVisualStyleBackColor = true;
      PropUnlockBut.Click += PropUnlockButClick;
      // 
      // MemoryLinkForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(769, 366);
      Controls.Add(PropUnlockBut);
      Controls.Add(label10);
      Controls.Add(starter);
      Controls.Add(label9);
      Controls.Add(label8);
      Controls.Add(label7);
      Controls.Add(label6);
      Controls.Add(label5);
      Controls.Add(import_bw1);
      Controls.Add(label4);
      Controls.Add(flag8);
      Controls.Add(flag7);
      Controls.Add(flag6);
      Controls.Add(flag5);
      Controls.Add(flag4);
      Controls.Add(flag3);
      Controls.Add(flag2);
      Controls.Add(flag1);
      Controls.Add(name);
      Controls.Add(sid);
      Controls.Add(tid);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(groupBox1);
      Controls.Add(memory_export);
      Controls.Add(memory_import);
      Controls.Add(Exit_but);
      Controls.Add(Saveexit_but);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "MemoryLinkForm";
      Text = "Memory Link Editor";
      Load += MemoryLinkLoad;
      groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)sid).EndInit();
      ((System.ComponentModel.ISupportInitialize)tid).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private System.Windows.Forms.Button PropUnlockBut;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label PROP;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox starter;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
  }
}
