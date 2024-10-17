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
    public class CD_Cliente
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idCliente, documento, nombreCompleto, correo, telefono, estado from CLIENTE");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                idCliente = Convert.ToInt32(dr["idCliente"]),
                                documento = dr["documento"].ToString(),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }
            }

            return lista;

        }

        public int registrar(Cliente user, out string mensaje)
        {
            int idClienteGenerado = 0;
            mensaje = string.Empty;
            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", objConexion);
                    cmd.Parameters.AddWithValue("documento", user.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", user.nombreCompleto);
                    cmd.Parameters.AddWithValue("correo", user.correo);
                    cmd.Parameters.AddWithValue("telefono", user.telefono);
                    cmd.Parameters.AddWithValue("estado", user.estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                mensaje = ex.Message;
                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message;
            }

            return idClienteGenerado;
        }


        public bool editar(Cliente user, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarCliente", objConexion);
                    cmd.Parameters.AddWithValue("idCliente", user.idCliente);
                    cmd.Parameters.AddWithValue("documento", user.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", user.nombreCompleto);
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
            if (msg.Contains("CK_Cliente_Dni"))
                msgAux = "El número de documento ingresado no es válido!";

            if (msg.Contains("CK_Cliente_Nombre"))
                msgAux = "El nombre completo ingresado no es válido!";

            if (msg.Contains("CK_Cliente_Correo"))
                msgAux = "El correo ingresado no es válido!";

            if (msg.Contains("CK_Cliente_Telefono"))
                msgAux = "El telefono ingresado no es válido!";

            return msgAux;
        }
    }
}
