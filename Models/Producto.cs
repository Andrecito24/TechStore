using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal IGV { get; set; }

        public decimal CalculatedIGV
        {
            get
            {
                return Precio * IGV;
            }
        }
    }
}