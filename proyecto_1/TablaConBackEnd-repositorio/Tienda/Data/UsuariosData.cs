using Tienda.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tienda.Data
{
    public class UsuariosData
    {
        public static bool RegistrarU(Usuarios oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Registrar_Us '" + oUsuario.Nombre + "','" + oUsuario.Email + "','" + oUsuario.Direccion + "'";

            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static bool ActualizarU(Usuarios oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Actualizar_Us '" +oUsuario.UserID + "','" + oUsuario.Nombre + "','" +oUsuario.Email + "','" + oUsuario.Direccion + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static bool EliminarU(string id)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Eliminar_Us '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static List<Usuarios> Listar()
        {
            List<Usuarios> oListaUsuario = new List<Usuarios>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Listar_Us";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Usuarios()
                    {
                        UserID = Convert.ToInt32(dr["UserID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Email = dr["Email"].ToString(),
                        Direccion = dr["Direccion"].ToString(), 
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }
        }
        public static List<Usuarios> Obtener(string id)
        {
            List<Usuarios> oListaUsuario = new List<Usuarios>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_Us '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Usuarios()
                    {
                        UserID = Convert.ToInt32(dr["UserID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Email = dr["Email"].ToString(),
                        Direccion = dr["Direccion"].ToString()
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }
        }
    }
}