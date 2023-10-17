namespace PluginPile.Unmaintained.SwShEventEditor.Controls {
    partial class WondercardControl {
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.main_LB = new System.Windows.Forms.ListBox();
            this.open_wondercard_BTN = new System.Windows.Forms.Button();
            this.clearlist_BTN = new System.Windows.Forms.Button();
            this.delete_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // main_LB
            //
            this.main_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_LB.FormattingEnabled = true;
            this.main_LB.Location = new System.Drawing.Point(0, 0);
            this.main_LB.Name = "main_LB";
            this.main_LB.Size = new System.Drawing.Size(133, 121);
            this.main_LB.TabIndex = 0;
            this.main_LB.SelectedIndexChanged += new System.EventHandler(this.main_LB_SelectedIndexChanged);
            //
            // open_wondercard_BTN
            //
            this.open_wondercard_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open_wondercard_BTN.Location = new System.Drawing.Point(139, 3);
            this.open_wondercard_BTN.Name = "open_wondercard_BTN";
            this.open_wondercard_BTN.Size = new System.Drawing.Size(136, 32);
            this.open_wondercard_BTN.TabIndex = 1;
            this.open_wondercard_BTN.Text = "Open Wondercard(s) File";
            this.open_wondercard_BTN.UseVisualStyleBackColor = true;
            this.open_wondercard_BTN.Click += new System.EventHandler(this.open_wondercard_BTN_Click);
            //
            // clearlist_BTN
            //
            this.clearlist_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearlist_BTN.Enabled = false;
            this.clearlist_BTN.Location = new System.Drawing.Point(139, 41);
            this.clearlist_BTN.Name = "clearlist_BTN";
            this.clearlist_BTN.Size = new System.Drawing.Size(136, 32);
            this.clearlist_BTN.TabIndex = 2;
            this.clearlist_BTN.Text = "Clear List";
            this.clearlist_BTN.UseVisualStyleBackColor = true;
            this.clearlist_BTN.Click += new System.EventHandler(this.clearlist_BTN_Click);
            //
            // delete_BTN
            //
            this.delete_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_BTN.Enabled = false;
            this.delete_BTN.Location = new System.Drawing.Point(139, 79);
            this.delete_BTN.Name = "delete_BTN";
            this.delete_BTN.Size = new System.Drawing.Size(136, 32);
            this.delete_BTN.TabIndex = 3;
            this.delete_BTN.Text = "Delete Selected";
            this.delete_BTN.UseVisualStyleBackColor = true;
            this.delete_BTN.Click += new System.EventHandler(this.delete_BTN_Click);
            //
            // WondercardControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_BTN);
            this.Controls.Add(this.clearlist_BTN);
            this.Controls.Add(this.open_wondercard_BTN);
            this.Controls.Add(this.main_LB);
            this.Name = "WondercardControl";
            this.Size = new System.Drawing.Size(278, 121);
            this.Load += new System.EventHandler(this.WondercardControl_Load);
            this.Resize += new System.EventHandler(this.WondercardControl_Resize);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox main_LB;
        private System.Windows.Forms.Button open_wondercard_BTN;
        private System.Windows.Forms.Button clearlist_BTN;
        private System.Windows.Forms.Button delete_BTN;
    }
}
