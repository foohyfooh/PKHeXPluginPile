namespace PluginPile.Unmaintained.SwShEventEditor {
    partial class RegiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.regieleki_RBTN = new System.Windows.Forms.RadioButton();
            this.regidrago_RBTN = new System.Windows.Forms.RadioButton();
            this.regi_clistbox = new System.Windows.Forms.CheckedListBox();
            this.reginone_RBTN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regiother_patrBTN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.regipatternNUD = new System.Windows.Forms.NumericUpDown();
            this.regieleki_patrBTN = new System.Windows.Forms.RadioButton();
            this.reginone_patrBTN = new System.Windows.Forms.RadioButton();
            this.regidrago_patrBTN = new System.Windows.Forms.RadioButton();
            this.legailty_CB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applyBTN = new System.Windows.Forms.Button();
            this.legalLBL = new System.Windows.Forms.Label();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regipatternNUD)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox12
            //
            this.groupBox12.Controls.Add(this.regieleki_RBTN);
            this.groupBox12.Controls.Add(this.regidrago_RBTN);
            this.groupBox12.Controls.Add(this.regi_clistbox);
            this.groupBox12.Controls.Add(this.reginone_RBTN);
            this.groupBox12.Location = new System.Drawing.Point(12, 12);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(132, 181);
            this.groupBox12.TabIndex = 53;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Caught";
            //
            // regieleki_RBTN
            //
            this.regieleki_RBTN.AutoSize = true;
            this.regieleki_RBTN.Location = new System.Drawing.Point(6, 135);
            this.regieleki_RBTN.Name = "regieleki_RBTN";
            this.regieleki_RBTN.Size = new System.Drawing.Size(69, 17);
            this.regieleki_RBTN.TabIndex = 54;
            this.regieleki_RBTN.Text = "Regieleki";
            this.regieleki_RBTN.UseVisualStyleBackColor = true;
            this.regieleki_RBTN.CheckedChanged += new System.EventHandler(this.regieleki_RBTN_CheckedChanged);
            //
            // regidrago_RBTN
            //
            this.regidrago_RBTN.AutoSize = true;
            this.regidrago_RBTN.Location = new System.Drawing.Point(6, 112);
            this.regidrago_RBTN.Name = "regidrago_RBTN";
            this.regidrago_RBTN.Size = new System.Drawing.Size(74, 17);
            this.regidrago_RBTN.TabIndex = 53;
            this.regidrago_RBTN.Text = "Regidrago";
            this.regidrago_RBTN.UseVisualStyleBackColor = true;
            this.regidrago_RBTN.CheckedChanged += new System.EventHandler(this.regidrago_RBTN_CheckedChanged);
            //
            // regi_clistbox
            //
            this.regi_clistbox.FormattingEnabled = true;
            this.regi_clistbox.Items.AddRange(new object[] {
            "Regirock",
            "Regice",
            "Registeel",
            "Regigigas"});
            this.regi_clistbox.Location = new System.Drawing.Point(6, 19);
            this.regi_clistbox.Name = "regi_clistbox";
            this.regi_clistbox.Size = new System.Drawing.Size(120, 64);
            this.regi_clistbox.TabIndex = 50;
            //
            // reginone_RBTN
            //
            this.reginone_RBTN.AutoSize = true;
            this.reginone_RBTN.Checked = true;
            this.reginone_RBTN.Location = new System.Drawing.Point(6, 89);
            this.reginone_RBTN.Name = "reginone_RBTN";
            this.reginone_RBTN.Size = new System.Drawing.Size(59, 17);
            this.reginone_RBTN.TabIndex = 52;
            this.reginone_RBTN.TabStop = true;
            this.reginone_RBTN.Text = "Neither";
            this.reginone_RBTN.UseVisualStyleBackColor = true;
            this.reginone_RBTN.CheckedChanged += new System.EventHandler(this.reginone_RBTN_CheckedChanged);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.regiother_patrBTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.regipatternNUD);
            this.groupBox1.Controls.Add(this.regieleki_patrBTN);
            this.groupBox1.Controls.Add(this.reginone_patrBTN);
            this.groupBox1.Controls.Add(this.regidrago_patrBTN);
            this.groupBox1.Location = new System.Drawing.Point(150, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 181);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Regi Pattern";
            //
            // regiother_patrBTN
            //
            this.regiother_patrBTN.AutoSize = true;
            this.regiother_patrBTN.Location = new System.Drawing.Point(6, 88);
            this.regiother_patrBTN.Name = "regiother_patrBTN";
            this.regiother_patrBTN.Size = new System.Drawing.Size(51, 17);
            this.regiother_patrBTN.TabIndex = 57;
            this.regiother_patrBTN.Text = "Other";
            this.regiother_patrBTN.UseVisualStyleBackColor = true;
            this.regiother_patrBTN.CheckedChanged += new System.EventHandler(this.regiother_patrBTN_CheckedChanged);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Raw Pattern Value";
            //
            // regipatternNUD
            //
            this.regipatternNUD.Enabled = false;
            this.regipatternNUD.Location = new System.Drawing.Point(9, 155);
            this.regipatternNUD.Name = "regipatternNUD";
            this.regipatternNUD.Size = new System.Drawing.Size(93, 20);
            this.regipatternNUD.TabIndex = 55;
            this.regipatternNUD.ValueChanged += new System.EventHandler(this.regipatternNUD_ValueChanged);
            //
            // regieleki_patrBTN
            //
            this.regieleki_patrBTN.AutoSize = true;
            this.regieleki_patrBTN.Location = new System.Drawing.Point(6, 65);
            this.regieleki_patrBTN.Name = "regieleki_patrBTN";
            this.regieleki_patrBTN.Size = new System.Drawing.Size(69, 17);
            this.regieleki_patrBTN.TabIndex = 57;
            this.regieleki_patrBTN.Text = "Regieleki";
            this.regieleki_patrBTN.UseVisualStyleBackColor = true;
            this.regieleki_patrBTN.CheckedChanged += new System.EventHandler(this.regieleki_patrBTN_CheckedChanged);
            //
            // reginone_patrBTN
            //
            this.reginone_patrBTN.AutoSize = true;
            this.reginone_patrBTN.Checked = true;
            this.reginone_patrBTN.Location = new System.Drawing.Point(6, 19);
            this.reginone_patrBTN.Name = "reginone_patrBTN";
            this.reginone_patrBTN.Size = new System.Drawing.Size(59, 17);
            this.reginone_patrBTN.TabIndex = 55;
            this.reginone_patrBTN.TabStop = true;
            this.reginone_patrBTN.Text = "Neither";
            this.reginone_patrBTN.UseVisualStyleBackColor = true;
            this.reginone_patrBTN.CheckedChanged += new System.EventHandler(this.reginone_patrBTN_CheckedChanged);
            //
            // regidrago_patrBTN
            //
            this.regidrago_patrBTN.AutoSize = true;
            this.regidrago_patrBTN.Location = new System.Drawing.Point(6, 42);
            this.regidrago_patrBTN.Name = "regidrago_patrBTN";
            this.regidrago_patrBTN.Size = new System.Drawing.Size(74, 17);
            this.regidrago_patrBTN.TabIndex = 56;
            this.regidrago_patrBTN.Text = "Regidrago";
            this.regidrago_patrBTN.UseVisualStyleBackColor = true;
            this.regidrago_patrBTN.CheckedChanged += new System.EventHandler(this.regidrago_patrBTN_CheckedChanged);
            //
            // legailty_CB
            //
            this.legailty_CB.AutoSize = true;
            this.legailty_CB.Location = new System.Drawing.Point(150, 215);
            this.legailty_CB.Name = "legailty_CB";
            this.legailty_CB.Size = new System.Drawing.Size(143, 17);
            this.legailty_CB.TabIndex = 57;
            this.legailty_CB.Text = "Force legality corrections";
            this.legailty_CB.UseVisualStyleBackColor = true;
            this.legailty_CB.CheckedChanged += new System.EventHandler(this.forcematchCB_CheckedChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 56;
            //
            // applyBTN
            //
            this.applyBTN.Location = new System.Drawing.Point(12, 199);
            this.applyBTN.Name = "applyBTN";
            this.applyBTN.Size = new System.Drawing.Size(129, 48);
            this.applyBTN.TabIndex = 57;
            this.applyBTN.Text = "Apply Selection";
            this.applyBTN.UseVisualStyleBackColor = true;
            this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
            //
            // legalLBL
            //
            this.legalLBL.AutoSize = true;
            this.legalLBL.Location = new System.Drawing.Point(147, 199);
            this.legalLBL.Name = "legalLBL";
            this.legalLBL.Size = new System.Drawing.Size(92, 13);
            this.legalLBL.TabIndex = 58;
            this.legalLBL.Text = "Legal Status: N/A";
            //
            // RegiForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 256);
            this.Controls.Add(this.legalLBL);
            this.Controls.Add(this.legailty_CB);
            this.Controls.Add(this.applyBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegiForm";
            this.Text = "RegiForm Editor";
            this.Load += new System.EventHandler(this.RegiForm_Load);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regipatternNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton regieleki_RBTN;
        private System.Windows.Forms.RadioButton regidrago_RBTN;
        private System.Windows.Forms.RadioButton reginone_RBTN;
        private System.Windows.Forms.CheckedListBox regi_clistbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox legailty_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown regipatternNUD;
        private System.Windows.Forms.RadioButton regieleki_patrBTN;
        private System.Windows.Forms.RadioButton reginone_patrBTN;
        private System.Windows.Forms.RadioButton regidrago_patrBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton regiother_patrBTN;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.Label legalLBL;
    }
}
