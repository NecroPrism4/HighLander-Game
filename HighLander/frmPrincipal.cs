using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBocNamespace;
using HighLander.ModeloDatos;
using myLibrary;
using System.Media;

namespace HighLander
{
    public partial class frmPrincipal : Form
    {
        SoundPlayer soundStart = new SoundPlayer(@"Proyecto videojuego\Musica\StarUp part1.wav");
        SoundPlayer soundStart2 = new SoundPlayer(@"Proyecto videojuego\Musica\StarUp part2.wav");
        SoundPlayer SoundButton = new SoundPlayer(@"Proyecto videojuego\Musica\button.wav");

        public frmPrincipal()
        {
            InitializeComponent();
        }

        DataTable tabla = new DataTable();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {           
            soundStart.Play();
            tabla.Columns.Add("nombre");
            tabla.Columns.Add("puntaje");            
            soundStart2.PlayLooping();           
        }

        bool palancaFocusNivel = false;
        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                btnReanudar.Enabled = true;
                SoundButton.Play();
                tmrMenu.Start(); 
                if (palancaFocusNivel == true) 
                { pnlContainer.Focus(); 
                  pnlContainer.BringToFront(); 
                }       
            }
        }

        bool pnlMenuHide;

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenuHide == false)
            {
                if (pnlMenu.Width == 0)
                {
                    tmrMenu.Stop();
                    pnlMenuHide = true;
                }
                else
                {
                    pnlScore.Width -= 25;
                    pnlMenu.Width -= 25;
                    palancaFocusNivel = true;
                }
            }
            if (pnlMenuHide == true)
            {
                if (pnlMenu.Width == 300)
                {
                    tmrMenu.Stop();
                    pnlMenuHide = false;
                }
                else {                   
                    pnlMenu.Width += 10;
                    pnlScore.Width += 10;
                    palancaFocusNivel = false;
                }
                pnlMenu.BringToFront();
                pnlScore.BringToFront();
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            SoundButton.Play();
            tmrElecUser.Start();
        }

        bool pnlElecHide;

        private void tmrElecUser_Tick(object sender, EventArgs e)
        {
            if(pnlElecHide == true)
            {
                if (pnlSelecPlayer.Height == 0)
                {
                    tmrElecUser.Stop();
                    pnlElecHide = false;
                }else pnlSelecPlayer.Height -= 5;
            }
            if (pnlElecHide == false)
            {
                if (pnlSelecPlayer.Height == 100)
                {
                    tmrElecUser.Stop();
                    pnlElecHide = true;
                }else pnlSelecPlayer.Height += 5;
            }
        }
        
        Procedimientos objProce =  new Procedimientos();  

        private void btnPlayContinuar_Click(object sender, EventArgs e)
        {
            SoundButton.Play();

            if (cmbUsuarios.Text == "")
            {
                claseMessageBox.Mostrar("Usuario vacío !!!...");
            }
            else 
            {
                objProce.SubePuntaje(cmbUsuarios.Text, 0);

                cmbUsuarios.Items.Clear();
                foreach (var item in objProce.modeloLocal)
                {
                    cmbUsuarios.Items.Add(item.nombreJugador.ToString());
                }

                userActivo.user = cmbUsuarios.Text;
                userActivo.vidas = 5;

                soundStart2.Stop();
                cmbUsuarios.ResetText();

                pnlScore.Focus();
                pnlScore.Refresh();

                pnlContainer.Show();
                if (pnlContainer.Controls.Count > 0)
                {
                    pnlContainer.Controls.RemoveAt(0);
                }
                frmCap1 objFormCap1 = new frmCap1();
                objFormCap1.TopLevel = false;
                objFormCap1.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(objFormCap1);
                objFormCap1.Show();
                objFormCap1.Focus();
                pnlContainer.BringToFront();
                picEnemy.SendToBack();
                picProta.SendToBack();
            }                              
        }
        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            SoundButton.Play();

            tabla.Rows.Clear();
            foreach (var row in objProce.modeloLocal)
            {
                DataRow dr = tabla.NewRow();
                dr["nombre"] = row.nombreJugador;
                dr["puntaje"] = row.puntajeJugador;

                tabla.Rows.Add(dr);
            }
            dtgTableScore.DataSource = tabla;
        }       

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            SoundButton.Play();
            tmrMenu.Start();
            if (palancaFocusNivel == true)
            {
                pnlContainer.Focus();
                pnlContainer.BringToFront();
                btnReanudar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
