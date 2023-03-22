using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo;
        public short año;
        public string pais;
        public string director;

        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula()
        {
            titulo = "Birdman";
            año = 2014;
            pais = "EE.UU";
            director = "Alejandro González Iñárritu";
        }
        
     
        //Métodos
     
        public void Imprime()
        {
           // Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            //Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula movie1 = new Pelicula();
            Console.WriteLine ("Pelicula Ganadora: " + movie1.titulo + " Año: " + movie1.año);
            Pelicula movie2 = new Pelicula();
            movie2.titulo = "Guillermo del Toro's Pinocchio";
            movie2.año = 2022;
            Console.WriteLine ("Pelicula Ganadora: " + movie2.titulo + " Año: " + movie2.año);
        }
    }
}
