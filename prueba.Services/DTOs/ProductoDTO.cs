using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.DTOs
{
    public class ProductoDTO
    {

        public string IdProducto { get; set; }
        public string Producto1 { get; set; }

        public ProductoDTO Producto { get; set; }

        public List<FacturaDTO> Factura{ get; set; }

    }
}
