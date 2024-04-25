using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Calc
    {
        public int Add(int x, int y)
        {
            int answer= x + y;
            Console.Write("Answer = ");
            Console.Write(answer);
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


    }
}
