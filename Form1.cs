using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace Tp2_Winform
{
    public partial class frmInicio : Form
    {
        private List <Articulos> listaArticulos;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = articuloNegocio.listar();
            pictureBox1.Load(listaArticulos[0].imagenes.ImagenUrl);
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["Imagenes"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.imagenes.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch(Exception ex)
            {
                pictureBox1.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2BE8kfCxYeYJdyMOfPEa2SXafa1TOzoH43t8_sYGq&s");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
        }

        private void btnLitstar_Click(object sender, EventArgs e)
        {

        }
    }
}
