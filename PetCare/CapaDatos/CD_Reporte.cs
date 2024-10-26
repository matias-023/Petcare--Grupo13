using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public List<reporteVenta> Venta(string fechainicio, string fechafin)
        {
            List<reporteVenta> lista = new List<reporteVenta>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", objConexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new reporteVenta()
                            {
                                fechaRegistro = dr["fechaRegistro"].ToString(),
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numeroDocumento = dr["numeroDocumento"].ToString(),
                                montoTotal = dr["montoTotal"].ToString(),
                                usuarioRegistrado = dr["usuarioRegistrado"].ToString(),
                                documentoCliente = dr["documentoCliente"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                codigoProducto = dr["codigoProducto"].ToString(),
                                nombreProducto = dr["nombreProducto"].ToString(),
                                categoria = dr["categoria"].ToString(),
                                precioVenta = dr["precioVenta"].ToString(),
                                cantidad = dr["cantidad"].ToString(),
                                subTotal = dr["subTotal"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<reporteVenta>();
                }
            }

            return lista;

        }


    }
}
