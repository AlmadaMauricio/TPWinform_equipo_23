using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_Winform
{
    public partial class frmBuscarPor : Form
    {
        public frmBuscarPor()
        {
            InitializeComponent();
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.ShowDialog();
        }
    }
}
