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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cerrar app
            Close();
        }
    }
}