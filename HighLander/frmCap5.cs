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

namespace HighLander
{
    public partial class frmCap5 : Form
    {
        SoundPlayer soundLevel = new SoundPlayer(@"Proyecto videojuego\Musica\Nivel 5.wav");

        public frmCap5()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            soundLevel.Stop();
            this.Close();
            if (frmPrincipal.pnlContainer.Controls.Count > 0)
            {
                frmPrincipal.pnlContainer.Controls.RemoveAt(0);
            }          
            frmPrincipal.pnlContainer.SendToBack();
            frmPrincipal.ActiveForm.BringToFront();
        }
    }
}
