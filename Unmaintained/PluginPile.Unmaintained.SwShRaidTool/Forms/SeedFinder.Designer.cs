namespace PluginPile.Unmaintained.SwShRaidTool
{
    partial class SeedFinder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinSpe = new System.Windows.Forms.NumericUpDown();
            this.minSpd = new System.Windows.Forms.NumericUpDown();
            this.minSpa = new System.Windows.Forms.NumericUpDown();
            this.minDef = new System.Windows.Forms.NumericUpDown();
            this.minAtk = new System.Windows.Forms.NumericUpDown();
            this.minHP = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seedSlow = new System.Windows.Forms.Button();
            this.seedFast = new System.Windows.Forms.Button();
            this.PIDBox = new System.Windows.Forms.TextBox();
            this.ECBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SeedResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EC";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PID";
            //
            // MinSpe
            //
            this.MinSpe.Location = new System.Drawing.Point(65, 162);
            this.MinSpe.Margin = new System.Windows.Forms.Padding(2);
            this.MinSpe.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.MinSpe.Name = "MinSpe";
            this.MinSpe.Size = new System.Drawing.Size(73, 20);
            this.MinSpe.TabIndex = 26;
            this.MinSpe.Enter += new System.EventHandler(this.MinHP_Enter);
            //
            // minSpd
            //
            this.minSpd.Location = new System.Drawing.Point(65, 141);
            this.minSpd.Margin = new System.Windows.Forms.Padding(2);
            this.minSpd.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minSpd.Name = "minSpd";
            this.minSpd.Size = new System.Drawing.Size(73, 20);
            this.minSpd.TabIndex = 25;
            this.minSpd.Enter += new System.EventHandler(this.MinHP_Enter);
            //
            // minSpa
            //
            this.minSpa.Location = new System.Drawing.Point(65, 121);
            this.minSpa.Margin = new System.Windows.Forms.Padding(2);
            this.minSpa.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minSpa.Name = "minSpa";
            this.minSpa.Size = new System.Drawing.Size(73, 20);
            this.minSpa.TabIndex = 24;
            this.minSpa.Enter += new System.EventHandler(this.MinHP_Enter);
            //
            // minDef
            //
            this.minDef.Location = new System.Drawing.Point(65, 101);
            this.minDef.Margin = new System.Windows.Forms.Padding(2);
            this.minDef.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minDef.Name = "minDef";
            this.minDef.Size = new System.Drawing.Size(73, 20);
            this.minDef.TabIndex = 23;
            this.minDef.Enter += new System.EventHandler(this.MinHP_Enter);
            //
            // minAtk
            //
            this.minAtk.Location = new System.Drawing.Point(65, 80);
            this.minAtk.Margin = new System.Windows.Forms.Padding(2);
            this.minAtk.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minAtk.Name = "minAtk";
            this.minAtk.Size = new System.Drawing.Size(73, 20);
            this.minAtk.TabIndex = 22;
            this.minAtk.Enter += new System.EventHandler(this.MinHP_Enter);
            //
            // minHP
            //
            this.minHP.Location = new System.Drawing.Point(65, 60);
            this.minHP.Margin = new System.Windows.Forms.Padding(2);
            this.minHP.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minHP.Name = "minHP";
            this.minHP.Size = new System.Drawing.Size(73, 20);
            this.minHP.TabIndex = 21;
            this.minHP.Enter += new System.EventHandler(this.MinHP_Enter);
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 166);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "SPE";
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "SPD";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "SPA";
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "DEF";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "ATK";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "HP";
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.seedSlow);
            this.groupBox1.Controls.Add(this.seedFast);
            this.groupBox1.Controls.Add(this.PIDBox);
            this.groupBox1.Controls.Add(this.ECBox);
            this.groupBox1.Controls.Add(this.minDef);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MinSpe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.minSpd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.minSpa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.minAtk);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.minHP);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 249);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PKMN Information";
            //
            // seedSlow
            //
            this.seedSlow.Location = new System.Drawing.Point(13, 216);
            this.seedSlow.Margin = new System.Windows.Forms.Padding(2);
            this.seedSlow.Name = "seedSlow";
            this.seedSlow.Size = new System.Drawing.Size(125, 23);
            this.seedSlow.TabIndex = 30;
            this.seedSlow.Text = "Calculate Seed (Slow)";
            this.seedSlow.UseVisualStyleBackColor = true;
            this.seedSlow.Click += new System.EventHandler(this.SeedSlow_Click);
            //
            // seedFast
            //
            this.seedFast.Location = new System.Drawing.Point(13, 190);
            this.seedFast.Margin = new System.Windows.Forms.Padding(2);
            this.seedFast.Name = "seedFast";
            this.seedFast.Size = new System.Drawing.Size(125, 23);
            this.seedFast.TabIndex = 29;
            this.seedFast.Text = "Calculate Seed (Fast)";
            this.seedFast.UseVisualStyleBackColor = true;
            this.seedFast.Click += new System.EventHandler(this.SeedFast_Click);
            //
            // PIDBox
            //
            this.PIDBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDBox.Location = new System.Drawing.Point(65, 40);
            this.PIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.PIDBox.MaxLength = 8;
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(74, 20);
            this.PIDBox.TabIndex = 1;
            this.PIDBox.Enter += new System.EventHandler(this.ECBox_Enter);
            this.PIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeedBox_KeyPress);
            //
            // ECBox
            //
            this.ECBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECBox.Location = new System.Drawing.Point(65, 20);
            this.ECBox.Margin = new System.Windows.Forms.Padding(2);
            this.ECBox.MaxLength = 8;
            this.ECBox.Name = "ECBox";
            this.ECBox.Size = new System.Drawing.Size(74, 20);
            this.ECBox.TabIndex = 0;
            this.ECBox.Enter += new System.EventHandler(this.ECBox_Enter);
            this.ECBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeedBox_KeyPress);
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.SeedResult);
            this.groupBox2.Location = new System.Drawing.Point(9, 263);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(150, 62);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculated Seed";
            //
            // SeedResult
            //
            this.SeedResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedResult.Location = new System.Drawing.Point(13, 27);
            this.SeedResult.Margin = new System.Windows.Forms.Padding(2);
            this.SeedResult.Name = "SeedResult";
            this.SeedResult.ReadOnly = true;
            this.SeedResult.Size = new System.Drawing.Size(126, 20);
            this.SeedResult.TabIndex = 0;
            //
            // SeedFinder
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(184, 377);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(184, 377);
            this.Name = "SeedFinder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SeedFinder";
            ((System.ComponentModel.ISupportInitialize)(this.MinSpe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MinSpe;
        private System.Windows.Forms.NumericUpDown minSpd;
        private System.Windows.Forms.NumericUpDown minSpa;
        private System.Windows.Forms.NumericUpDown minDef;
        private System.Windows.Forms.NumericUpDown minAtk;
        private System.Windows.Forms.NumericUpDown minHP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PIDBox;
        private System.Windows.Forms.TextBox ECBox;
        private System.Windows.Forms.Button seedSlow;
        private System.Windows.Forms.Button seedFast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SeedResult;
    }
}
