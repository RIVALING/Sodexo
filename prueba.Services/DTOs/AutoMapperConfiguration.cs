using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using prueba.Services.Models;

namespace prueba.Services.DTOs
{ 
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Factura, FacturaDTO>()
                   .ReverseMap();

                cfg.CreateMap<Producto, ProductoDTO>()
                   .ForMember(x => x.Factura, o => o.Ignore())
                   .ReverseMap();
            });
        }
    }
}
