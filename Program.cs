using System;
using System.Security.Cryptography.X509Certificates;

namespace Ex1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            void Compare(int x, int y)
            {
                if (x > y)
                {
                    Console.WriteLine($"{x} больше {y}");
                }
                else if (x < y)
                {
                    Console.WriteLine($"{x} меньше {y}");
                }
                else
                {
                    Console.WriteLine($"{x} равно {y}");
                }
            }
            Console.WriteLine("Введите первое число");
            var stringNumber1 = Console.ReadLine();
            int numericNumber1;
            bool firstNumber = int.TryParse(stringNumber1, out numericNumber1);

            while (numericNumber1 == 0)
            {               
                Console.WriteLine("Некорректный символ, введите число:");
                stringNumber1 = Console.ReadLine();
                firstNumber = int.TryParse(stringNumber1, out numericNumber1);
            }

            Console.WriteLine("Введите второе число");
            var stringNumber2 = Console.ReadLine();
            int numericNumber2;
            bool secondNumber = int.TryParse(stringNumber2, out numericNumber2);

            while (numericNumber2 == 0)
            {
                Console.WriteLine("Некорректный символ, введите число");
                stringNumber2 = Console.ReadLine();
                secondNumber = int.TryParse(stringNumber2, out numericNumber2);                
            }

            Compare(numericNumber1, numericNumber2);

            Console.ReadKey();
            
        }
    }
}
