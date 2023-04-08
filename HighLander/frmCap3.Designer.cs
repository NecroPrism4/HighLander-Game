namespace HighLander
{
    partial class frmCap3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCap3));
            this.Alicia = new System.Windows.Forms.PictureBox();
            this.pctPortal1 = new System.Windows.Forms.PictureBox();
            this.timerPortal1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Alicia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPortal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Alicia
            // 
            this.Alicia.BackColor = System.Drawing.Color.Transparent;
            this.Alicia.Image = ((System.Drawing.Image)(resources.GetObject("Alicia.Image")));
            this.Alicia.Location = new System.Drawing.Point(102, 160);
            this.Alicia.Name = "Alicia";
            this.Alicia.Size = new System.Drawing.Size(105, 141);
            this.Alicia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Alicia.TabIndex = 1;
            this.Alicia.TabStop = false;
            // 
            // pctPortal1
            // 
            this.pctPortal1.BackColor = System.Drawing.Color.Transparent;
            this.pctPortal1.Image = ((System.Drawing.Image)(resources.GetObject("pctPortal1.Image")));
            this.pctPortal1.Location = new System.Drawing.Point(1163, 126);
            this.pctPortal1.Name = "pctPortal1";
            this.pctPortal1.Size = new System.Drawing.Size(133, 225);
            this.pctPortal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPortal1.TabIndex = 4;
            this.pctPortal1.TabStop = false;
            // 
            // timerPortal1
            // 
            this.timerPortal1.Enabled = true;
            this.timerPortal1.Interval = 50;
            this.timerPortal1.Tick += new System.EventHandler(this.timerPortal1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-37, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(362, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 134);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rest zone";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1205, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Font = new System.Drawing.Font("ARCO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblX.Location = new System.Drawing.Point(1180, 10);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(34, 29);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "x";
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("ARCO", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVidas.Location = new System.Drawing.Point(1150, 5);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(42, 39);
            this.lblVidas.TabIndex = 20;
            this.lblVidas.Text = "0";
            // 
            // frmCap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 480);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctPortal1);
            this.Controls.Add(this.Alicia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCap3";
            this.Text = "frmCap3";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.frmCap3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Alicia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPortal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Alicia;
        private System.Windows.Forms.PictureBox pctPortal1;
        private System.Windows.Forms.Timer timerPortal1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblX;
        public System.Windows.Forms.Label lblVidas;
    }
}

