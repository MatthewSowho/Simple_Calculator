using System;
namespace Simple_Calculator
{
    public class Calc
    {
        public int Add(int x, int y)
        {
            int answer;
            try
            {
                answer = x + y;
                Console.Write("Answer = ");
                Console.Write(answer);
            }
            catch (Exception e)
            {

                throw e;
            }



            return answer;
        }

        public int Subtract(int x, int y)
        {
            int answer = x - y;
            Console.Write("Answer = ");
            Console.Write(answer);
            return answer;
        }

        public int Multiply(int x, int y)
        {
            int answer = x * y;
            Console.Write("Answer = ");
            Console.Write(answer);
            return answer;
        }

        public int Divide(int x, int y)
        {
            int answer = x / y;
            Console.Write("Answer = ");
            Console.Write(answer);
            return answer;
        }

        public double CalculateAverage(double[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array must contain at least one element");
            }

            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }



        public double[] QuadraticEquation(double a, double b, double c)
        {
            double numerator = b * b - (4 * a * c);
            double[] roots;

            if (numerator > 0)
            {
                double root1 = (-b + Math.Sqrt(numerator)) / (2 * a);
                double root2 = (-b - Math.Sqrt(numerator)) / (2 * a);
                roots = new double[] { root1, root2 };
            }
            else if (numerator == 0)
            {
                double root = -b / (2 * a);
                roots = new double[] { root };
            }
            else
            {
                roots = new double[0];
            }

            return roots;
        }



        public double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CircleCircum(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public double CylinderVolume(double radius, double height)
        {
            return Math.PI * radius * radius * height;


        }



        private static readonly string[] Ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private static readonly string[] Teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static readonly string[] Tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private static readonly string[] Thousands = { "", "Thousand", "Million", "Billion", "Trillion" };

        public string ConvertToWords(long number)
        {
            if (number == 0)
                return "Zero";

            string words = "";

            for (int i = 0; number > 0; i++)
            {
                if (number % 1000 != 0)
                    words = ConvertHundreds(number % 1000) + Thousands[i] + " " + words;

                number /= 1000;
            }

            return words.Trim();
        }

        private static string ConvertHundreds(long number)
        {
            string words = "";

            if (number >= 100)
            {
                words += Ones[number / 100] + " Hundred ";
                number %= 100;
            }

            if (number >= 10 && number <= 19)
            {
                words += Teens[number % 10] + " ";
            }
            else
            {
                words += Tens[number / 10] + " ";
                words += Ones[number % 10] + " ";
            }

            return words;
        }

        public int CurrentAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age;

        }

        public int NumberOfDays(DateTime one, DateTime two)
        {
            TimeSpan x = one - two;
            int days = (int)x.TotalDays;

            return Math.Abs(days);



        }

        public void LeapYear(int year)
        {

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("This is a leap year");
            }

            else if (year % 400 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }

        //public double GPA(double score1, double score2, double score3, double score4, int unit1, int unit2, int unit3, int unit4)
        //{
        //    double GPA = (score1 + score2 + score3 + score4) / (unit1 + unit2 + unit3 + unit4);
        //    return GPA;
        //}


       public List<Courses> course = new List<Courses>();

        public double GPA(double totalScore , double totalUnits)
        {
            double GPA = totalScore / totalUnits;
            return GPA;
        }

        
        //public void CalculateGP(List<Course> courses)

        //    cousess

        // Number to Word
        // Word to Number
        // Birthday Calculator(1990)
        // Number of Days from a Date to Another date.
        // Leap year calculator








    }
}