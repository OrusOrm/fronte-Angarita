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
    public class ComprasController : ApiController
    {
        // GET api/<controller>
        public List<Compras> Get()
        {
            return ComprasData.Listar();
        }
        // GET api/<controller>/5
        public List<Compras> Get(string id)
        {
            return ComprasData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Compras oCompra)
        {
            return ComprasData.RegistrarC(oCompra);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Compras oCompra)
        {
            return ComprasData.ActualizarC(oCompra);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ComprasData.EliminarC(id);
        }
    }
}