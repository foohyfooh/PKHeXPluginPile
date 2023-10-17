namespace PluginPile.Unmaintained.SwShEventEditor.Controls {
    partial class PokemonBaseUC {
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
            this.components = new System.ComponentModel.Container();
            this.caught_CB = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.caughtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.illegalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokeName = new System.Windows.Forms.Label();
            this.pokemonRenderUC1 = new PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // caught_CB
            //
            this.caught_CB.AutoSize = true;
            this.caught_CB.Location = new System.Drawing.Point(74, 16);
            this.caught_CB.Name = "caught_CB";
            this.caught_CB.Size = new System.Drawing.Size(60, 17);
            this.caught_CB.TabIndex = 1;
            this.caught_CB.Text = "Caught";
            this.caught_CB.UseVisualStyleBackColor = true;
            this.caught_CB.CheckedChanged += new System.EventHandler(this.caught_CB_CheckedChanged);
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caughtToolStripMenuItem,
            this.viewHintToolStripMenuItem,
            this.toolStripSeparator1,
            this.illegalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            //
            // caughtToolStripMenuItem
            //
            this.caughtToolStripMenuItem.CheckOnClick = true;
            this.caughtToolStripMenuItem.Image = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources._ball4;
            this.caughtToolStripMenuItem.Name = "caughtToolStripMenuItem";
            this.caughtToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.caughtToolStripMenuItem.Text = "Caught";
            this.caughtToolStripMenuItem.Click += new System.EventHandler(this.caughtToolStripMenuItem_Click);
            //
            // viewHintToolStripMenuItem
            //
            this.viewHintToolStripMenuItem.Image = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.hint;
            this.viewHintToolStripMenuItem.Name = "viewHintToolStripMenuItem";
            this.viewHintToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewHintToolStripMenuItem.Text = "View Hint";
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            //
            // illegalToolStripMenuItem
            //
            this.illegalToolStripMenuItem.Image = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.warn;
            this.illegalToolStripMenuItem.Name = "illegalToolStripMenuItem";
            this.illegalToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.illegalToolStripMenuItem.Text = "Illegal";
            this.illegalToolStripMenuItem.Click += new System.EventHandler(this.illegalToolStripMenuItem_Click);
            //
            // pokeName
            //
            this.pokeName.AutoSize = true;
            this.pokeName.Location = new System.Drawing.Point(3, 0);
            this.pokeName.Name = "pokeName";
            this.pokeName.Size = new System.Drawing.Size(83, 13);
            this.pokeName.TabIndex = 2;
            this.pokeName.Text = "Pokemon Name";
            //
            // pokemonRenderUC1
            //
            this.pokemonRenderUC1.Caught = false;
            this.pokemonRenderUC1.ContextMenuStrip = this.contextMenuStrip1;
            this.pokemonRenderUC1.Legalility = PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal;
            this.pokemonRenderUC1.Location = new System.Drawing.Point(0, 16);
            this.pokemonRenderUC1.MaximumSize = new System.Drawing.Size(68, 56);
            this.pokemonRenderUC1.MinimumSize = new System.Drawing.Size(68, 56);
            this.pokemonRenderUC1.Name = "pokemonRenderUC1";
            this.pokemonRenderUC1.Pokemon = 0;
            this.pokemonRenderUC1.PokemonSubForm = "0";
            this.pokemonRenderUC1.ShowMessageIcon = false;
            this.pokemonRenderUC1.Size = new System.Drawing.Size(68, 56);
            this.pokemonRenderUC1.TabIndex = 0;
            this.pokemonRenderUC1.ToolTip = "";
            this.pokemonRenderUC1.LegaliltyCheck_OnClick += new System.EventHandler(this.pokemonRenderUC1_LegaliltyCheck_OnClick);
            this.pokemonRenderUC1.Caught_OnClick += new System.EventHandler(this.pokemonRenderUC1_Caught_OnClick);
            //
            // PokemonBaseUC
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pokeName);
            this.Controls.Add(this.caught_CB);
            this.Controls.Add(this.pokemonRenderUC1);
            this.MaximumSize = new System.Drawing.Size(160, 72);
            this.MinimumSize = new System.Drawing.Size(160, 72);
            this.Name = "PokemonBaseUC";
            this.Size = new System.Drawing.Size(160, 72);
            this.Load += new System.EventHandler(this.PokemonBaseUC_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private PokemonRenderUC pokemonRenderUC1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caughtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem illegalToolStripMenuItem;
        private System.Windows.Forms.CheckBox caught_CB;
        private System.Windows.Forms.Label pokeName;
    }
}
