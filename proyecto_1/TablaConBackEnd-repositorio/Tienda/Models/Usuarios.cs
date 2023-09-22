using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Usuarios
    {
        public int UserID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get;set;}
    }
}