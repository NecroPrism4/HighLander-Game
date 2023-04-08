namespace HighLander
{
    partial class frmCopyPaste
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgScoreBoard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgScoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgScoreBoard
            // 
            this.dtgScoreBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgScoreBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgScoreBoard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.dtgScoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgScoreBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgScoreBoard.GridColor = System.Drawing.SystemColors.Control;
            this.dtgScoreBoard.Location = new System.Drawing.Point(899, 97);
            this.dtgScoreBoard.Name = "dtgScoreBoard";
            this.dtgScoreBoard.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgScoreBoard.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgScoreBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgScoreBoard.Size = new System.Drawing.Size(250, 400);
            this.dtgScoreBoard.TabIndex = 7;
            // 
            // frmCopyPaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 694);
            this.Controls.Add(this.dtgScoreBoard);
            this.Name = "frmCopyPaste";
            this.Text = "frmCopyPaste";
            ((System.ComponentModel.ISupportInitialize)(this.dtgScoreBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgScoreBoard;
    }
}