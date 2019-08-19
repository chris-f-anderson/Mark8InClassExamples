using System;

namespace AM8_8_19
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(1, 100);
        }

        static void FizzBuzz(int startNumber, int maxNumber)
        {
            if (startNumber % 3 == 0 && startNumber % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (startNumber % 3 == 0)
                Console.WriteLine("Fizz");
            else if (startNumber % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(startNumber);

            if (startNumber == maxNumber)
                return;

            FizzBuzz(startNumber + 1, maxNumber);
        }
    }
}
