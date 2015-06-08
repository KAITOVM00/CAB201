using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace q2_a
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Reverse(double[] values, int start, int finish)
        {

        }

        public static double[] Swap(double[] numbers, int oneIndex, int otherIndex)
        {
            double temp = numbers[oneIndex];
            numbers[oneIndex] = numbers[otherIndex];
            numbers[otherIndex] = temp;

            return numbers;
        }
    }
}
