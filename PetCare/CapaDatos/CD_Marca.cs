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
    public class CD_Marca
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT m.idMarca, m.descripcion, m.estado from Marca m");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Marca()
                            {
                                idMarca = Convert.ToInt32(dr["idMarca"]),
                                descripcion = dr["descripcion"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Marca>();
                }
            }

            return lista;

        }

        public int registrar(Marca marca, out string mensaje)
        {
            int idMarcaGenerado = 0;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARMARCA", objConexion);
                    cmd.Parameters.AddWithValue("descripcion", marca.descripcion);
                    cmd.Parameters.AddWithValue("estado", marca.estado);

                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    idMarcaGenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idMarcaGenerado = 0;
                mensaje = ex.Message;

                /*
                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message; */
            }

            return idMarcaGenerado;
        }


        public bool editar(Marca marca, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARMARCA", objConexion);
                    cmd.Parameters.AddWithValue("idMarca", marca.idMarca);
                    cmd.Parameters.AddWithValue("descripcion", marca.descripcion);
                    cmd.Parameters.AddWithValue("estado", marca.estado);

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

                /*
                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message; */
            }


            return respuesta;
        }

        private string validarExcepcion(string msg) //Se verifica que no hayan datos no validos ingresados
        {
            string msgAux = "";
            if (msg.Contains("CK_Marca_Dni"))
                msgAux = "El número de documento ingresado no es válido!";

            return msgAux;
        }
    }
}
