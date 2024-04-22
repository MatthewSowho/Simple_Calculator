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

    }
}
