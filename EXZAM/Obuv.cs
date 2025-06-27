using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXZAM
{
    class Obuv : Tovar
    {
        private int size;
        private int quantity;

        public int Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Obuv (string name, double price, int size, int quantity) : base(name, price)
        {
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
            Console.WriteLine($"Размер: {Size}\nКоличество: {Quantity}\nИтоговая стоимость: {CalcSum()}");
        }
    }
}
