﻿using System;
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
    public partial class VerDetalle : Form
    {
        public VerDetalle()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            this.Close();
            ventana.Show();
        }
    }
}
