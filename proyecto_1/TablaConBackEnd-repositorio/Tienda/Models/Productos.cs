using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Productos
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Link { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
    
}