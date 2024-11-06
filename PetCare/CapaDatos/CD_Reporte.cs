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
        public List<reporteVenta> Venta(string fechainicio, string fechafin, Usuario user)
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
                    cmd.Parameters.AddWithValue("rol", user.oRol.idRol);
                    cmd.Parameters.AddWithValue("idUsuario", user.idUsuario);
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new reporteVenta()
                            {
                                idVenta = Convert.ToInt32(dr["idVenta"].ToString()),
                                fechaRegistro = dr["fechaRegistro"].ToString(),
                                horaRegistro = dr["horaRegistro"].ToString(),
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numeroDocumento = dr["numeroDocumento"].ToString(),
                                documentoUsuario = dr["documentoUsuario"].ToString(),
                                usuarioRegistro = dr["usuarioRegistro"].ToString(),
                                documentoCliente = dr["documentoCliente"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                montoTotal = dr["montoTotal"].ToString(),
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

        public DataTable productosMasVendidos(string nombreProc, string fechainicio, string fechafin)
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    objConexion.Open();

                    SqlCommand cmd = new SqlCommand(nombreProc, objConexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);

                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }


    }
}
