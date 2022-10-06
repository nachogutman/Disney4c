using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Disney4c.Models{

public static class BD
    {
         private static string _connectionString = @"Server=127.0.0.1; 
        Database=PreguntadORT;Trusted_Connection=True;";
                public static int Elmininar(int IdPersonaje)
            {
        
                string sql = "DELETE FROM  WHERE IdPersonaje = @IdPersonaje";
                using(SqlConnection db = new SqlConnection(_connectionString))
                {
                 return db.Execute(sql, new { IdPersonaje=IdPersonaje});
                }
            }

                public static List<Pregunta> Listar()
                    {

                using (SqlConnection db = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM Personajes";
                    ListaPersonajes =db.Query<Pregunta>(sql).ToList();
                
                }
                return ListaPersonajes;
                }
    }
}
