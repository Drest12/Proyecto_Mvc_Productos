using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrjProductosMVC.Models
{
    public class Producto
    {
        public int codprod { get; set; }

        public string nomprod { get; set; }

        public double precio { get; set; }

        public DateTime fechareg { get; set; }

        public bool suspendido { get; set; }
    }
}