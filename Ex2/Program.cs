using System;
using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    class Program
    {

        
        static void Main(string[] args)
        {
            void Compare(int x)
            {
                if (x > 5 & x <10)
                {
                    Console.WriteLine($"Число больше 5 и меньше 10");
                }               
                else
                {
                    Console.WriteLine($"неизвестное число");
                }
            }
            Console.WriteLine("Введите число");
            var stringNumber = Console.ReadLine();
            int numericNumber;
            bool number = int.TryParse(stringNumber, out numericNumber);

            while (numericNumber == 0)
            {               
                Console.WriteLine("Некорректный символ, введите число:");
                stringNumber = Console.ReadLine();
                number = int.TryParse(stringNumber, out numericNumber);
            }
            Compare(numericNumber);
                       
            Console.ReadKey();
            
        }
    }
}
