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
    public class UsuariosController : ApiController
    {
        // GET api/<controller>
        public List<Usuarios> Get()
        {
            return UsuariosData.Listar();
        }
        // GET api/<controller>/5
        public List<Usuarios> Get(string id)
        {
            return UsuariosData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Usuarios oUsuario)
        {
            return UsuariosData.RegistrarU(oUsuario);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Usuarios oUsuario)
        {
            return UsuariosData.ActualizarU(oUsuario);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return UsuariosData.EliminarU(id);
        }
    }
}