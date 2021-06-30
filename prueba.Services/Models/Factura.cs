using System;
using System.Collections.Generic;

#nullable disable

namespace prueba.Services.Models
{
    public partial class Factura
    {
        public string IdFactura { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string TipodePago { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public double Subtotal { get; set; }
        public double Descuento { get; set; }
        public double Iva { get; set; }
        public double TotalDescuento { get; set; }
        public double TotalImpuesto { get; set; }
        public double Total { get; set; }
        public string IdProducto { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
    }
}
