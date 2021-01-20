using System;
using Bartolini.Liam._4H.MatriceAzteca.Models;

namespace Bartolini.Liam._4H.MatriceAzteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrice matrix = new Matrice();
            Console.WriteLine("N = 10");
            matrix.ScriviMatrice();
            Console.WriteLine(matrix.StampaMatrice());

            matrix.N = 5;
            Console.WriteLine("N = 5");
            matrix.ScriviMatrice();
            Console.WriteLine(matrix.StampaMatrice());
        }
    }
}