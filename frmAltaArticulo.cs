using Dominio;
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

namespace Tp2_Winform
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
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
                //art.Marcas.IdMarca = int.Parse(tbxMarca.Text);
                //art.Categoria.IdCategoria = int.Parse(tbxCategoria.Text);
                //art.imagenes.ImagenUrl = tbxDescripcion.Text;

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
    }
}
