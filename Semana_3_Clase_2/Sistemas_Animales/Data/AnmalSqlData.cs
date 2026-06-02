using Microsoft.Data.SqlClient;
using Sistemas_Animales.Models;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;


namespace Sistemas_Animales.Data
{
    public class AnmalSqlData
    {
        
        public static List<AnimalModel> todos(){
            List<AnimalModel> lista_animales = new List<AnimalModel>();

			try
			{
				using (SqlConnection conn = new SqlConnection(ConexionSql.cadena))
				{
					conn.Open();
					string query = "SELECT * FROM Animales";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader lector = cmd.ExecuteReader())
						{
							while (lector.Read())
							{
								AnimalModel animal = new AnimalModel
								{
									id = Convert.ToInt32(lector["id"]),
									Edad = Convert.ToInt32(lector["Edad"]),
									Nombre = lector["Nombre"].ToString(),
									Sexo = lector["Sexo"].ToString(),
									Raza = lector["Raza"].ToString()
								};
								lista_animales.Add(animal);
							}
						}
					}

				}
			}
			catch (Exception ex)
			{
				throw;				
			}
			return lista_animales;
        }

		public static AnimalModel uno(int id) {
            AnimalModel animal = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.cadena))
                {
                    conn.Open();
                    string query = "SELECT * FROM Animales where id=" + id;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {

                            if (lector.Read()) {
                                animal = new AnimalModel
                                {
                                    id = Convert.ToInt32(lector["id"]),
                                    Edad = Convert.ToInt32(lector["Edad"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Sexo = lector["Sexo"].ToString(),
                                    Raza = lector["Raza"].ToString()
                                };
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return animal;

        }

        public static string Nuevo(AnimalModel animal) {
            try
            {
                using (SqlConnection conn =new SqlConnection(ConexionSql.cadena))
                {
                    conn.Open();
                    string query = "insert into animales(Nombre, Raza, Sexo, Edad)" +
                        "VALUES (@Nombre,@Raza,@Sexo,@Edad)";
                    using (SqlCommand cmd = new SqlCommand(query,conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", animal.Nombre);
                        cmd.Parameters.AddWithValue("@Raza", animal.Raza);
                        cmd.Parameters.AddWithValue("@Sexo", animal.Sexo);
                        cmd.Parameters.AddWithValue("@Edad", animal.Edad);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "ok";
            }   
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string Editar(AnimalModel animal)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.cadena))
                {
                    conn.Open();
                    string query = "update animales set Nombre=@Nombre," +
                        " Raza = @Raza, Sexo = @Sexo, Edad=@Edad where id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", animal.id);
                        cmd.Parameters.AddWithValue("@Nombre", animal.Nombre);
                        cmd.Parameters.AddWithValue("@Raza", animal.Raza);
                        cmd.Parameters.AddWithValue("@Sexo", animal.Sexo);
                        cmd.Parameters.AddWithValue("@Edad", animal.Edad);

                        int filas = cmd.ExecuteNonQuery();
                        if (filas == 0) return "Error al editar";
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.cadena))
                {
                    conn.Open();
                    string query = "delete from animales where id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int filas = cmd.ExecuteNonQuery();
                        if (filas == 0) return "Error al eliminar";
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
