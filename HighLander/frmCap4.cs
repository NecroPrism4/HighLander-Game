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
using System.Media;
using MessageBocNamespace;

namespace HighLander
{
    public partial class frmCap4 : Form
    {
        SoundPlayer soundDeath = new SoundPlayer(@"Proyecto videojuego\Musica\defeat.wav");
        SoundPlayer soundLevel = new SoundPlayer(@"Proyecto videojuego\Musica\Nivel 4.wav");
        SoundPlayer soundHit = new SoundPlayer(@"Proyecto videojuego\Musica\Golpe.wav");
        SoundPlayer soundCoin = new SoundPlayer(@"Proyecto videojuego\Musica\Moneda.wav");

        public frmCap4()
        {
            InitializeComponent();
        }

        private void frmCap4_Load(object sender, EventArgs e)
        {
	    soundLevel.PlayLooping();

            lblVidas.Text = userActivo.vidas.ToString();

            tmrMeteoro1.Start();
            tmrMeteoro2.Start();
            tmrMeteoro3.Start();
            tmrMeteoro4.Start();

            tmrParedA.Start();
            tmrParedB.Start();
            tmrParedC.Start();
            tmrParedD.Start();
            tmrParedE.Start();

            tmrMoneda1.Start();

            picMoneda2.Location = new Point(picMoneda2.Location.X, picMoneda2.Location.Y + 480);
            picMoneda3.Location = new Point(picMoneda3.Location.X, picMoneda3.Location.Y + 480);
            picPortalDerecha.Location = new Point(picPortalDerecha.Location.X + 200, picPortalDerecha.Location.Y);
        }
        public void frmCap4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && (picProta.Location.Y >= 0 && picProta.Location.Y < 430))
            {
                picProta.Location = new Point(picProta.Location.X, picProta.Location.Y + 5);
            }
            if (e.KeyCode == Keys.W && (picProta.Location.Y <= 430 && picProta.Location.Y > 0))
            {
                picProta.Location = new Point(picProta.Location.X, picProta.Location.Y - 5);
            }

            if (e.KeyCode == Keys.A && (picProta.Location.X <= 1230 && picProta.Location.X > 0))
            {
                picProta.Image = Image.FromFile(@"Recursos HighLander\ExtrasGG\ProtaIzquierda.gif");
                picProta.Location = new Point(picProta.Location.X - 5, picProta.Location.Y);
            }
            if (e.KeyCode == Keys.D && (picProta.Location.X >= 0 && picProta.Location.X < 1230))
            {
                picProta.Image = Image.FromFile(@"Recursos HighLander\ExtrasGG\ProtaDerecha.gif");
                picProta.Location = new Point(picProta.Location.X + 5, picProta.Location.Y);
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrMeteoro1_Tick(object sender, EventArgs e)
        {
            if (picMeteoro1.Bounds.IntersectsWith(picLaser22.Bounds))
            {
                picExplodeM1M2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro1.Location = new Point(-300, 105);
                tmrExplode1.Start();
            } else picMeteoro1.Location = new Point(picMeteoro1.Location.X + 5, picMeteoro1.Location.Y);

            if (picProta.Bounds.IntersectsWith(picMeteoro1.Bounds))
            {
                soundHit.Play(); 
                hitVidas();
                picProta.Location = new Point(90, 350);
            }

            if (picMeteoro1.Bounds.IntersectsWith(picMeteoro2.Bounds))
            {
                picExplodeM1M2.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro1.Location = new Point(-300, 105);
                picMeteoro2.Location = new Point(835, -250);
                tmrExplode1.Start();
            }
        }
        private void tmrExplode1_Tick(object sender, EventArgs e)
        {
            picExplodeM1M2.Image = null;
            tmrExplode1.Stop();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrMeteoro2_Tick(object sender, EventArgs e)
        {
            if (picMeteoro2.Bounds.IntersectsWith(picLaser9.Bounds))
            {
                picExplodeM2M3.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro2.Location = new Point(835, -970);
                tmrExplode2.Start();
            }
            else picMeteoro2.Location = new Point(picMeteoro2.Location.X, picMeteoro2.Location.Y + 5);

            if (picProta.Bounds.IntersectsWith(picMeteoro2.Bounds))
            {
                soundHit.Play();
                hitVidas();
                picProta.Location = new Point(90, 350);
            }

            if (picMeteoro2.Bounds.IntersectsWith(picMeteoro3.Bounds))
            {
                picExplodeM2M3.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro2.Location = new Point(835, -250);
                picMeteoro3.Location = new Point(1530, 263);
                tmrExplode2.Start();
            }
        }
        private void tmrExplode2_Tick(object sender, EventArgs e)
        {
            picExplodeM2M3.Image = null;
            tmrExplode2.Stop();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrMeteoro3_Tick(object sender, EventArgs e)
        {
            if (picMeteoro3.Bounds.IntersectsWith(picLaser3.Bounds))
            {
                picExplodeM3M4.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro3.Location = new Point(1530, 263);
                tmrExplode3.Start();
            }
            else picMeteoro3.Location = new Point(picMeteoro3.Location.X - 5, picMeteoro3.Location.Y);

            if (picProta.Bounds.IntersectsWith(picMeteoro3.Bounds))
            {
                soundHit.Play();
                hitVidas();
                picProta.Location = new Point(90, 350);
            }

            if (picMeteoro3.Bounds.IntersectsWith(picMeteoro4.Bounds))
            {
                picExplodeM3M4.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro3.Location = new Point(1530, 263);
                picMeteoro4.Location = new Point(355, 680);
                tmrExplode3.Start();
            }
        }
        private void tmrExplode3_Tick(object sender, EventArgs e)
        {
            picExplodeM3M4.Image = null;
            tmrExplode3.Stop();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrMeteoro4_Tick(object sender, EventArgs e)
        {
            if (picMeteoro4.Bounds.IntersectsWith(picLaser12.Bounds))
            {
                picExplodeM4M1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro4.Location = new Point(355, 1200);
                tmrExplode4.Start();
            }
            else picMeteoro4.Location = new Point(picMeteoro4.Location.X, picMeteoro4.Location.Y - 5);

            if (picProta.Bounds.IntersectsWith(picMeteoro4.Bounds))
            {
                soundHit.Play();
                hitVidas();
                picProta.Location = new Point(90, 350);
            }

            if (picMeteoro4.Bounds.IntersectsWith(picMeteoro1.Bounds))
            {
                picExplodeM4M1.Image = Image.FromFile(@"Recursos HighLander\Capitulo 4 Espacio\Explode-unscreen.gif");
                picMeteoro4.Location = new Point(355, 800);
                picMeteoro1.Location = new Point(-300, 105);
                tmrExplode4.Start();
            }
        }
        private void tmrExplode4_Tick(object sender, EventArgs e)
        {
            picExplodeM4M1.Image = null;
            tmrExplode4.Stop();
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
                tmrMoneda2.Start();
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
                tmrMoneda3.Start();
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
                tmrPortal.Start();
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
                frmCap5 FormCap5 = new frmCap5();
                FormCap5.TopLevel = false;
                FormCap5.Dock = DockStyle.Fill;
                frmPrincipal.pnlContainer.Controls.Add(FormCap5);
                FormCap5.Show();
                FormCap5.Focus();
                frmPrincipal.pnlContainer.BringToFront();
            }
        }       
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void tmrParedA_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picLaser1.Bounds)) { soundHit.Play();  hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser2.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser3.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
        }

        private void tmrParedB_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picLaser4.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser5.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser6.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser7.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser8.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser9.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser10.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
        }

        private void tmrParedC_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picLaser18.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser19.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser20.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser21.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
        }

        private void tmrParedD_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picLaser11.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser12.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser13.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser14.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser15.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser16.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
        }

        private void tmrParedE_Tick(object sender, EventArgs e)
        {
            if (picProta.Bounds.IntersectsWith(picLaser22.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser23.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
            if (picProta.Bounds.IntersectsWith(picLaser24.Bounds)) { soundHit.Play(); hitVidas(); picProta.Location = new Point(90, 350); }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
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
        }

        void resetActiveUserStats()
        {
            userActivo.user = null;
            userActivo.score = 0;
            userActivo.vidas = 0;
        }
    }
}
