using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXZAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tovar[] tovary = new Tovar[]
           {
            new Obuv("Туфли", 1200, 39, 2),
            new Odejda("Свитер", 400, "Серый", "S", 5),
            new Pocuda("Казан", 600, 2 , 4)
           };

            Console.WriteLine("Товары:\n");

            tovary.Print();
            Console.ReadKey();
        }
    }
    
}
