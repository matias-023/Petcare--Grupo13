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
    public class CD_Permiso
    {
        public List<Permiso> listar(int idUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.idRol, p.nombreMenu FROM PERMISO p");
                    query.AppendLine("inner join ROL r on r.idRol = p.idRol");
                    query.AppendLine("inner join USUARIO u on u.idRol = r.idRol");
                    query.AppendLine("WHERE u.idUsuario = @idUsuario");


                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);

                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { idRol = Convert.ToInt32(dr["idRol"]) },
                                nombreMenu = dr["nombreMenu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }

            return lista;

        }
    }
}
