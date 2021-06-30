using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Models
{
    public class FactEntity
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
        public string Total { get; set; }
        public string IdProducto { get; set; }


    }
}
