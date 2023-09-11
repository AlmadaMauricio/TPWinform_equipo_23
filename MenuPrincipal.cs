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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            VerDetalle ventana = new VerDetalle();
            ventana.ShowDialog();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio();
            this.Close();
            ventanaInicio.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListar ventana = new frmListar();
            ventana.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPor ventana = new frmBuscarPor();
            this.Close();
            ventana.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventanaAgregar = new frmAgregar();
            this.Close();
            ventanaAgregar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar ventanaModificar = new frmModificar();
            this.Close();
            ventanaModificar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar ventanaEliminar = new frmEliminar();
            this.Close();
            ventanaEliminar.Show();
        }
    }
}
