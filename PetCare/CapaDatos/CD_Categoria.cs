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
    public class CD_Categoria
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.idCategoria, c.descripcion, c.estado from CATEGORIA c");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                idCategoria = Convert.ToInt32(dr["idCategoria"]),
                                descripcion = dr["descripcion"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }
            }

            return lista;

        }

        public int registrar(Categoria cat, out string mensaje)
        {
            int idCategoriaGenerado = 0;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", objConexion);  
                    cmd.Parameters.AddWithValue("descripcion", cat.descripcion);
                    cmd.Parameters.AddWithValue("estado", cat.estado);

                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    cmd.ExecuteNonQuery();
                    idCategoriaGenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCategoriaGenerado = 0;
                mensaje = ex.Message;

                mensaje = validarExcepcion(mensaje);
                if (mensaje == "") mensaje = ex.Message;
            }

            return idCategoriaGenerado;
        }


        public bool editar(Categoria cat, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {

                using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", objConexion);
                    cmd.Parameters.AddWithValue("idCategoria", cat.idCategoria);
                    cmd.Parameters.AddWithValue("descripcion", cat.descripcion);
                    cmd.Parameters.AddWithValue("estado", cat.estado);

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
            if (msg.Contains("CK_Categoria_Descripcion"))
                msgAux = "La descripción ingresada no es válida!";

            return msgAux;
        }
    }
}
