    using Tienda.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tienda.Data
{
    public class ComprasData
    {
        public static bool RegistrarC(Compras oCompra)
        {

            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "' EXECUTE Registrar_C '" + oCompra.ComprasID + "','"+oCompra.@fk_ProductoID + oCompra.fk_UserID + "','" +oCompra.FechaCompra+"'";

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
        public static bool ActualizarC(Compras oCompra)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Actualizar_C '" + oCompra.ComprasID + "','" + oCompra.fk_ProductoID + oCompra.fk_UserID + "','" + oCompra.FechaCompra + "'";
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
        public static bool EliminarC(string id)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Eliminar_C '" + id + "'";
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
        public static List<Compras> Listar()
        {
            List<Compras> oCompra = new List<Compras>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Listar_C";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oCompra.Add(new Compras()
                    {
                        ComprasID = Convert.ToInt32(dr["ComprasID"].ToString()),
                        fk_UserID = Convert.ToInt32(dr["fk_UserID"].ToString()),
                        fk_ProductoID = Convert.ToInt32(dr["fk_ProductoID"].ToString()),
                        FechaCompra = Convert.ToDateTime(dr["FechaCompra"].ToString())
                    });
                }
                return oCompra;
            }
            else
            {
                return oCompra;
            }
        }
        public static List<Compras> Obtener(string id)
        {
            List<Compras> oCompra = new List<Compras>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_C '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oCompra.Add(new Compras()
                    {
                        ComprasID = Convert.ToInt32(dr["CompraID"]),
                        fk_UserID = Convert.ToInt32(dr["fk_UserID"]),
                        fk_ProductoID = Convert.ToInt32(dr["fk_ProductoID"]),
                        FechaCompra = Convert.ToDateTime(dr["FechaCompra"])
                    });
                }
                return oCompra;
            }
            else
            {
                return oCompra;
            }
        }
    }
}