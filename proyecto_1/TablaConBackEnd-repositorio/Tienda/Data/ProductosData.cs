using Tienda.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tienda.Data
{
    public class ProductosData
    {
        public static bool RegistrarP(Productos oProducto)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Registrar_P '" + oProducto.Nombre + "','" + oProducto.Link + "','" + oProducto.Precio + "','" + oProducto.Stock + "'";

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
        public static bool ActualizarP(Productos oProducto)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Actualizar_P '" + oProducto.ProductoID + "','" + oProducto.Nombre + "','" + oProducto.Link + "','" + oProducto.Precio + "','" + oProducto.Stock + "'";
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
        public static bool EliminarP(string id)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Eliminar_P '" + id + "'";
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
        public static List<Productos> Listar()
        {
            List<Productos> oListaUsuario = new List<Productos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Listar_P";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Productos()
                    {
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Link = dr["Link"].ToString(),
                        Precio = Convert.ToDouble(dr["Precio"].ToString()),
                        Stock = Convert.ToInt32(dr["Stock"].ToString())
                       
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }
        }
        public static List<Productos> Obtener(string id)
        {
            List<Productos> oListaUsuario = new List<Productos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_P '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Productos()
                    {
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Link = dr["Link"].ToString(),
                        Precio = Convert.ToDouble(dr["Precio"].ToString()),
                        Stock = Convert.ToInt32(dr["Stock"].ToString())
                        
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