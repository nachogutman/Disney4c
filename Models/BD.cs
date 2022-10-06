using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Disney4c.Models{

public static class BD
    {
         private static string _connectionString = @"Server=127.0.0.1; 
        Database=PreguntadORT;Trusted_Connection=True;";
                public static int Elmininar()
            {
        
                string sql = "DELETE FROM  WHERE IdPregunta = @IdPregunta";
                using(SqlConnection db = new SqlConnection(_connectionString))
                {
                 return db.Execute(sql, new { IdPregunta=IdPregunta});
                }
            }

                public static List<Pregunta> Listar()
                    {

                using (SqlConnection db = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM Preguntas";
                    _TodasListadoPreguntas =db.Query<Pregunta>(sql).ToList();
                
                }
                return _TodasListadoPreguntas;
                }
    }
}
