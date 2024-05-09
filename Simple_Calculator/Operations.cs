using System;
using System.Diagnostics;

namespace Simple_Calculator
{
   

    public static class Operations
    {
        public static Calc calc = new Calc();
        public static void Begin()
        {
            double ans = 0;
            bool endOfLife = false;
            while (!endOfLife)
            {
            options:
                Console.WriteLine("\n Select an operation \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Divide \n 5.Average \n 6.Sin \n 7.Cos \n 8.Tan \n 9.Square Root \n 10.Quadratic Equation \n 11.Mensuration \n 12.Number to word \n 13.Age Calculator \n 14.Days Between Dates \n 15.Leap Year Calculator \n 16.GPA");
                Console.WriteLine("Type EXIT to close the Calculator");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddOperation();
                        break;

                    case "2":
                        SubtractOperation();
                        break;

                    case "3":
                        MultiplyOperation();
                        break;

                    case "4":
                        DivideOperation();
                        break;

                    case "5":
                        AverageOperation();
                        break;

                    case "6":
                        SinOperation();
                        break;

                    case "7":
                        CosOperation();
                        break;

                    case "8":
                        TanOperation();
                        break;

                    case "9":
                        SquareRootOperation();
                        break;

                    case "10":
                        QuadraticEquationOperation();
                        break;

                    case "11":
                        MensurationOperation();
                        break;

                    case "12":
                        ConvertToWordsOperation();
                        break;

                    case "13":
                        CurrentAgeOperation();
                        break;

                    case "14":
                        DaysOperation();
                        break;

                    case "15":
                        LeapYearOperation();
                        break;

                    case "16":
                        GPAOperation();
                        break;

                    case "EXIT":
                        endOfLife = true;
                        break;


                    default:
                        Console.WriteLine("Input a valid option");
                        goto options;
                }
            }
        }

        public static void AddOperation()
        {
            int x = 0;
            Console.WriteLine("Input two numbers");
            Console.WriteLine("First Number:");
        input:
            try
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("This is not a number");
                goto input;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred. Here is the detail of the error. " + e.Message);
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

        public static void SubtractOperation()
        {
            Console.WriteLine("Input two numbers");
            Console.WriteLine("First Number:");
        input:
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("This is not a number");
                goto input;
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

        public static void MultiplyOperation()
        {
            Console.WriteLine("Input two numbers");
            Console.WriteLine("First Number:");
        input:
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("This is not a number");
                goto input;
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

        public static void DivideOperation()
        {
            Console.WriteLine("Input two numbers");
            Console.WriteLine("First Number:");
        input:
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("This is not a number");
                goto input;
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

        public static void AverageOperation()
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

        public static void SinOperation()
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

        public static void CosOperation()
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

        public static void TanOperation()
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

        public static void SquareRootOperation()
        {
        input:
            Console.WriteLine("Enter a Number");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                goto input;
            }
            double answer = Math.Sqrt(x);
            Console.WriteLine($"Answer: {answer}");

        }

        public static void QuadraticEquationOperation()
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
        }

        public static void MensurationOperation()
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
        }

        public static void ConvertToWordsOperation()
        {
            int number = 0;
            Console.WriteLine("Type a Number");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred. Here is the detail of the error. " + e.Message);
            }

            string answer = calc.ConvertToWords(number);
            Console.WriteLine("Your number in words = " + answer);
        }

        public static void CurrentAgeOperation()

        {
            int birthYear;
        input:
            Console.WriteLine("Input your year of birth");
            try
            {
                birthYear = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occurred. Here is the detail of the error. " + e.Message);
                goto input;
            }

            int age = calc.CurrentAge(birthYear);
            Console.WriteLine("You are " + age + " years old");
        }

        public static void DaysOperation()
        {
            Console.WriteLine("Input the first date in (YYYY-MM-DD) format :");
            DateTime one = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Input the second date  in (YYYY-MM-DD) format :");
            DateTime two = DateTime.Parse(Console.ReadLine());

            int days = calc.NumberOfDays(one, two);
            Console.WriteLine("Difference in days = " + days + " days");
        }

        public static void LeapYearOperation()
        {
        input:
            Console.WriteLine("Type a year");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("This is not a valid year");
                goto input;
            }
            calc.LeapYear(year);

        }

        public static void GPAOperation()
        {
        score1:
            //    Console.WriteLine("Enter your score for Mathemathics");
            //    if (!double.TryParse(Console.ReadLine(), out double score1))
            //    {
            //        Console.WriteLine("Input a valid score");
            //        goto score1;
            //    }
            //    Console.WriteLine("Enter the number of units");
            //    if (!int.TryParse(Console.ReadLine(), out int unit1))
            //    {
            //        Console.WriteLine("Input a valid number of units");
            //        goto score1;
            //    }

            //score2:
            //    Console.WriteLine("Enter your score for Physics");
            //    if (!double.TryParse(Console.ReadLine(), out double score2))
            //    {
            //        Console.WriteLine("Input a valid score");
            //        goto score2;
            //    }
            //    Console.WriteLine("Enter the number of units");
            //    if (!int.TryParse(Console.ReadLine(), out int unit2))
            //    {
            //        Console.WriteLine("Input a valid number of units");
            //        goto score2;
            //    }
            //score3:
            //    Console.WriteLine("Enter your score for Biology");
            //    if (!double.TryParse(Console.ReadLine(), out double score3))
            //    {
            //        Console.WriteLine("Input a valid score");
            //        goto score3;
            //    }
            //    Console.WriteLine("Enter the number of units");
            //    if (!int.TryParse(Console.ReadLine(), out int unit3))
            //    {
            //        Console.WriteLine("Input a valid number of units");
            //        goto score3;
            //    }
            //score4:
            //    Console.WriteLine("Enter your score for Chemistry");
            //    if (!double.TryParse(Console.ReadLine(), out double score4))
            //    {
            //        Console.WriteLine("Input a valid score");
            //        goto score4;
            //    }
            //    Console.WriteLine("Enter the number of units");
            //    if (!int.TryParse(Console.ReadLine(), out int unit4))
            //    {
            //        Console.WriteLine("Input a valid number of units");
            //        goto score4;
            //    }
            //    double result = calc.GPA(score1, score2, score3, score4, unit1, unit2, unit3, unit4);
            //    Console.WriteLine("Your GPA is: " + result);

            Console.WriteLine("Enter the number of courses");
            int noOfCourses= int.Parse(Console.ReadLine());
            Courses course = new Courses();
            for (int count = 0; count < noOfCourses; count++)
            {
                Console.WriteLine("Enter Course " + (count +1)+ " Title");
                string title = Console.ReadLine();
                score:
                Console.WriteLine("Enter Score");
                if(!int.TryParse(Console.ReadLine(), out int score))
                {
                    Console.WriteLine("Enter a valid score");
                    goto score;
                }

            units:
                Console.WriteLine("Enter Number of Units");
                if (!int.TryParse(Console.ReadLine(), out int units))
                {
                    Console.WriteLine("Enter a valid score");
                    goto units;
                }



                Console.WriteLine("Has This Course Been Registered? Type YES");
                string enrolled = Console.ReadLine();

                
                course.CourseTitle = title;
                course.Score = score;
                string grade;
                course.Units = units;

                double totalScore = 0;
                double totalUnits = 0;
                double GPA = 0;

                if (enrolled.ToUpper() == "YES")
                {
                    course.isEnrolled = true;
                   
                }
                else
                {
                    course.isEnrolled = false;
                    
                }
                if (score >= 70)
                {
                    grade = "A";
                }
                else if (score >= 60)
                {
                    grade = "B";
                }
                else if (score >= 50)
                {
                    grade = "C";
                }
                else if (score < 45)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }
                course.Grade = grade;
               
                totalScore += score;
                totalUnits += units;
                course.GPA = calc.GPA(totalScore,totalUnits);
                calc.course.Add(course);
            }
            foreach (var courses in calc.course)
            {
                Console.WriteLine("Title: " + course.CourseTitle + "   Units: " + course.Units + "   Score: " + course.Score + "   Grade: " + course.Grade + "   Status: " + (course.isEnrolled ? "Registered" : "Unregistered"));
            }
            
            Console.WriteLine("Your GPA = " + course.GPA);

        }

        
        
        

        //Course - CourseTitle, Grade, Score, IsEnrolled = true;

        //List<couse> courses = new List<couse>();
        //Course course;
        
        //for(int count = 0; ) {
        //   course = new Course { }
     
        //    COURSES.ADD(course)
        //    }

        //   var obj =  CalculateGP(courses)




    }
}
