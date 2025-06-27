using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXZAM
{
    internal class Odejda : Tovar
    {
        private string color;
        private string size;
        private int quantity;

        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Odejda(string name, double price, string color, string size, int quantity) : base(name, price)
        {
            this.Color = color;
            this.Size = size;
            this.Quantity = quantity;
        }

        public override double CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Цвет: {Color}\nРазмер: {Size}\nКоличество: {Quantity}\nИтоговая стоимость: {CalcSum()}");
        }
    }
}
