using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Disney4c.Models{

public static class BD
    {
        private static List<Personaje> _ListadoPersonajes= new List<Personaje>(); 
        private static List<Personaje> ListadoPersonajesBuscados = new List<Personaje>();
         private static string _connectionString = @"Server=127.0.0.1; 
        Database=PreguntadORT;Trusted_Connection=True;";

        public static void AgregarPersonaje(Personaje pers){
        string sql = "INSERT INTO Personajes(Nombre,Apellido,Pelicula, Serie, Imagen, Edad) VALUES (@pNombre, @pApellido, @pPelicula, @pSerie, @pImagen, @pEdad)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new {pNombre=pers.Nombre, pApellido=pers.Apellido, pPelicula=pers.Pelicula, pSerie=pers.Serie, pImagen=pers.Imagen, pEdad=pers.Edad });
        }
    }
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

         public static Personaje VerInfoPersonaje(int IdPersonaje)
           {
           Personaje MiPersonaje= null;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql ="SELECT * FROM Personajes where IdPersonaje = @IdPersonaje";
                MiPersonaje = db.QueryFirstOrDefault<Personaje>(sql,new {IdPersonaje=IdPersonaje});

            }
            return MiPersonaje;


            }
            public static List<Personaje> BuscarPersonaje(string param)
           {
           
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql ="SELECT * FROM Personajes like '%param'";
                ListadoPersonajesBuscados =db.Query<Personaje>(sql).ToList();

            }
            return ListadoPersonajesBuscados;


            }

    }
}


   

