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
                Console.WriteLine("\n Select an operation \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Divide \n 5.Average \n 6.Sin \n 7.Cos \n 8.Tan \n 9.Square Root \n 10.Quadratic Equation \n 11.Mensuration");
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

                else if (option == "10")
                {
                enterCoefficients:
                    Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");
                    Console.WriteLine("Enter the value of a:");
                    if (!double.TryParse(Console.ReadLine(), out double a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for 'a'.");
                        goto enterCoefficients;
                    }

                    Console.WriteLine("Enter the value of b:");
                    if (!double.TryParse(Console.ReadLine(), out double b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for 'b'.");
                        goto enterCoefficients;
                    }

                    Console.WriteLine("Enter the value of c:");
                    if (!double.TryParse(Console.ReadLine(), out double c))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for 'c'.");
                        goto enterCoefficients;
                    }

                    
                    double[] roots = calc.QuadraticEquation(a, b, c);

                    if (roots.Length == 0)
                    {
                        Console.WriteLine("The quadratic equation has no real roots.");
                    }
                    else if (roots.Length == 1)
                    {
                        Console.WriteLine($"The quadratic equation has one real root: {roots[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"The quadratic equation has two real roots: {roots[0]} and {roots[1]}");
                    }

                    goto options; 
                }




                else if (option == "11")
                {
                mensurationOptions:
                    Console.WriteLine("Select a mensuration option:");
                    Console.WriteLine("1. Area of a circle");
                    Console.WriteLine("2. Circumference of a circle");
                    Console.WriteLine("3. Volume of a cylinder");
                    string mensurationOption = Console.ReadLine();
                   

                    if (mensurationOption == "1")
                    {
                        Console.WriteLine("Enter the radius of the circle:");
                    enterRadius:
                        if (!double.TryParse(Console.ReadLine(), out double circleRadius))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for the radius:");
                            goto enterRadius;
                        }
                        double circleArea = calc.CircleArea(circleRadius);
                        Console.WriteLine($"Area of the circle: {circleArea}");
                    }
                    else if (mensurationOption == "2")
                    {
                        Console.WriteLine("Enter the radius of the circle:");
                    enterRadiusCircum:
                        if (!double.TryParse(Console.ReadLine(), out double circleRadiusCircum))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number:");
                            goto enterRadiusCircum;
                        }
                        double circleCircumference = calc.CircleCircum(circleRadiusCircum);
                        Console.WriteLine($"Circumference of the circle: {circleCircumference}");
                    }
                    else if (mensurationOption == "3")
                    {
                        Console.WriteLine("Enter the radius of the cylinder:");
                    enterRadiusCylinder:
                        if (!double.TryParse(Console.ReadLine(), out double cylinderRadius))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number:");
                            goto enterRadiusCylinder;
                        }
                        Console.WriteLine("Enter the height of the cylinder:");
                        if (!double.TryParse(Console.ReadLine(), out double cylinderHeight))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number:");
                            goto enterRadiusCylinder; 
                        }
                        double cylinderVolume = calc.CylinderVolume(cylinderRadius, cylinderHeight);
                        Console.WriteLine($"Volume of the cylinder: {cylinderVolume}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please select a valid mensuration option.");
                        goto mensurationOptions;
                    }

                    goto options;
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
