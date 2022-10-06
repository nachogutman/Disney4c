using System;
using System.Collections.Generic;

namespace Disney4c.Models;

    public  class Personaje
    {
        private int _IdPersonaje;
        private string _Nombre;
        private string _Apellido;
        private string _Pelicula;
        private string _Serie;
        private string _Imagen;
        private int _Edad;
    
         public Personaje(string Nombre, string Apellido, string Pelicula, string Serie, string Imagen, int Edad)
         {
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Pelicula = Pelicula;
            _Serie = Serie;
            _Imagen = _Imagen;
            _Edad = Edad;
         } 
        public Personaje()
        {
            _Nombre = "";
            _Apellido = "";
            _Pelicula = "";
            _Serie = "";
            _Imagen = "";
            _Edad = 0;
        }
        public int IdPersonaje
        {
            get {return _IdPersonaje;}
            set {_IdPersonaje = value;}
        }
        
        public string Nombre 
        {
            get {return _Nombre;}
            set {_Nombre = value;}
        } 
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Pelicula
        {
            get { return _Pelicula;}
            set {_Pelicula = value;}
        }

        public string Serie
        {
            get { return _Serie;}
            set {_Serie = value;}
        }
    }
