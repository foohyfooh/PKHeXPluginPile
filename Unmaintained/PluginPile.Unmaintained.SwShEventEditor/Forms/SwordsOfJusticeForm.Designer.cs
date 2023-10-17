namespace PluginPile.Unmaintained.SwShEventEditor {
    partial class SwordsOfJusticeForm {
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cfootper_NUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tfootper_NUD = new System.Windows.Forms.NumericUpDown();
            this.vfootper_NUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.apply_BTN = new System.Windows.Forms.Button();
            this.keldeo_CB = new System.Windows.Forms.CheckBox();
            this.cobalion_CB = new System.Windows.Forms.CheckBox();
            this.terrakion_CB = new System.Windows.Forms.CheckBox();
            this.virizion_CB = new System.Windows.Forms.CheckBox();
            this.legality_CB = new System.Windows.Forms.CheckBox();
            this.legality_LBL = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfootper_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfootper_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vfootper_NUD)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox6
            //
            this.groupBox6.Controls.Add(this.virizion_CB);
            this.groupBox6.Controls.Add(this.terrakion_CB);
            this.groupBox6.Controls.Add(this.cobalion_CB);
            this.groupBox6.Controls.Add(this.keldeo_CB);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(132, 115);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Caught";
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.vfootper_NUD);
            this.groupBox1.Controls.Add(this.tfootper_NUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cfootper_NUD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(150, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 115);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Footprint Percentage";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cobalion";
            //
            // cfootper_NUD
            //
            this.cfootper_NUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cfootper_NUD.Location = new System.Drawing.Point(69, 19);
            this.cfootper_NUD.Name = "cfootper_NUD";
            this.cfootper_NUD.Size = new System.Drawing.Size(50, 20);
            this.cfootper_NUD.TabIndex = 48;
            this.cfootper_NUD.ValueChanged += new System.EventHandler(this.cfootper_NUD_ValueChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Terrakion";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Virizion";
            //
            // tfootper_NUD
            //
            this.tfootper_NUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tfootper_NUD.Location = new System.Drawing.Point(69, 45);
            this.tfootper_NUD.Name = "tfootper_NUD";
            this.tfootper_NUD.Size = new System.Drawing.Size(50, 20);
            this.tfootper_NUD.TabIndex = 50;
            this.tfootper_NUD.ValueChanged += new System.EventHandler(this.tfootper_NUD_ValueChanged);
            //
            // vfootper_NUD
            //
            this.vfootper_NUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.vfootper_NUD.Location = new System.Drawing.Point(69, 71);
            this.vfootper_NUD.Name = "vfootper_NUD";
            this.vfootper_NUD.Size = new System.Drawing.Size(50, 20);
            this.vfootper_NUD.TabIndex = 51;
            this.vfootper_NUD.ValueChanged += new System.EventHandler(this.vfootper_NUD_ValueChanged);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "%";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "%";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "%";
            //
            // apply_BTN
            //
            this.apply_BTN.Location = new System.Drawing.Point(12, 133);
            this.apply_BTN.Name = "apply_BTN";
            this.apply_BTN.Size = new System.Drawing.Size(132, 48);
            this.apply_BTN.TabIndex = 47;
            this.apply_BTN.Text = "Apply Selection";
            this.apply_BTN.UseVisualStyleBackColor = true;
            this.apply_BTN.Click += new System.EventHandler(this.apply_BTN_Click);
            //
            // keldeo_CB
            //
            this.keldeo_CB.AutoSize = true;
            this.keldeo_CB.Enabled = false;
            this.keldeo_CB.Location = new System.Drawing.Point(6, 91);
            this.keldeo_CB.Name = "keldeo_CB";
            this.keldeo_CB.Size = new System.Drawing.Size(59, 17);
            this.keldeo_CB.TabIndex = 48;
            this.keldeo_CB.Text = "Keldeo";
            this.keldeo_CB.UseVisualStyleBackColor = true;
            this.keldeo_CB.CheckedChanged += new System.EventHandler(this.keldeo_CB_CheckedChanged);
            //
            // cobalion_CB
            //
            this.cobalion_CB.AutoSize = true;
            this.cobalion_CB.Enabled = false;
            this.cobalion_CB.Location = new System.Drawing.Point(6, 22);
            this.cobalion_CB.Name = "cobalion_CB";
            this.cobalion_CB.Size = new System.Drawing.Size(67, 17);
            this.cobalion_CB.TabIndex = 49;
            this.cobalion_CB.Text = "Cobalion";
            this.cobalion_CB.UseVisualStyleBackColor = true;
            this.cobalion_CB.CheckedChanged += new System.EventHandler(this.cobalion_CB_CheckedChanged);
            //
            // terrakion_CB
            //
            this.terrakion_CB.AutoSize = true;
            this.terrakion_CB.Enabled = false;
            this.terrakion_CB.Location = new System.Drawing.Point(6, 45);
            this.terrakion_CB.Name = "terrakion_CB";
            this.terrakion_CB.Size = new System.Drawing.Size(71, 17);
            this.terrakion_CB.TabIndex = 50;
            this.terrakion_CB.Text = "Terrakion";
            this.terrakion_CB.UseVisualStyleBackColor = true;
            this.terrakion_CB.CheckedChanged += new System.EventHandler(this.terrakion_CB_CheckedChanged);
            //
            // virizion_CB
            //
            this.virizion_CB.AutoSize = true;
            this.virizion_CB.Enabled = false;
            this.virizion_CB.Location = new System.Drawing.Point(6, 68);
            this.virizion_CB.Name = "virizion_CB";
            this.virizion_CB.Size = new System.Drawing.Size(59, 17);
            this.virizion_CB.TabIndex = 51;
            this.virizion_CB.Text = "Virizion";
            this.virizion_CB.UseVisualStyleBackColor = true;
            this.virizion_CB.CheckedChanged += new System.EventHandler(this.virizion_CB_CheckedChanged);
            //
            // legality_CB
            //
            this.legality_CB.AutoSize = true;
            this.legality_CB.Checked = true;
            this.legality_CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.legality_CB.Location = new System.Drawing.Point(150, 150);
            this.legality_CB.Name = "legality_CB";
            this.legality_CB.Size = new System.Drawing.Size(143, 17);
            this.legality_CB.TabIndex = 53;
            this.legality_CB.Text = "Force legality corrections";
            this.legality_CB.UseVisualStyleBackColor = true;
            this.legality_CB.CheckedChanged += new System.EventHandler(this.legality_CB_CheckedChanged);
            //
            // legality_LBL
            //
            this.legality_LBL.AutoSize = true;
            this.legality_LBL.Location = new System.Drawing.Point(150, 133);
            this.legality_LBL.Name = "legality_LBL";
            this.legality_LBL.Size = new System.Drawing.Size(69, 13);
            this.legality_LBL.TabIndex = 54;
            this.legality_LBL.Text = "Legal Status:";
            //
            // SOJForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 191);
            this.Controls.Add(this.legality_LBL);
            this.Controls.Add(this.legality_CB);
            this.Controls.Add(this.apply_BTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SOJForm";
            this.Text = "Swords of Justice Editor";
            this.Load += new System.EventHandler(this.SOJForm_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfootper_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfootper_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vfootper_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox keldeo_CB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown vfootper_NUD;
        private System.Windows.Forms.NumericUpDown tfootper_NUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cfootper_NUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply_BTN;
        private System.Windows.Forms.CheckBox virizion_CB;
        private System.Windows.Forms.CheckBox terrakion_CB;
        private System.Windows.Forms.CheckBox cobalion_CB;
        private System.Windows.Forms.CheckBox legality_CB;
        private System.Windows.Forms.Label legality_LBL;
    }
}
