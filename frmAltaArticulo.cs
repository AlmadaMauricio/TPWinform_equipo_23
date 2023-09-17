using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.CodeDom;

namespace Tp2_Winform
{
    public partial class frmAltaArticulo : Form
    {
        private Articulos articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulos articulos)
        {
            InitializeComponent();
            this.articulo = articulos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                art.CodArticulo = tbxCodigo.Text;
                art.NombreArticulo = tbxNombre.Text;
                art.DescripcionArticulo = tbxDescripcion.Text;
                art.IdMarca = int.Parse(tbxMarca.Text);
                art.IdCategoria = int.Parse(tbxCategoria.Text);
                art.Precio = float.Parse(tbxPrecio.Text);
                art.imagenes = new Imagenes();
                art.imagenes.ImagenUrl = tbxDescripcion.Text;

                negocio.agregar(art);
                MessageBox.Show("Agregado Exitosamente!!");
                Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
