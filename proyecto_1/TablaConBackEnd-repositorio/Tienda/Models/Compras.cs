using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Compras
    {
        public int ComprasID { get; set; }
        public int fk_UserID { get; set; }
        public int fk_ProductoID { get; set; }
        public DateTime FechaCompra { get; set; }
    }
    
}