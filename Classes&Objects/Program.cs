using Classes_Objects.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Classes_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Задание №1");

                        TaskPerson person = new TaskPerson("Андрей", 17);
                        person.Print();

                        Thread.Sleep(4000);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Задание 2");

                        TaskCar car = new TaskCar("Audi", "Q7", 2020);
                        car.Print();

                        Thread.Sleep(4000);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Задание 3");

                        TaskBook book = new TaskBook("1984", "Джордж Оруэлл", 320);
                        book.Print();

                        Thread.Sleep(4000);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Задание 4");

                        TaskRectangle rectangle = new TaskRectangle(15, 35);
                        rectangle.Calculate();

                        Thread.Sleep(4000);
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Задание 5");

                        TaskCircle circle = new TaskCircle(16);
                        circle.Calculate();

                        Thread.Sleep(4000);
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Задание 6");

                        TaskStudent student = new TaskStudent("Андрей", "C", 205);
                        student.Print();

                        Thread.Sleep(4000);
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Задание 7");

                        TaskEmployee employee = new TaskEmployee("Иван", "Охранник", 58200);
                        employee.Print();

                        employee.UpgradeSalary(30); // %

                        Console.WriteLine("\nПосле повышения:");
                        employee.Print();

                        Thread.Sleep(4000);
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Задание 8");

                        TaskBankAccount bankAccount = new TaskBankAccount(293451, 1849);

                        bankAccount.Print();

                        Console.WriteLine("После пополнения:");

                        bankAccount.TopUp(500);
                        bankAccount.Print();

                        Console.WriteLine("После снятия:");

                        bankAccount.CashOut(1200);
                        bankAccount.Print();

                        Thread.Sleep(8000);
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Задание 9");

                        TaskMovie NewMovie = new TaskMovie("Spider-Man", 10, "5 декабря 2007");
                        NewMovie.Print();

                        Thread.Sleep(4000);
                        break;

                    case "10":
                        Console.Clear();
                        Console.WriteLine("Задание 10");


                        TaskAnimal animal = new TaskAnimal("Волк", "Хищник");
                        animal.Print();

                        Thread.Sleep(4000);
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Задание 11");

                        TaskProduct product = new TaskProduct("Арбуз", 20, 45);
                        product.Print();

                        Console.WriteLine("После добавления: ");
                        product.ProductAdd(10);

                        product.Print();

                        Console.WriteLine("После продажи: ");
                        product.ProductSell(15);

                        product.Print();


                        Thread.Sleep(4000);

                        break;

                    case "12":
                        Console.Clear();
                        Console.WriteLine("Задание 12");
                        Thread.Sleep(4000);
                        break;

                    case "13":
                        Console.Clear();
                        Console.WriteLine("Задание 13");

                        TaskLibrary library = new TaskLibrary();

                        library.Add("sineparbuz");
                        library.Add("5 ночей с мшк фреди фазбер");
                        
                        library.Print();
                        Thread.Sleep(4000);
                        break;
                    case "14":
                        Console.Clear();
                        Console.WriteLine("Задание 14");

                        TaskPoint point = new TaskPoint(15, 35);

                        point.Print();

                        Thread.Sleep(4000);
                        break;

                    case "15":
                        Console.Clear();
                        Console.WriteLine("Задание 15");

                        TaskComputer computer = new TaskComputer("Acer", 16, 512);

                        Console.WriteLine("Компьютер до обновления памяти:");

                        computer.Print();

                        computer.UpgradeRAM();

                        Console.WriteLine("Компьютер после обновления памяти:");

                        computer.Print();

                        Thread.Sleep(4000);
                        break;


                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}
