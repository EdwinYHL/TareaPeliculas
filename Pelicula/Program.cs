using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string title{get; set;}
        private short year{get; set;}
        private string countries{get; set;}
        private string directedby{get; set;}

        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(){}
        public Pelicula(string title, short year)
        {
            this.year=year;
            this.title=title;
        }
        //Métodos
        public void SetTitle(string title)
        {this.title=title;}
        public string getTitle()
        {return this.title;}
        public void SetYear(short year)
        {this.year=year;}
        public short getYear()
        {return this.year;}
        public void Imprime()
        {
            Console.WriteLine($"{title} ({year})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
           // Console.WriteLine($"{title} ({year})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
        Pelicula p1 = new Pelicula();
        p1.SetTitle("Birdman");
        p1.SetYear(2014);
        Console.WriteLine("{0}({1})", p1.getTitle(), p1.getYear());
        }
    }
}
