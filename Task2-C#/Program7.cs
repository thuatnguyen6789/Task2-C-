using System;

namespace Code12Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result;
            number = 5;
            result = 100 * number;
            Console.WriteLine("Result is {0} when 100 is multiplied by {1}", result, number);
            result = 150 / number;
            Console.WriteLine("Result is {0} when 150 is divided by {1}", +result, number);
        }
    }
}
