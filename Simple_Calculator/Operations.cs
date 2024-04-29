
using System;

namespace Simple_Calculator
{
    public static class Operations
    {
        public static void Begin()
        {
            double ans = 0;
            while (true)
            {

            options:
                Console.WriteLine("\n Select an operation \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Divide \n 5.Average \n 6.Sin \n 7.Cos \n 8.Tan \n 9.Square Root \n 10.Quadratic Equation \n 11.Mensuration");
                string option = Console.ReadLine();
                Calc calc = new Calc();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Input two numbers");
                        Console.WriteLine("First Number:");
                    first1:
                        if (!int.TryParse(Console.ReadLine(), out int x1))
                        {
                            Math.Sin(x1);
                            Console.WriteLine("This is not a number");
                            goto first1;
                        }
                        Console.WriteLine("Second Number:");
                    second1:
                        if (!int.TryParse(Console.ReadLine(), out int y1))
                        {
                            Console.WriteLine("This is not a number");
                            goto second1;
                        }
                        calc.Add(x1, y1);
                        break;

                    case "2":
                        Console.WriteLine("Input two numbers");
                        Console.WriteLine("First Number:");
                    first2:
                        if (!int.TryParse(Console.ReadLine(), out int x2))
                        {
                            Console.WriteLine("This is not a number");
                            goto first2;
                        }
                        Console.WriteLine("Second Number:");
                    second2:
                        if (!int.TryParse(Console.ReadLine(), out int y2))
                        {
                            Console.WriteLine("This is not a number");
                            goto second2;
                        }
                        calc.Subtract(x2, y2);
                        break;

                    case "3":
                        Console.WriteLine("Input two numbers");
                        Console.WriteLine("First Number:");
                    first3:
                        if (!int.TryParse(Console.ReadLine(), out int x3))
                        {
                            Console.WriteLine("This is not a number");
                            goto first3;
                        }
                        Console.WriteLine("Second Number:");
                    second3:
                        if (!int.TryParse(Console.ReadLine(), out int y3))
                        {
                            Console.WriteLine("This is not a number");
                            goto second3;
                        }
                        calc.Multiply(x3, y3);
                        break;

                    case "4":
                        Console.WriteLine("Input two numbers");
                        Console.WriteLine("First Number:");
                    first4:
                        if (!int.TryParse(Console.ReadLine(), out int x4))
                        {
                            Console.WriteLine("This is not a number");
                            goto first4;
                        }
                        Console.WriteLine("Second Number:");
                    second4:
                        if (!int.TryParse(Console.ReadLine(), out int y4))
                        {
                            Console.WriteLine("This is not a number");
                            goto second4;
                        }
                        calc.Divide(x4, y4);
                        break;

                    case "5":
                    input5:
                        Console.WriteLine("Enter numbers separated by commas:");
                        string input5 = Console.ReadLine();


                        string[] numberStrings5 = input5.Split(',');
                        double[] numbers5 = new double[numberStrings5.Length];

                        for (int i = 0; i < numberStrings5.Length; i++)
                        {
                            if (!double.TryParse(numberStrings5[i], out numbers5[i]))
                            {
                                Console.WriteLine($"Invalid input: {numberStrings5[i]} is not a valid number.");
                                goto input5;
                            }
                        }

                        double average5 = calc.CalculateAverage(numbers5);
                        Console.WriteLine($"The average is: {average5}");
                        break;

                    case "6":
                    input6:
                        Console.WriteLine("Enter a Number");
                        if (!double.TryParse(Console.ReadLine(), out double x6))
                        {
                            goto input6;
                        }
                        double answer6 = Math.Sin(x6);
                        Console.WriteLine($"Answer: {answer6}");
                        break;

                    case "7":
                    input7:
                        Console.WriteLine("Enter a Number");
                        if (!double.TryParse(Console.ReadLine(), out double x7))
                        {
                            goto input7;
                        }
                        double answer7 = Math.Cos(x7);
                        Console.WriteLine($"Answer: {answer7}");
                        break;

                    case "8":
                    input8:
                        Console.WriteLine("Enter a Number");
                        if (!double.TryParse(Console.ReadLine(), out double x8))
                        {
                            goto input8;
                        }
                        double answer8 = Math.Tan(x8);
                        Console.WriteLine($"Answer: {answer8}");
                        break;

                    case "9":
                    input9:
                        Console.WriteLine("Enter a Number");
                        if (!double.TryParse(Console.ReadLine(), out double x9))
                        {
                            goto input9;
                        }
                        double answer9 = Math.Sqrt(x9);
                        Console.WriteLine($"Answer: {answer9}");
                        ans = answer9;
                        break;

                    case "10":
                    enterCoefficients:
                        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");
                        Console.WriteLine("Enter the value of a:");
                        if (!double.TryParse(Console.ReadLine(), out double a10))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for 'a'.");
                            goto enterCoefficients;
                        }

                        Console.WriteLine("Enter the value of b:");
                        if (!double.TryParse(Console.ReadLine(), out double b10))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for 'b'.");
                            goto enterCoefficients;
                        }

                        Console.WriteLine("Enter the value of c:");
                        if (!double.TryParse(Console.ReadLine(), out double c10))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for 'c'.");
                            goto enterCoefficients;
                        }


                        double[] roots10 = calc.QuadraticEquation(a10, b10, c10);

                        if (roots10.Length == 0)
                        {
                            Console.WriteLine("The quadratic equation has no real roots.");
                        }
                        else if (roots10.Length

 == 1)
                        {
                            Console.WriteLine($"The quadratic equation has one real root: {roots10[0]}");
                        }
                        else
                        {
                            Console.WriteLine($"The quadratic equation has two real roots: {roots10[0]} and {roots10[1]}");
                        }

                        goto options;

                    case "11":
                    mensurationOptions:
                        Console.WriteLine("Select a mensuration option:");
                        Console.WriteLine("1. Area of a circle");
                        Console.WriteLine("2. Circumference of a circle");
                        Console.WriteLine("3. Volume of a cylinder");
                        string mensurationOption = Console.ReadLine();


                        if (mensurationOption == "1")
                        {
                            Console.WriteLine("Enter the radius of the circle:");
                        enterRadius1:
                            if (!double.TryParse(Console.ReadLine(), out double circleRadius1))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number for the radius:");
                                goto enterRadius1;
                            }
                            double circleArea1 = calc.CircleArea(circleRadius1);
                            Console.WriteLine($"Area of the circle: {circleArea1}");
                        }
                        else if (mensurationOption == "2")
                        {
                            Console.WriteLine("Enter the radius of the circle:");
                        enterRadius2:
                            if (!double.TryParse(Console.ReadLine(), out double circleRadiusCircum2))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number:");
                                goto enterRadius2;
                            }
                            double circleCircumference2 = calc.CircleCircum(circleRadiusCircum2);
                            Console.WriteLine($"Circumference of the circle: {circleCircumference2}");
                        }
                        else if (mensurationOption == "3")
                        {
                            Console.WriteLine("Enter the radius of the cylinder:");
                        enterRadius3:
                            if (!double.TryParse(Console.ReadLine(), out double cylinderRadius3))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number:");
                                goto enterRadius3;
                            }
                            Console.WriteLine("Enter the height of the cylinder:");
                            if (!double.TryParse(Console.ReadLine(), out double cylinderHeight3))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number:");
                                goto enterRadius3;
                            }
                            double cylinderVolume3 = calc.CylinderVolume(cylinderRadius3, cylinderHeight3);
                            Console.WriteLine($"Volume of the cylinder: {cylinderVolume3}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Please select a valid mensuration option.");
                            goto mensurationOptions;
                        }

                        goto options;

                    default:
                        Console.WriteLine("Input a valid option");
                        goto options;
                }


            }
        }
    }
}
