using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXZAM
{
    class Pocuda : Tovar
    {
        private double weight;
        private int quantity;

        public double Weight { get => weight; set => weight = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Pocuda(string name, double price, double weight, int quantity) : base(name, price)
        {
            this.Weight = weight;
            this.Quantity = quantity;
        }

        public override double CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Вес (кг): {Weight}\nКоличество: {Quantity}\nИтоговая стоимость: {CalcSum()}");
        }
    }
}
