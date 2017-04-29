using System;
using Lab1.Szachy;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura pionek = new Pionek("Pionek", "B5", "Bialy");
            Console.WriteLine(pionek.ToString());
            Console.WriteLine(pionek.CzyMozePrzesunac("b5"));

            Figura krol = new Krol("Król", "C4", "Czarny");
            Console.WriteLine(krol.ToString());
            Console.WriteLine(krol.CzyMozePrzesunac("F4"));

            Figura wieza = new Wieza("Wieża", "C2", "Bialy");
            Console.WriteLine(wieza.ToString());
            Console.WriteLine(wieza.CzyMozePrzesunac("G2"));

            Figura skoczek = new Kon("Skoczek", "D4", "Czarny");
            Console.WriteLine(skoczek.ToString());
            Console.WriteLine(skoczek.CzyMozePrzesunac("H4"));
        }
    }
}
