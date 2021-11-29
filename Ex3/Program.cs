using System;
using System.Security.Cryptography;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            string[] operations = { "Сложение", "Вычитание", "Умножение" };
            var inputNumber = Console.ReadLine();
            switch (inputNumber)
                {
                    case "1":
                        Console.WriteLine("Сложение");
                        break;

                    case "2":
                        Console.WriteLine("Вычитание");
                        break;
                    case "3":
                        Console.WriteLine("Умножение");
                        break;
                default:
                    Console.WriteLine("Операция не определена");
                    break;
                }
                                    
        }
                        
        
    }
}
