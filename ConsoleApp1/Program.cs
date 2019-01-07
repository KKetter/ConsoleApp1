using System;

namespace Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            int answer = 0;

            Console.Write("Please enter the first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter an operand (+, -, /, *): ");
            operand = Console.ReadLine();

            switch (operand)
            {
                case "-":
                    answer = num1 - num2;
                    Console.WriteLine($"Result: {answer}");
                    break;
                case "+":
                    answer = num1 + num2;
                    Console.WriteLine($"Result: {answer}");
                    break;
                case "/":
                    answer = num1 / num2;
                    Console.WriteLine($"Result: {answer}");
                    break;
                case "*":
                    answer = num1 * num2;
                    Console.WriteLine($"Result: {answer}");
                    break;

                
            }
                Console.ReadLine();

        }
    }
}
