using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

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
                    string query = "select idUsuario, documento, nombreCompleto, correo, clave, estado from USUARIO";
                    SqlCommand cmd = new SqlCommand(query, objConexion);
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
                                estado = Convert.ToBoolean(dr["estado"])
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


    }
}
