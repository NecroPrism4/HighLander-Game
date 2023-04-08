using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using myLibrary;
using HighLander.ModeloDatos;
using MessageBocNamespace;

namespace HighLander
{
    public partial class frmCap2 : Form
    {
        SoundPlayer soundDeath = new SoundPlayer(@"Proyecto videojuego\Musica\defeat.wav");
        SoundPlayer soundLevel = new SoundPlayer(@"Proyecto videojuego\Musica\Niveles 1 y 2.wav");
        SoundPlayer soundHit = new SoundPlayer(@"Proyecto videojuego\Musica\Golpe.wav");
        SoundPlayer soundCoin = new SoundPlayer(@"Proyecto videojuego\Musica\Moneda.wav");

        public frmCap2()
        {
            InitializeComponent();
        }

        private void frmCap2_Load(object sender, EventArgs e)
        {
            soundLevel.PlayLooping();

            tmrTiburonA1.Start();
            tmrTiburonA2.Start();
            tmrTiburonB1.Start();
            tmrTiburonB2.Start();
            tmrMataraya1.Start();
            tmrMantaraya2.Start();
            timerRestarPuntos.Start();
            tmrPortal.Start();

            tmrMoneda1.Start();
            tmrMoneda2.Start();
            tmrMoneda3.Start();

            picPortalDerecha.Location = new Point(picPortalDerecha.Location.X + 200, picPortalDerecha.Location.Y);
            picMoneda2.Location = new Point(picMoneda2.Location.X,picMoneda2.Location.Y + 480);
            picMoneda3.Location = new Point(picMoneda3.Location.X, picMoneda3.Location.Y + 480);

            lblVidas.Text = userActivo.vidas.ToString();
        }

        private void frmCap2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && (picProta.Location.Y >= 0 && picProta.Location.Y < 380))
            {
                picProta.Location = new Point(picProta.Location.X, picProta.Location.Y + 5);
            }
            if (e.KeyCode == Keys.W && (picProta.Location.Y <= 380 && picProta.Location.Y > 0))
            {
                picProta.Location = new Point(picProta.Location.X, picProta.Location.Y - 5);
            }

            if (e.KeyCode == Keys.A && (picProta.Location.X <= 1210 && picProta.Location.X > 0))
            {
                picProta.Image = Image.FromFile(@"Recursos HighLander\ExtrasGG\ProtaIzquierda.gif");
                picProta.Location = new Point(picProta.Location.X - 5, picProta.Location.Y);
            }
            if (e.KeyCode == Keys.D && (picProta.Location.X >= 0 && picProta.Location.X < 1210))
            {
                picProta.Image = Image.FromFile(@"Recursos HighLander\ExtrasGG\ProtaDerecha.gif");
                picProta.Location = new Point(picProta.Location.X + 5, picProta.Location.Y);
            }
        }

        int A1 = +5;
        int A2, B1, B2, Mant1, Mant2;
        private void tmrTiburonesA_Tick(object sender, EventArgs e)
        {
            int sumaTib1 = picTiburonA1.Location.X;
                sumaTib1 += A1;
            if (picTiburonA1.Location.X <= 670)
            {
                picTiburonA1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Right.gif");
                A1 = +2;
            }
            if (picTiburonA1.Location.X >= 980)
            {
                picTiburonA1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Left.gif");
                A1 = -2;
            }
            picTiburonA1.Location = new Point(picTiburonA1.Location.X + A1, picTiburonA1.Location.Y);

            if (picProta.Bounds.IntersectsWith(picTiburonA1.Bounds))
            {
                soundHit.Play();
                picProta.Location = new Point(sumaTib1, 175);
                hitVidas();
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrTiburonA2_Tick(object sender, EventArgs e)
        {
            if (picTiburonA2.Location.X <= 200)
            {
                picTiburonA2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Right.gif");
                A2 = +2;
            }
            if (picTiburonA2.Location.X >= 510)
            {
                picTiburonA2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Left.gif");
                A2 = -2;
            }
            picTiburonA2.Location = new Point(picTiburonA2.Location.X + A2, picTiburonA2.Location.Y);
            
            if (picProta.Bounds.IntersectsWith(picTiburonA2.Bounds))
            {
                soundHit.Play();
                picProta.Location = new Point(35, 175);
                hitVidas();
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrTiburonB1_Tick(object sender, EventArgs e)
        {
            if (picTiburonB1.Location.X <= 200)
            {
                picTiburonB1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Right.gif");
                B1 = +5;
            }
            if (picTiburonB1.Location.X >= 510)
            {
                picTiburonB1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Left.gif");
                B1 = -5;
            }
            picTiburonB1.Location = new Point(picTiburonB1.Location.X + B1, picTiburonB1.Location.Y);

            if (picProta.Bounds.IntersectsWith(picTiburonB1.Bounds))
            {
                soundHit.Play();
                picProta.Location = new Point(35, 175);
                hitVidas();
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrTiburonB2_Tick(object sender, EventArgs e)
        {
            if (picTiburonB2.Location.X <= 670)
            {
                picTiburonB2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Right.gif");
                B2 = +5;
            }
            if (picTiburonB2.Location.X >= 980)
            {
                picTiburonB2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Tiburon_Left.gif");
                B2 = -5;
            }
            picTiburonB2.Location = new Point(picTiburonB2.Location.X + B2, picTiburonB2.Location.Y);
            
            if (picProta.Bounds.IntersectsWith(picTiburonB2.Bounds))
            {
                soundHit.Play();
                picProta.Location = new Point(35, 175);
                hitVidas();
            }
        }      
        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrMataraya1_Tick(object sender, EventArgs e)
        {
            if (picMantaraya1.Location.Y >= 340)
            {
                picMantaraya1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Mantarraya_Right.gif");
                Mant1 = -2;
            }
            if (picMantaraya1.Location.Y <= 20)
            {
                picMantaraya1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Mantarraya_Left.gif");
                Mant1 = +2;
            }
            picMantaraya1.Location = new Point(picMantaraya1.Location.X, picMantaraya1.Location.Y + Mant1);

            if (picProta.Bounds.IntersectsWith(picMantaraya1.Bounds))
            {
                soundHit.Play();
                picProta.Location = new Point(35, 175);
                hitVidas();
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrMantaraya2_Tick(object sender, EventArgs e)
        {
            if (picMantaraya2.Location.Y >= 340)
            {
                picMantaraya2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Mantarraya_Left.gif");
                Mant2 = -2;
            }
            if (picMantaraya2.Location.Y <= 20)
            {
                picMantaraya2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 2 El mar muerto\Mantarraya_Right.gif");
                Mant2 = +2;
            }
            picMantaraya2.Location = new Point(picMantaraya2.Location.X, picMantaraya2.Location.Y + Mant2);

            if (picProta.Bounds.IntersectsWith(picMantaraya2.Bounds))
            {
                soundHit.Play();
                picProta.Location = new Point(35, 175);
                hitVidas();
            }
        }        
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrMoneda1_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picMoneda1.Bounds))
            {
                soundCoin.Play();
                picMoneda1.Location = new Point(picMoneda1.Location.X, picMoneda1.Location.Y + 480);
                picMoneda2.Location = new Point(picMoneda2.Location.X, picMoneda2.Location.Y - 480);
                tmrMoneda1.Stop();
                agregarPuntos(3000);
            }
        }
        private void tmrMoneda2_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picMoneda2.Bounds))
            {
                soundCoin.Play();
                picMoneda2.Location = new Point(picMoneda2.Location.X, picMoneda2.Location.Y + 480);
                picMoneda3.Location = new Point(picMoneda3.Location.X, picMoneda3.Location.Y - 480);
                tmrMoneda2.Stop();
                agregarPuntos(3000);
            }
        }
        private void tmrMoneda3_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picMoneda3.Bounds))
            {
                soundCoin.Play();
                picMoneda3.Location = new Point(picMoneda3.Location.X, picMoneda3.Location.Y + 480);
                picPortalDerecha.Location = new Point(picPortalDerecha.Location.X - 200, picPortalDerecha.Location.Y);
                tmrMoneda3.Stop();
                agregarPuntos(3000);
            }
        }
        private void tmrPortal_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picPortalDerecha.Bounds))
            {
                soundLevel.Stop();
                agregarPuntos(5000 - ConteoSec);

                tmrPortal.Stop();
                this.Close();
                frmPrincipal.pnlContainer.Show();
                if (frmPrincipal.pnlContainer.Controls.Count > 0)
                {
                    frmPrincipal.pnlContainer.Controls.RemoveAt(0);
                }
                frmCap3 FormCap3 = new frmCap3();
                FormCap3.TopLevel = false;
                FormCap3.Dock = DockStyle.Fill;
                frmPrincipal.pnlContainer.Controls.Add(FormCap3);
                FormCap3.Show();
                FormCap3.Focus();
                frmPrincipal.pnlContainer.BringToFront();
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        int conteoSec;
        public int ConteoSec { get => conteoSec; set => conteoSec = value; }
        private void timerRestarPuntos_Tick(object sender, EventArgs e)
        {
            ConteoSec += 1;
        }
       
        void agregarPuntos(int puntos)
        {
            userActivo.score += puntos;
        }
        void hitVidas()
        {
            userActivo.vidas -= 1;
            lblVidas.Text = userActivo.vidas.ToString();
        }

        Procedimientos objProce = new Procedimientos();

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
        }

        void resetActiveUserStats()
        {
            userActivo.user = null;
            userActivo.score = 0;
            userActivo.vidas = 0;
        }
    }
}
