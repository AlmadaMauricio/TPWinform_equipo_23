﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Winform
{
    internal class Marcas
    {
        public int IdMarca { get; set; }
        public string DescripcionMarca { get; set; }
        public override string ToString()
        {
            return DescripcionMarca;
        }

    }
}