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
    public class CD_Rol
    {
        public List<Rol> listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idRol, descripcion FROM ROL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objConexion);

                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                idRol = Convert.ToInt32(dr["idRol"]),
                                descripcion = dr["descripcion"].ToString()

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }
            }

            return lista;

        }
    }
}
