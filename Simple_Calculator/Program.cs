namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ans = 0;
            while (true)
            {
                


            options:
                Console.WriteLine("Select an operation \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Divide \n 5.Average \n 6.Sin \n 7.Cos \n 8.Tan \n 9.Square Root");
                string option = Console.ReadLine();
                Calc calc = new Calc();
                if (option == "1")
                {

                    Console.WriteLine("Input two numbers");
                    Console.WriteLine("First Number:");
                first:
                    if (!int.TryParse(Console.ReadLine(), out int x))
                    {

                        Math.Sin(x);
                        Console.WriteLine("This is not a number");
                        goto first;
                    }
                    Console.WriteLine("Second Number:");
                second:
                    if (!int.TryParse(Console.ReadLine(), out int y))
                    {
                        Console.WriteLine("This is not a number");
                        goto second;
                    }
                    calc.Add(x, y);
                }

                else if (option == "2")
                {
                    Console.WriteLine("Input two numbers");
                    Console.WriteLine("First Number:");
                first:
                    if (!int.TryParse(Console.ReadLine(), out int x))
                    {
                        Console.WriteLine("This is not a number");
                        goto first;
                    }
                    Console.WriteLine("Second Number:");
                second:
                    if (!int.TryParse(Console.ReadLine(), out int y))
                    {
                        Console.WriteLine("This is not a number");
                        goto second;
                    }
                    calc.Subtract(x, y);
                }

                else if (option == "3")
                {
                    Console.WriteLine("Input two numbers");
                    Console.WriteLine("First Number:");
                first:
                    if (!int.TryParse(Console.ReadLine(), out int x))
                    {
                        Console.WriteLine("This is not a number");
                        goto first;
                    }
                    Console.WriteLine("Second Number:");
                second:
                    if (!int.TryParse(Console.ReadLine(), out int y))
                    {
                        Console.WriteLine("This is not a number");
                        goto second;
                    }
                    calc.Multiply(x, y);
                }
                else if (option == "4")
                {
                    Console.WriteLine("Input two numbers");
                    Console.WriteLine("First Number:");
                first:
                    if (!int.TryParse(Console.ReadLine(), out int x))
                    {
                        Console.WriteLine("This is not a number");
                        goto first;
                    }
                    Console.WriteLine("Second Number:");
                second:
                    if (!int.TryParse(Console.ReadLine(), out int y))
                    {
                        Console.WriteLine("This is not a number");
                        goto second;
                    }
                    calc.Divide(x, y);
                }

                else if (option == "5")
                {
                input:
                    Console.WriteLine("Enter numbers separated by commas:");
                    string input = Console.ReadLine();


                    string[] numberStrings = input.Split(',');
                    double[] numbers = new double[numberStrings.Length];

                    for (int i = 0; i < numberStrings.Length; i++)
                    {
                        if (!double.TryParse(numberStrings[i], out numbers[i]))
                        {
                            Console.WriteLine($"Invalid input: {numberStrings[i]} is not a valid number.");
                            goto input;
                        }
                    }

                    double average = calc.CalculateAverage(numbers);
                    Console.WriteLine($"The average is: {average}");
                }

                else if (option == "6")
                {
                input:
                    Console.WriteLine("Enter a Number");
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        goto input;
                    }
                    double answer = Math.Sin(x);
                    Console.WriteLine($"Answer: {answer}");

                }

                else if (option == "7")
                {
                input:
                    Console.WriteLine("Enter a Number");
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        goto input;
                    }
                    double answer = Math.Cos(x);
                    Console.WriteLine($"Answer: {answer}");
                }

                else if (option == "8")
                {
                input:
                    Console.WriteLine("Enter a Number");
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        goto input;
                    }
                    double answer = Math.Tan(x);
                    Console.WriteLine($"Answer: {answer}");
                }

                else if (option == "9")
                {
                input:
                    Console.WriteLine("Enter a Number");
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        goto input;
                    }
                    double answer = Math.Sqrt(x);
                    Console.WriteLine($"Answer: {answer}");
                    ans = answer;
                }


                else
                {
                    Console.WriteLine("Input a valid option");
                    goto options;
                }
                
                
            }
        }
        
            
    }
}
