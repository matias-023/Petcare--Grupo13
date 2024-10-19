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
    public class CD_Producto
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.idProducto, p.codigo, p.nombre, m.idMarca, m.descripcion[descMarca], c.idCategoria, c.descripcion[descCategoria], p.stock_min, p.stock, p.precio, p.precioVenta, p.estado from PRODUCTO p");
                    query.AppendLine("inner join Marca m on p.idMarca = m.idMarca");
                    query.AppendLine("inner join CATEGORIA c on p.idCategoria = c.idCategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                idProducto = Convert.ToInt32(dr["idProducto"]),
                                codigo = dr["codigo"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                oMarca = new Marca() { idMarca = Convert.ToInt32(dr["idMarca"]), descripcion = dr["descMarca"].ToString() },
                                oCategoria = new Categoria() { idCategoria = Convert.ToInt32(dr["idCategoria"]), descripcion = dr["descCategoria"].ToString() },
                                stock_min = Convert.ToInt32(dr["stock_min"]),
                                stock = Convert.ToInt32(dr["stock"]),
                                precio = Convert.ToDecimal(dr["precio"]),
                                precio_venta = Convert.ToDecimal(dr["precioVenta"]),
                                estado = Convert.ToBoolean(dr["estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }

            return lista;

        }

        public int registrar(Producto prod, out string mensaje)
        {
            int idProductoGenerado = 0;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", objConexion);
                    cmd.Parameters.AddWithValue("codigo", prod.codigo);
                    cmd.Parameters.AddWithValue("nombre", prod.nombre);
                    cmd.Parameters.AddWithValue("stock", prod.stock);
                    cmd.Parameters.AddWithValue("stock_min", prod.stock_min);
                    cmd.Parameters.AddWithValue("precio", prod.precio);
                    cmd.Parameters.AddWithValue("precioVenta", prod.precio_venta);
                    cmd.Parameters.AddWithValue("idMarca", prod.oMarca.idMarca);
                    cmd.Parameters.AddWithValue("idCategoria", prod.oCategoria.idCategoria);
                    cmd.Parameters.AddWithValue("estado", prod.estado);

                    cmd.Parameters.Add("idProductoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    idProductoGenerado = Convert.ToInt32(cmd.Parameters["idProductoResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                mensaje = ex.Message;
                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message;
            }

            return idProductoGenerado;
        }


        public bool editar(Producto prod, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", objConexion);
                    cmd.Parameters.AddWithValue("idProducto", prod.idProducto);
                    cmd.Parameters.AddWithValue("codigo", prod.codigo);
                    cmd.Parameters.AddWithValue("nombre", prod.nombre);
                    cmd.Parameters.AddWithValue("stock", prod.stock);
                    cmd.Parameters.AddWithValue("stock_min", prod.stock_min);
                    cmd.Parameters.AddWithValue("precio", prod.precio);
                    cmd.Parameters.AddWithValue("precioVenta", prod.precio_venta);
                    cmd.Parameters.AddWithValue("idMarca", prod.oMarca.idMarca);
                    cmd.Parameters.AddWithValue("idCategoria", prod.oCategoria.idCategoria);
                    cmd.Parameters.AddWithValue("estado", prod.estado);

                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message;
            }


            return respuesta;
        }

        private string validarExcepcion(string msg) //Se verifica que no hayan datos no validos ingresados
        {
            string msgAux = "";
            if (msg.Contains("CK_Producto_Codigo"))
                msgAux = "El código de producto ingresado no es válido, solo pueden ser números!";
            return msgAux;
        }
    }
}
