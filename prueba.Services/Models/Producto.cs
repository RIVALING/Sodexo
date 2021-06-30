using System;
using System.Collections.Generic;

#nullable disable

namespace prueba.Services.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Facturas = new HashSet<Factura>();
        }

        public string IdProducto { get; set; }
        public string Producto1 { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
