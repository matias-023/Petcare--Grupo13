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
    public class CD_Proveedor
    {
        public List<Proveedor> listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProveedor, documento, razonSocial, correo, telefono, estado from Proveedor");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(dr["idProveedor"]),
                                documento = dr["documento"].ToString(),
                                razonSocial = dr["razonSocial"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                }
            }

            return lista;

        }

        public int registrar(Proveedor user, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;
            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarProveedor", objConexion);
                    cmd.Parameters.AddWithValue("documento", user.documento);
                    cmd.Parameters.AddWithValue("razonSocial", user.razonSocial);
                    cmd.Parameters.AddWithValue("correo", user.correo);
                    cmd.Parameters.AddWithValue("telefono", user.telefono);
                    cmd.Parameters.AddWithValue("estado", user.estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                mensaje = ex.Message;
                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }


        public bool editar(Proveedor user, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarProveedor", objConexion);
                    cmd.Parameters.AddWithValue("IdProveedor", user.IdProveedor);
                    cmd.Parameters.AddWithValue("documento", user.documento);
                    cmd.Parameters.AddWithValue("razonSocial", user.razonSocial);
                    cmd.Parameters.AddWithValue("correo", user.correo);
                    cmd.Parameters.AddWithValue("telefono", user.telefono);
                    cmd.Parameters.AddWithValue("estado", user.estado);


                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
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
            if (msg.Contains("CK_Proveedor_Dni"))
                msgAux = "El número de documento ingresado no es válido!";

            if (msg.Contains("CK_Proveedor_Correo"))
                msgAux = "El correo ingresado no es válido!";

            if (msg.Contains("CK_Proveedor_Telefono"))
                msgAux = "El telefono ingresado no es válido!";

            return msgAux;
        }
    }
}
