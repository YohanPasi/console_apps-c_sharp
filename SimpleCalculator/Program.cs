namespace Calculator
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("        -----------------Simple Calculator-----------------        ");
            Console.WriteLine("--------------------------------------------------------------------\n");

            Console.Write("Enter First Number: ");
            if (!int.TryParse(Console.ReadLine(), out var number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter Second Number: ");
            if (!int.TryParse(Console.ReadLine(), out var number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the operation (+, -, *, /, %): ");
            var type = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(type) || type.Length != 1 || "+-*/%".IndexOf(type[0]) == -1)
            {
                Console.WriteLine("Invalid operation. Please enter one of (+, -, *, /, %).");
                return;
            }

            int amount = 0;
            switch (type[0])
            {
                case '+':
                    amount = number1 + number2;
                    break;
                case '-':
                    amount = number1 - number2;
                    break;
                case '*':
                    amount = number1 * number2;
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return;
                    }
                    amount = number1 / number2;
                    break;
                case '%':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return;
                    }
                    amount = number1 % number2;
                    break;
            }

            Console.WriteLine($"Result: {amount}");
        }
    }
}
