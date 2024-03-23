using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Producto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal IGV { get; set; }

        public decimal CalculatedIGV
        {
            get
            {
                return Price * IGV;
            }
        }
    }
}