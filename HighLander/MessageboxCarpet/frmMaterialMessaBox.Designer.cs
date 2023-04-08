
namespace MessageBocNamespace
{
    partial class frmMessaBox
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
            this.lblMessabox = new MaterialSkin.Controls.MaterialLabel();
            this.btnOk = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblMessabox
            // 
            this.lblMessabox.Depth = 0;
            this.lblMessabox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessabox.Location = new System.Drawing.Point(6, 73);
            this.lblMessabox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessabox.Name = "lblMessabox";
            this.lblMessabox.Size = new System.Drawing.Size(426, 96);
            this.lblMessabox.TabIndex = 0;
            this.lblMessabox.Text = "lblMessabox";
            // 
            // btnOk
            // 
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk.Depth = 0;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.HighEmphasis = true;
            this.btnOk.Icon = null;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOk.Location = new System.Drawing.Point(3, 185);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOk.Size = new System.Drawing.Size(432, 36);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOk.UseAccentColor = false;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmMessaBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(438, 224);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMessabox);
            this.Name = "frmMessaBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advertencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMessabox;
        private MaterialSkin.Controls.MaterialButton btnOk;
    }
}