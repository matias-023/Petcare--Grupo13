using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using System.Reflection;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int obtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT COUNT(*) + 1 FROM VENTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());


                }
                catch
                {
                    idCorrelativo = 0;
                }
            }
            return idCorrelativo;
        }


        //Control de stock de productos al agregar a la venta (restar stock al añadir a la venta)
        public bool restarStock (int idProducto, int cantidad, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PRODUCTO SET stock = stock - @cantidad where idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;

                    mensaje = validarExcepcion(mensaje);
                    if (mensaje == "") mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        public bool sumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PRODUCTO SET stock = stock + @cantidad where idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("idUsuario", obj.oUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.tipoDocumento);
                    cmd.Parameters.AddWithValue("numeroDocumento", obj.numeroDocumento);
                    cmd.Parameters.AddWithValue("documentoCliente", obj.documentoCliente);
                    cmd.Parameters.AddWithValue("nombreCliente", obj.nombreCliente);
                    cmd.Parameters.AddWithValue("montoPago", obj.montoPago);
                    cmd.Parameters.AddWithValue("montoCambio", obj.montoCambio);
                    cmd.Parameters.AddWithValue("montoTotal", obj.montoTotal);

                    // Parámetro de tipo tabla para los detalles de la venta
                    SqlParameter detalleVentaParam = new SqlParameter();
                    detalleVentaParam.ParameterName = "DetalleVenta";
                    detalleVentaParam.SqlDbType = SqlDbType.Structured;
                    detalleVentaParam.Value = DetalleVenta;
                    cmd.Parameters.Add(detalleVentaParam);

                    // Parámetros de salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    // Ejecutar la consulta
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Obtener los valores de los parámetros de salida
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                    if (Mensaje.Contains("CK_Venta_montoPago"))
                        Mensaje = "El monto de pago debe ser mayor o igual al total!";
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        private string validarExcepcion(string msg)
        {
            string msgAux = "";
            if (msg.Contains("CK_Producto_stock"))
                msgAux = "No hay stock suficiente!";
            
            return msgAux;
        }

        public Venta obtenerVenta (string numero)
        {
            Venta obj = new Venta();
            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select v.idVenta, v.idUsuario, u.nombreCompleto, u.documento, v.documentoCliente, v.nombreCliente, v.tipoDocumento,");
                    query.AppendLine("v.numeroDocumento, v.montoPago, v.montoCambio, v.montoTotal, v.fechaRegistro from venta v");
                    query.AppendLine("inner join USUARIO u on u.idUSuario = v.idUsuario");
                    query.AppendLine("where v.numeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Venta()
                            {
                                idVenta = Convert.ToInt32(dr["idVenta"]),
                                oUsuario = new Usuario()
                                {
                                    idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                    documento = dr["documento"].ToString(),
                                    nombreCompleto = dr["nombreCompleto"].ToString()
                                },
                                documentoCliente = dr["documentoCliente"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numeroDocumento = dr["numeroDocumento"].ToString(),
                                montoPago = Convert.ToDecimal(dr["montoPago"].ToString()),
                                montoCambio = Convert.ToDecimal(dr["montoCambio"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                                fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"]).ToString("dd-MM-yyyy HH:mm:ss")
                            };
                        }
                    } 
                }
                catch
                {
                    obj = new Venta();
                }
            }
            return obj;
        }

        public List<DetalleVenta> obtenerDetalleVenta(int idVenta)
        {
            List<DetalleVenta> oLista = new List<DetalleVenta>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.codigo, p.nombre, dv.precioVenta, dv.cantidad, dv.subTotal from DETALLE_VENTA dv");
                    query.AppendLine("inner join PRODUCTO p on p.idProducto = dv.idProducto");
                    query.AppendLine("where dv.idVenta = @idVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleVenta()
                            {
                                oProducto = new Producto()
                                {
                                    codigo = dr["codigo"].ToString(),
                                    nombre = dr["nombre"].ToString()
                                },
                                precioVenta = Convert.ToDecimal(dr["precioVenta"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                subTotal = Convert.ToDecimal(dr["subTotal"].ToString())
                            });
                        }
                    }

                }
                catch
                {
                    oLista = new List<DetalleVenta>();
                }
            }
            return oLista;
        }



    }
}
