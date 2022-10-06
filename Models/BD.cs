using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Disney4c.Models{

public static class BD
    {
        private static List<Personaje> _ListadoPersonajes= new List<Personaje>(); 
         private static string _connectionString = @"Server=127.0.0.1; 
        Database=PreguntadORT;Trusted_Connection=True;";
                public static int Elmininar(int IdPersonaje)
            {
        
                string sql = "DELETE FROM Personajes WHERE IdPersonaje = @IdPersonaje";
                using(SqlConnection db = new SqlConnection(_connectionString))
                {
                 return db.Execute(sql, new { IdPersonaje=IdPersonaje});
                }
            }

                public static List<Personaje> ListarPersonajes()
                    {

                using (SqlConnection db = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM Personajes";
                    _ListadoPersonajes =db.Query<Personaje>(sql).ToList();
                
                }
                return _ListadoPersonajes;
                }
    }
}
