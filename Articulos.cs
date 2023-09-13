using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Winform
{
    internal class Articulos
    {
        public int IdArticulo { get; set; }
        public string CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public Marcas Marcas { get; set; }
        public Categoria Categoria { get; set; }
        public float Precio { get; set; }
        public Imagenes imagenes { get; set; }

    }
}
