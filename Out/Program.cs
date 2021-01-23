using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;  // Out Keyword ref keyword dan farkı  ilk değerinde set edilmez.
            int number2 = 100;
            var result2 = Add(out number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }


        static int Add(out int number1, int number2)
        {
            number1 = 30;

            return (number1 + number2);
        }
    }
}
