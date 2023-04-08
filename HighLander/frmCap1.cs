using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighLander.ModeloDatos;
using myLibrary;
using MessageBocNamespace;
using System.Media;

namespace HighLander
{
    public partial class frmCap1 : Form
    {
        SoundPlayer soundDeath = new SoundPlayer(@"Proyecto videojuego\Musica\defeat.wav");
        SoundPlayer soundLevel = new SoundPlayer(@"Proyecto videojuego\Musica\Niveles 1 y 2.wav");
        SoundPlayer soundHit = new SoundPlayer(@"Proyecto videojuego\Musica\Golpe.wav");
        SoundPlayer soundCoin = new SoundPlayer(@"Proyecto videojuego\Musica\Moneda.wav");

        public frmCap1()
        {
            InitializeComponent();
            
        }

        private void frmCap1_Load(object sender, EventArgs e)
        {
            timerRestarPuntos.Start();
            lblVidas.Text = userActivo.vidas.ToString();
            soundLevel.PlayLooping();
        }

        int vuelta1 = +5;
        int vuelta2 = +5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pctPezL1.Location.X;
            int y = pctPezL1.Location.Y;
            
            x = x + vuelta1;

            if (x >= 1030)
            {
                pctPezL1.Image = Image.FromFile(@"Proyecto videojuego\Capitulo 1 Abismo\Lamparita izq.GIF");
                vuelta1 = -5;
            }
            if (x <= 150)
            {
                pctPezL1.Image = Image.FromFile(@"Proyecto videojuego\Capitulo 1 Abismo\Lamparita.GIF");
                vuelta1 = +5;
            }
            Point punto = new Point(x, y);
            pctPezL1.Location = punto;

            if (Alicia.Bounds.IntersectsWith(pctPezL1.Bounds))
            {
               soundHit.Play();
               soundLevel.PlayLooping();
               Alicia.Location = new Point(35, 175);
               hitVidas();
            }
            int x2 = pctPezL2.Location.X;
            int y2 = pctPezL2.Location.Y;

            x2 = x2 + vuelta2;

            if (x2 >= 1030)
            {
                pctPezL2.Image = Image.FromFile(@"Proyecto videojuego\Capitulo 1 Abismo\Lamparita izq.GIF");
                vuelta2 = -5;

            }
            if (x2 <= 150)
            {
                pctPezL2.Image = Image.FromFile(@"Proyecto videojuego\Capitulo 1 Abismo\Lamparita.GIF");
                vuelta2 = +5;
            }

            Point punto2 = new Point(x2, y2);
            pctPezL2.Location = punto2;

            if (Alicia.Bounds.IntersectsWith(pctPezL2.Bounds))
            {
                soundHit.Play();
                soundLevel.PlayLooping();
                Alicia.Location = new Point(35, 175);
                hitVidas();
            }
        }      

        int vuelta3 = +5;
        int vuelta4 = +5;
        int vuelta5 = +5;
        private void timer3_Tick(object sender, EventArgs e)
        {
            int x = pctMedusa1.Location.X;
            int y = pctMedusa1.Location.Y;

            y = y + vuelta3;

            if (y >= 270)
            {
                vuelta3 = -5;
            }
            if (y <= 110)
            {
                vuelta3 = +5;
            }

            Point punto = new Point(x, y);
            pctMedusa1.Location = punto;

            if (Alicia.Bounds.IntersectsWith(pctMedusa1.Bounds))
            {
                soundHit.Play();
                soundLevel.PlayLooping();
                Alicia.Location = new Point(35, 175);
                hitVidas();
            }
            int x2 = pctMedusa2.Location.X;
            int y2 = pctMedusa2.Location.Y;

            y2 = y2 + vuelta4;

            if (y2 >= 270)
            {
                vuelta4 = -5;
            }
            if (y2 <= 110)
            {
                vuelta4 = +5;
            }

            Point punto2 = new Point(x2, y2);
            pctMedusa2.Location = punto2;

            if (Alicia.Bounds.IntersectsWith(pctMedusa2.Bounds))
            {
                soundHit.Play();
                soundLevel.PlayLooping();
                Alicia.Location = new Point(35, 175);
                hitVidas();
            }
            int x3 = pctMedusa3.Location.X;
            int y3 = pctMedusa3.Location.Y;

            y3 = y3 + vuelta5;

            if (y3 >= 270)
            {
                vuelta5 = -5;
            }
            if (y3 <= 110)
            {
                vuelta5 = +5;
            }

            Point punto3 = new Point(x3, y3);
            pctMedusa3.Location = punto3;

            if (Alicia.Bounds.IntersectsWith(pctMedusa3.Bounds))
            {
                soundHit.Play();
                soundLevel.PlayLooping();
                Alicia.Location = new Point(35, 175);
                hitVidas();
            }
        }

        private void frmCap1_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyValue == Convert.ToChar(Keys.A)) { Alicia.Image = Image.FromFile(@"Proyecto videojuego\ExtrasGG\Mariposa de agua izq.gif"); Alicia.Location = new Point(Alicia.Location.X - 5, Alicia.Location.Y);
                Alicia.Size = new Size(65, 90);
                }
            }
            if (y <= 1200)
            {
                if (e.KeyValue == Convert.ToChar(Keys.D)) { Alicia.Image = Image.FromFile(@"Proyecto videojuego\ExtrasGG\Mariposa de agua.gif"); Alicia.Location = new Point(Alicia.Location.X + 5, Alicia.Location.Y); }
            }
        }
        int traer1 = -70;
        private void Moneda1_Tick(object sender, EventArgs e)
        {
            int x = pctMoneda1.Location.X;
            int y = pctMoneda1.Location.Y;

            if (pctMoneda1.Bounds.IntersectsWith(Alicia.Bounds))
            {
                soundCoin.Play();
                y =  traer1;
                traer2 = 200;
                agregarPuntos(3000);
            }

            //pctMoneda1.Location = new Point(pctMoneda1.Location.X, pctMoneda1.Location.Y-100);

            Point punto = new Point(x, y);
                pctMoneda1.Location = punto;
        }
        int traer2 = -70;
        private void timerMoneda2_Tick(object sender, EventArgs e)
        {
            int x = pctMoneda2.Location.X;
            int y = pctMoneda2.Location.Y;

            y = traer2;
            if (pctMoneda2.Bounds.IntersectsWith(Alicia.Bounds))
            {
                soundCoin.Play();
                traer2 = -70;
                traer3 = 70;
                agregarPuntos(3000);
            }
            //pctMoneda1.Location = new Point(pctMoneda1.Location.X, pctMoneda1.Location.Y-100);

            Point punto = new Point(x, y);
            pctMoneda2.Location = punto;

        }
        int traer3 = -70;
        private void timerMoneda3_Tick(object sender, EventArgs e)
        {
            int x = pctMoneda3.Location.X;
            int y = pctMoneda3.Location.Y;

            y = traer3;
            if (pctMoneda3.Bounds.IntersectsWith(Alicia.Bounds))
            {
                soundCoin.Play();
                traer3 = -70;
                traer4 = 140;
                agregarPuntos(3000);
            }
            //pctMoneda1.Location = new Point(pctMoneda1.Location.X, pctMoneda1.Location.Y-100);

            Point punto = new Point(x, y);
            pctMoneda3.Location = punto;
        }

        int traer4 = -250;
        private void timerPortal1_Tick(object sender, EventArgs e)
        {
            int x = pctPortal1.Location.X;
            int y = pctPortal1.Location.Y;

            y = traer4;

            //pctMoneda1.Location = new Point(pctMoneda1.Location.X, pctMoneda1.Location.Y-100);

            Point punto = new Point(x, y);
            pctPortal1.Location = punto;

            if (Alicia.Bounds.IntersectsWith(pctPortal1.Bounds))
            {
                soundLevel.Stop();
                agregarPuntos(5000 - ConteoSec);
                //frmPrincipal obj = new frmPrincipal();

                timerPortal1.Stop();
                this.Close();
                frmPrincipal.pnlContainer.Show();
                if (frmPrincipal.pnlContainer.Controls.Count > 0)
                {
                    frmPrincipal.pnlContainer.Controls.RemoveAt(0);
                }
                frmCap2 FormCap2 = new frmCap2();
                FormCap2.TopLevel = false;
                FormCap2.Dock = DockStyle.Fill;
                frmPrincipal.pnlContainer.Controls.Add(FormCap2);
                FormCap2.Show();
                FormCap2.Focus();
                frmPrincipal.pnlContainer.BringToFront();
            }
        }
        int conteoSec;
        public int ConteoSec { get => conteoSec; set => conteoSec = value; }
        private void timerRestarPuntos_Tick(object sender, EventArgs e)
        {
            ConteoSec += 1;           
        }

        Procedimientos objProce = new Procedimientos();

        void agregarPuntos(int puntos) 
        {
            userActivo.score += puntos;
        }
        void hitVidas() 
        {
            userActivo.vidas -= 1;
            lblVidas.Text = userActivo.vidas.ToString();
        }

        private void tmrCompVidas_Tick(object sender, EventArgs e)
        {
            if (userActivo.vidas <= 0)
            {
                tmrCompVidas.Enabled = false;

                objProce.SubePuntaje(userActivo.user, userActivo.score);
                resetActiveUserStats();
                soundLevel.Stop();
                soundDeath.Play();
                claseMessageBox.Mostrar("Has perdido!!!");
                if (frmPrincipal.pnlContainer.Controls.Count > 0)
                {
                    frmPrincipal.pnlContainer.Controls.RemoveAt(0);
                }
                frmPrincipal.pnlContainer.SendToBack();
            }

            void resetActiveUserStats() 
            {
                userActivo.user = null;
                userActivo.score = 0;
                userActivo.vidas = 0;
            }
        }
    }
}
