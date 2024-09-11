using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Reflection;
using System.Collections;
using System.Security.Claims;
using System.Xml.Linq;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select U.idUsuario, U.documento, U.nombreCompleto, U.correo, U.clave, U.estado, U.telefono, R.idRol, R.descripcion from USUARIO u");
                    query.AppendLine("inner join ROL r on r.idRol = U.idRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                documento = dr["documento"].ToString(),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                correo = dr["correo"].ToString(),
                                clave = dr["clave"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                telefono = dr["telefono"].ToString(),
                                oRol = new Rol() { idRol = Convert.ToInt32(dr["idRol"]), descripcion = dr["descripcion"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }

            return lista;

        }

        public int registrar(Usuario user, out string mensaje)
        {
            int idUsuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", objConexion);
                    cmd.Parameters.AddWithValue("documento", user.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", user.nombreCompleto);
                    cmd.Parameters.AddWithValue("correo", user.correo);
                    cmd.Parameters.AddWithValue("clave", user.clave);
                    cmd.Parameters.AddWithValue("telefono", user.telefono);
                    cmd.Parameters.AddWithValue("idRol", user.oRol.idRol);
                    cmd.Parameters.AddWithValue("estado", user.estado);

                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                mensaje = ex.Message;
                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }


        public bool editar(Usuario user, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", objConexion);
                    cmd.Parameters.AddWithValue("idUsuario", user.idUsuario);
                    cmd.Parameters.AddWithValue("documento", user.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", user.nombreCompleto);
                    cmd.Parameters.AddWithValue("correo", user.correo);
                    cmd.Parameters.AddWithValue("clave", user.clave);
                    cmd.Parameters.AddWithValue("telefono", user.telefono);
                    cmd.Parameters.AddWithValue("idRol", user.oRol.idRol);
                    cmd.Parameters.AddWithValue("estado", user.estado);

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

        private string validarExcepcion(string msg)
        {
            string msgAux = ""; 
            if (msg.Contains("CK_DniValido"))
            {
                msgAux = "El número de documento ingresado no es válido!";
            }
            if (msg.Contains("CK_NombreValido"))
            {
                msgAux = "El nombre completo ingresado no es válido!";
            }
            if (msg.Contains("CK_CorreoValido"))
            {
                msgAux = "El correo ingresado no es válido!";
            }
            if (msg.Contains("CK_TelefonoValido"))
            {
                msgAux = "El telefono ingresado no es válido!";
            }
            return msgAux;
        }
    }
}
