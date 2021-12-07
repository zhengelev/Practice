using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Dynamic;

namespace FreePractice
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 21, 1, 12, 15 };            
            int CalculateTheDifference(int[] inputArray)
            {
                int[] result = new int[inputArray.Length - 1];
                for (int i = 1, j = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] >= inputArray[j])
                    {
                        result[j] = inputArray[i] - inputArray[j];
                        j++;
                    }
                    else if (inputArray[i] < inputArray[j])
                    {
                        result[j] = inputArray[j] - inputArray[i];
                        j++;
                    }

                }
                for (int i = 1; i < result.Length; i++)
                {
                    if (result[i - 1] > result[i])
                    {
                        result[i] = result[i - 1];
                    }
                }
                return result[result.Length - 1];
            }
            
            Console.WriteLine(CalculateTheDifference(numbers));            
            int[] n = { -25, 306, 44, -89, -73, 159, 998, -2 };
            Console.WriteLine(CalculateTheDifference(n));

        }
       
    }
                      

}
