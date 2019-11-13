using System;

namespace c_sharp_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gamePlay = "";

            do
            {
                Console.WriteLine("Pick an opperand, to end the game enter: #");
                String userOp = Console.ReadLine();

                Console.WriteLine(" ");

                gamePlay = userOp;

                if (userOp == "#")
                {
                    Console.WriteLine("Goodbye");
                }
                else { 
                Console.WriteLine("Pick your first number");
                String num1 = Console.ReadLine();

                Console.WriteLine("Pick your second number");
                String num2 = Console.ReadLine();
                Console.WriteLine(" ");

                decimal conA = decimal.Parse(num1);

                decimal conB = decimal.Parse(num2);

                Console.WriteLine("Result: ");
                Console.WriteLine(Calculate(conA, conB, userOp));
                Console.WriteLine(" ");
                }
            } while (gamePlay != "#");
        }

         static decimal Calculate(decimal a, decimal b, string operand)
        {
            string caseSwitch = operand;
            
            switch (caseSwitch)
            {
                case "*":
                    return a * b;
                case "+":
                    return a + b;
                case "/":
                    return a / b;
                case "-":
                    return a - b;
                case "%":
                    return a % b;
                default:
                    return 404;
            }
        }
    }
}
