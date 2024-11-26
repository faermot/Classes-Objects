using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskComputer
    {
        string _brand;
        int _ram;
        int _storage;

        public string Brand { get => _brand; set => _brand = value; }
        public int RAM { get => _ram; set => _ram = value; }
        public int Storage { get => _storage; set => _storage = value; }

        public TaskComputer(string brand, int ram, int storage)
        {
            Brand = brand;
            RAM = ram;
            Storage = storage;
        }

        public void UpgradeRAM()
        {
            RAM *= 2;
        }

        public void Print() 
        {
            Console.WriteLine($"Компьютер - {Brand}, Оперативная память - {RAM} гб, Хранилище - {Storage}");
        }
    }
}
