using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskProduct
    {
        string _name;
        int _price;
        int _quantity;

        public TaskProduct(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public void Print()
        {
            Console.WriteLine($"Продукт -  {Name}, Цена - {Price}, Кол-во - {Quantity}");
        }
        public void ProductAdd(int quantity)
        {
            Quantity += quantity;
        }
        public void ProductSell(int quantity)
        {
            Quantity -= quantity;
        }
    }
}
