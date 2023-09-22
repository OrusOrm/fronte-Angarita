using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tienda.Data;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class ProductosController : ApiController
    {
        // GET api/<controller>
        public List<Productos> Get()
        {
            return ProductosData.Listar();
        }
        // GET api/<controller>/5
        public List<Productos> Get(string id)
        {
            return ProductosData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Productos oProducto)
        {
            return ProductosData.RegistrarP(oProducto);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Productos oProducto)
        {
            return ProductosData.ActualizarP(oProducto);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ProductosData.EliminarP(id);
        }
    }
}