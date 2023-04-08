using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBocNamespace
{
    public static class claseMessageBox
    {
        public static DialogResult Mostrar(string mensaje)
        {
            DialogResult result = DialogResult.None;

            using (frmMessaBox ok = new frmMessaBox())
            {
                ok.message = mensaje;
                result = ok.ShowDialog();
            }
            return result;
        }  
    }
}
