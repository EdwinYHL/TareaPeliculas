using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string title{get; set;}
        private Int16 year{get; set;}
        private string countries{get; set;}
        private string directedby{get; set;}
        //Constructores
        public Pelicula(){}
        public Pelicula(string title, Int16 year)
        {
            this.year=year;
            this.title=title;
        }
        //Métodos
        public void SetTitle(string title)
        {this.title=title;}
        public string getTitle()
        {return this.title;}
        public void SetYear(Int16 year)
        {this.year=year;}
        public Int16 getYear()
        {return this.year;}
        public void Imprime()
        {
            Console.WriteLine($"{title} ({year})");
        }
        private List<Actor> actors = new List<Actor>();
        public void AddActor(Actor actor)
        {
            actors.Add(actor);
        }
        public void printActors()
        {
            foreach (Actor actor in actors)
            {
                actor.Imprime();
            }
        }
    }
    public class Actor
    {
        //Propiedades
        private string name{ get; set; }
        private Int16 year{ get; set; }
        public Actor(string name, Int16 year)
        {
            this.name = name;
            this.year = year;
        }
        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{name} ({year})");
        }
        
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula movie1 = new Pelicula();
            movie1.SetTitle("Birdman");
            movie1.SetYear(2014);
            Pelicula movie2 = new Pelicula();
            movie2.SetTitle("Guillermo del Toro's Pinocchio");
            movie2.SetYear(2022);
            movie1.Imprime();
            movie2.Imprime();
        }
    }
}
