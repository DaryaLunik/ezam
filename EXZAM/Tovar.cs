using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXZAM
{
    abstract class Tovar
    {
        private string name;
        private double price;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public Tovar( string name, double price) 
        { 
           this.Name = name;
           this.Price = price;
        }

        public abstract double CalcSum();

        public virtual void Print()
        {
            Console.WriteLine($"Название: {Name}\nЦена за единицу: {Price}");
        }
    }
}
