using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using prueba.Models.Request;
using prueba.Models.ViewModel;

namespace prueba.AccesoDatos
{
    public  class Acceso
    {
        private string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();

        public PersonaRequest obtenerPersona(string nombre)
        {
            PersonaRequest resultado = new PersonaRequest();

            SqlConnection cn = new SqlConnection(this.cadenaConexion);

            try
            {
                SqlCommand comando = new SqlCommand();
                string consulta = @"SELECT p.nombre,p.edad,CONVERT(VARCHAR,t.prefijo)+CONVERT(VARCHAR,t.numero)'telefono' FROM Personas p JOIN tel t ON p.id = t.idPersona
                                  WHERE p.nombre = @nombre";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", nombre);

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;

                cn.Open();
                comando.Connection = cn;

                SqlDataReader dr = comando.ExecuteReader(); 

                while (dr.Read())
                {

                    resultado.Nombre = dr["nombre"].ToString();
                    resultado.Edad = Int32.Parse(dr["edad"].ToString());

                    Telefono tel = new Telefono();
                    //tel.PreFijo = Int32.Parse(dr["prefijo"].ToString());
                    tel.Tel = dr["telefono"].ToString();
                    resultado.telefonos.Add(tel);

                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }


    }
}