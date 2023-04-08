using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighLander.ModeloDatos;
using System.Media;

namespace HighLander
{
    public partial class frmCap3 : Form
    {
        SoundPlayer soundLevel = new SoundPlayer(@"Proyecto videojuego\Musica\Nivel 3 Wii u Wav.wav");

        public frmCap3()
        {
            InitializeComponent();
        }

        private void frmCap3_Load(object sender, EventArgs e)
        {
            soundLevel.PlayLooping();
            lblVidas.Text = userActivo.vidas.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = Alicia.Location.X;
            int y = Alicia.Location.Y;

            if (y <= 400)
            {
                if (e.KeyValue == Convert.ToChar(Keys.S)) Alicia.Location = new Point(Alicia.Location.X, Alicia.Location.Y + 5);
            }
            if (y >= 20)
            {
                if (e.KeyValue == Convert.ToChar(Keys.W)) Alicia.Location = new Point(Alicia.Location.X, Alicia.Location.Y - 5);
            }
            if (x >= 0)
            {
                if (e.KeyValue == Convert.ToChar(Keys.A))
                {
                    Alicia.Image = Image.FromFile(@"Proyecto videojuego\ExtrasGG\Mariposa de agua izq.gif"); Alicia.Location = new Point(Alicia.Location.X - 5, Alicia.Location.Y);
                    
                }
            }
            if (y <= 1200)
            {
                if (e.KeyValue == Convert.ToChar(Keys.D)) { Alicia.Image = Image.FromFile(@"Proyecto videojuego\ExtrasGG\Mariposa de agua.gif"); Alicia.Location = new Point(Alicia.Location.X + 5, Alicia.Location.Y); }
            }
        }

        private void timerPortal1_Tick(object sender, EventArgs e)
        {
            if (Alicia.Bounds.IntersectsWith(pctPortal1.Bounds))
            {
                soundLevel.Stop();
                timerPortal1.Stop();
;
                this.Close();
                frmPrincipal.pnlContainer.Show();
                if (frmPrincipal.pnlContainer.Controls.Count > 0)
                {
                    frmPrincipal.pnlContainer.Controls.RemoveAt(0);
                }
                frmCap4 FormCap4 = new frmCap4();
                FormCap4.TopLevel = false;
                FormCap4.Dock = DockStyle.Fill;
                frmPrincipal.pnlContainer.Controls.Add(FormCap4);
                FormCap4.Show();
                FormCap4.Focus();
                frmPrincipal.pnlContainer.BringToFront();
            }
        }     
    }
}
