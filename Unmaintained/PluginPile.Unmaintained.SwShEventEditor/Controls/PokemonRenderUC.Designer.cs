namespace PluginPile.Unmaintained.SwShEventEditor.Controls {
    partial class PokemonRenderUC {
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            //
            // PokemonRenderUC
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(68, 56);
            this.MinimumSize = new System.Drawing.Size(68, 56);
            this.Name = "PokemonRenderUC";
            this.Size = new System.Drawing.Size(68, 56);
            this.Load += new System.EventHandler(this.PokemonRenderUC_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PokemonRenderUC_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PokemonRenderUC_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PokemonRenderUC_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PokemonRenderUC_MouseDown);
            this.MouseEnter += new System.EventHandler(this.PokemonRenderUC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PokemonRenderUC_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PokemonRenderUC_MouseMove);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
    }
}
