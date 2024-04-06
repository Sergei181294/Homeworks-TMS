
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter an expression: ");
            string input = Console.ReadLine();
            char selectedOperator = ' ';
            char[] operators = new char[] { '+', '-', '*', '/', '√', '%' };
            int operatorIndex = -1;

            try
            {
                for (int i = 0; i < input!.Length; i++)
                {
                    if (operators.Contains(input[i]))
                    {
                        if (input[i] == '√' && i == 0)
                        {
                            selectedOperator = input[i];
                            operatorIndex = i;
                            break;
                        }
                        else if (input[i] == '%' && i != 0 && char.IsDigit(input[i + 1]))
                        {
                            selectedOperator = input[i];
                            operatorIndex = i;
                            break;
                        }
                        else if (i == 0 && char.IsDigit(input[i + 1]))
                        {
                            continue;
                        }
                        else if ((input[i] == '√' && i != 0) || (input[i] == '%' && !(char.IsDigit(input[i + 1]))))
                        {
                            Console.WriteLine("Invalid input, the % or √ operator is not in the correct position. Please try again.");
                            continue;
                        }
                        else
                        {
                            selectedOperator = input[i];
                            operatorIndex = i;
                            break;
                        }
                    }
                }

                if (operatorIndex == -1)
                {
                    Console.WriteLine("Operator not found in the expression. Please try again.");
                    continue;
                }

                double num1, num2;

                if (selectedOperator == '√')
                {
                    num1 = double.Parse(input.Substring(operatorIndex + 1));
                    num2 = 0;
                }
                else
                {
                    num1 = double.Parse(input.Substring(0, operatorIndex));
                    num2 = double.Parse(input.Substring(operatorIndex + 1));
                }

                double result = PerformOperation(selectedOperator, num1, num2);
                double displayResult = result == 0 ? 0 : result;

                Console.WriteLine("Result: " + displayResult);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
    private static double PerformOperation(char selectedOperator, double num1, double num2)
    {
        double result = 0;

        switch (selectedOperator)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("You cannot divide by zero");
                }
                break;
            case '√':
                if (num1 >= 0)
                {
                    result = Math.Sqrt(num1);
                }
                else
                {
                    Console.WriteLine("Can't take the square root of a negative number. Please try again.");
                }
                break;
            case '%':
                result = (num1 / num2) * 100;
                break;
        }
        return result;
    }
}