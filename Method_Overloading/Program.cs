using System;

namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number");
            var y = int.Parse(Console.ReadLine());

            var answer = Add(x, y);

            Console.WriteLine(answer);

            Console.WriteLine("Give me a decimal number");
            var a = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Give me a second decimal number");
            var b = Decimal.Parse(Console.ReadLine());
            
            var decimalAnswer = Add(a, b);

            Console.WriteLine(decimalAnswer);

            var thirdanswer = Add(2, 3, true);

            Console.WriteLine(thirdanswer);

            
        }

            public static int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            public static decimal Add(decimal num1, decimal num2)
            {
                return num1 + num2;
            }

        public static string Add(int num1, int num2, bool isCheck)
        {

            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum ==1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return string.Empty;
            }

    }   }
}
