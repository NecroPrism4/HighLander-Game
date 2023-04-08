namespace HighLander
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlBordeSup = new System.Windows.Forms.Panel();
            this.pnlBordeInf = new System.Windows.Forms.Panel();
            this.pnlBordeDer = new System.Windows.Forms.Panel();
            this.pnlBordeIzq = new System.Windows.Forms.Panel();
            this.tmrElecUser = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.pnlSelecPlayer = new System.Windows.Forms.Panel();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnPlayContinuar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picPortada = new System.Windows.Forms.PictureBox();
            pnlContainer = new System.Windows.Forms.Panel();
            this.picProta = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.dtgTableScore = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            this.pnlSelecPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            this.pnlScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMenu
            // 
            this.tmrMenu.Interval = 10;
            this.tmrMenu.Tick += new System.EventHandler(this.tmrMenu_Tick);
            // 
            // pnlBordeSup
            // 
            this.pnlBordeSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.pnlBordeSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordeSup.Location = new System.Drawing.Point(0, 0);
            this.pnlBordeSup.Name = "pnlBordeSup";
            this.pnlBordeSup.Size = new System.Drawing.Size(1300, 20);
            this.pnlBordeSup.TabIndex = 5;
            // 
            // pnlBordeInf
            // 
            this.pnlBordeInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.pnlBordeInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBordeInf.Location = new System.Drawing.Point(0, 500);
            this.pnlBordeInf.Name = "pnlBordeInf";
            this.pnlBordeInf.Size = new System.Drawing.Size(1300, 10);
            this.pnlBordeInf.TabIndex = 6;
            // 
            // pnlBordeDer
            // 
            this.pnlBordeDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.pnlBordeDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBordeDer.Location = new System.Drawing.Point(1290, 20);
            this.pnlBordeDer.Name = "pnlBordeDer";
            this.pnlBordeDer.Size = new System.Drawing.Size(10, 480);
            this.pnlBordeDer.TabIndex = 7;
            // 
            // pnlBordeIzq
            // 
            this.pnlBordeIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.pnlBordeIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordeIzq.Location = new System.Drawing.Point(0, 20);
            this.pnlBordeIzq.Name = "pnlBordeIzq";
            this.pnlBordeIzq.Size = new System.Drawing.Size(10, 480);
            this.pnlBordeIzq.TabIndex = 8;
            // 
            // tmrElecUser
            // 
            this.tmrElecUser.Interval = 10;
            this.tmrElecUser.Tick += new System.EventHandler(this.tmrElecUser_Tick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.pnlMenu.Controls.Add(this.btnReanudar);
            this.pnlMenu.Controls.Add(this.btnIntro);
            this.pnlMenu.Controls.Add(this.pnlSelecPlayer);
            this.pnlMenu.Controls.Add(this.btnJugar);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(10, 20);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 480);
            this.pnlMenu.TabIndex = 11;
            // 
            // btnReanudar
            // 
            this.btnReanudar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnReanudar.Enabled = false;
            this.btnReanudar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnReanudar.FlatAppearance.BorderSize = 0;
            this.btnReanudar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnReanudar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnReanudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReanudar.Font = new System.Drawing.Font("ARCO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReanudar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReanudar.Location = new System.Drawing.Point(0, 292);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(300, 45);
            this.btnReanudar.TabIndex = 4;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReanudar.UseVisualStyleBackColor = false;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // btnIntro
            // 
            this.btnIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnIntro.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnIntro.FlatAppearance.BorderSize = 0;
            this.btnIntro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnIntro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntro.Font = new System.Drawing.Font("ARCO", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIntro.Location = new System.Drawing.Point(0, 30);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(300, 45);
            this.btnIntro.TabIndex = 3;
            this.btnIntro.Text = "Intro";
            this.btnIntro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIntro.UseVisualStyleBackColor = false;
            // 
            // pnlSelecPlayer
            // 
            this.pnlSelecPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlSelecPlayer.Controls.Add(this.cmbUsuarios);
            this.pnlSelecPlayer.Controls.Add(this.btnPlayContinuar);
            this.pnlSelecPlayer.Location = new System.Drawing.Point(0, 165);
            this.pnlSelecPlayer.Name = "pnlSelecPlayer";
            this.pnlSelecPlayer.Size = new System.Drawing.Size(300, 0);
            this.pnlSelecPlayer.TabIndex = 2;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUsuarios.Font = new System.Drawing.Font("ARCO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(50, 16);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(200, 24);
            this.cmbUsuarios.TabIndex = 12;
            // 
            // btnPlayContinuar
            // 
            this.btnPlayContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.btnPlayContinuar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.btnPlayContinuar.FlatAppearance.BorderSize = 0;
            this.btnPlayContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnPlayContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnPlayContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayContinuar.Font = new System.Drawing.Font("ARCO", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayContinuar.ForeColor = System.Drawing.Color.White;
            this.btnPlayContinuar.Location = new System.Drawing.Point(50, 60);
            this.btnPlayContinuar.Name = "btnPlayContinuar";
            this.btnPlayContinuar.Size = new System.Drawing.Size(200, 26);
            this.btnPlayContinuar.TabIndex = 5;
            this.btnPlayContinuar.Text = "Continuar";
            this.btnPlayContinuar.UseVisualStyleBackColor = false;
            this.btnPlayContinuar.Click += new System.EventHandler(this.btnPlayContinuar_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnJugar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("ARCO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJugar.Location = new System.Drawing.Point(0, 120);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(300, 45);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("ARCO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Location = new System.Drawing.Point(50, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 45);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picPortada
            // 
            this.picPortada.Image = ((System.Drawing.Image)(resources.GetObject("picPortada.Image")));
            this.picPortada.Location = new System.Drawing.Point(310, 20);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(680, 480);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPortada.TabIndex = 18;
            this.picPortada.TabStop = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = System.Drawing.Color.Transparent;
            pnlContainer.Controls.Add(this.picProta);
            pnlContainer.Controls.Add(this.picEnemy);
            pnlContainer.Location = new System.Drawing.Point(10, 20);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new System.Drawing.Size(1280, 480);
            pnlContainer.TabIndex = 3;
            // 
            // picProta
            // 
            this.picProta.BackColor = System.Drawing.Color.Transparent;
            this.picProta.Image = ((System.Drawing.Image)(resources.GetObject("picProta.Image")));
            this.picProta.Location = new System.Drawing.Point(0, 181);
            this.picProta.Name = "picProta";
            this.picProta.Size = new System.Drawing.Size(294, 299);
            this.picProta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProta.TabIndex = 29;
            this.picProta.TabStop = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy.Image")));
            this.picEnemy.Location = new System.Drawing.Point(986, 0);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(294, 480);
            this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy.TabIndex = 26;
            this.picEnemy.TabStop = false;
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnScoreBoard.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnScoreBoard.FlatAppearance.BorderSize = 0;
            this.btnScoreBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnScoreBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreBoard.Font = new System.Drawing.Font("ARCO", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreBoard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnScoreBoard.Location = new System.Drawing.Point(0, 45);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(300, 45);
            this.btnScoreBoard.TabIndex = 9;
            this.btnScoreBoard.Text = "ScoreBoard";
            this.btnScoreBoard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScoreBoard.UseVisualStyleBackColor = false;
            this.btnScoreBoard.Click += new System.EventHandler(this.btnScoreBoard_Click);
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.pnlScore.Controls.Add(this.dtgTableScore);
            this.pnlScore.Controls.Add(this.btnScoreBoard);
            this.pnlScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlScore.Location = new System.Drawing.Point(990, 20);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(300, 480);
            this.pnlScore.TabIndex = 24;
            // 
            // dtgTableScore
            // 
            this.dtgTableScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgTableScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTableScore.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgTableScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTableScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgTableScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableScore.GridColor = System.Drawing.SystemColors.Control;
            this.dtgTableScore.Location = new System.Drawing.Point(22, 105);
            this.dtgTableScore.Name = "dtgTableScore";
            this.dtgTableScore.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgTableScore.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTableScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTableScore.Size = new System.Drawing.Size(259, 355);
            this.dtgTableScore.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 510);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(pnlContainer);
            this.Controls.Add(this.pnlBordeIzq);
            this.Controls.Add(this.pnlBordeDer);
            this.Controls.Add(this.pnlBordeSup);
            this.Controls.Add(this.pnlBordeInf);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.Text = "HighUP";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSelecPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            this.pnlScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer tmrMenu;
        private System.Windows.Forms.Panel pnlBordeSup;
        private System.Windows.Forms.Panel pnlBordeInf;
        private System.Windows.Forms.Panel pnlBordeDer;
        private System.Windows.Forms.Panel pnlBordeIzq;
        public System.Windows.Forms.Timer tmrElecUser;
        public System.Windows.Forms.Panel pnlMenu;
        public System.Windows.Forms.Button btnReanudar;
        public System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Panel pnlSelecPlayer;
        public System.Windows.Forms.ComboBox cmbUsuarios;
        public System.Windows.Forms.Button btnPlayContinuar;
        public System.Windows.Forms.Button btnJugar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.PictureBox picPortada;
        public System.Windows.Forms.Button btnScoreBoard;
        public System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.PictureBox picProta;
        private System.Windows.Forms.PictureBox picEnemy;
        public System.Windows.Forms.DataGridView dtgTableScore;
        public static System.Windows.Forms.Panel pnlContainer;
    }
}

