using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo{get; set;}
        private Int16 año{get; set;}
        private string countries{get; set;}
        private string directedby{get; set;}
        //Constructores
        public Pelicula(){}
        public Pelicula(string titulo, Int16 año)
        {
            this.año=año;
            this.titulo=titulo;
        }
        //Métodos
        public void SetTitulo(string titulo)
        {this.titulo=titulo;}
        public string GetTitulo()
        {return this.titulo;}
        public void SetAño(Int16 año)
        {this.año=año;}
        public Int16 GetAño()
        {return this.año;}
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }
        private List<Actor> actores = new List<Actor>();
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void ImprimeActores()
        {
            foreach (Actor actor in actores)
            {
                actor.Imprime();
            }
        }
    }
    public class Actor
    {
        //Propiedades
        private string nombre{ get; set; }
        private Int16 año{ get; set; }
        public Actor(string nombre, Int16 año)
        {
            this.nombre = nombre;
            this.año = año;
        }
        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{nombre} ({año})");
        }
        
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula movie1 = new Pelicula();
            movie1.SetTitulo("Birdman");
            movie1.SetAño(2014);
            movie1.AgregaActor(new Actor("Michael Keaton", 1951));
            movie1.AgregaActor(new Actor("Edward Norton", 1969));
            Pelicula movie2 = new Pelicula();
            movie2.SetTitulo("Guillermo del Toro's Pinocchio");
            movie2.SetAño(2022);
            movie2.AgregaActor(new Actor("Gregory Mann", 2008));
            movie2.AgregaActor(new Actor("David Bradley", 1942));
            Console.Write("First Movie: ");
            movie1.Imprime();
            Console.Write("Starring: ");
            movie1.ImprimeActores();
            Console.Write("Second Movie: ");
            movie2.Imprime();
            Console.Write("Starring: ");
            movie2.ImprimeActores();
        }
    }
}
