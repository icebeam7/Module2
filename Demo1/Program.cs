using System;

namespace Demo1
{
    class Program
    {
        static void SetValues(int[] numbers)
        {
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                numbers[counter] = counter * 2;
            }
        }

        static void PrintValues(int[] numbers)
        {
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        static void SetX(ref int x)
        {
            x = 10;
        }

        static void Main(string[] args)
        {
            int[] numbersArray = new int[10];
            
            int number = 4;
            //SetX(number);   // Number is sent by value
            SetX(ref number);   // Number is now sent by reference
            Console.WriteLine("Number is " + number);

            SetValues(numbersArray);    // For arrays, they are sent by reference
            PrintValues(numbersArray);

            Console.ReadKey();
        }
    }
}
