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

        private static double[] Reverse(double[] values, int start, int finish)
        {
            int n = finish - start + 1;
            int firstIndex = start;
            int secondIndex = finish;
            int range = n / 2;

            for (int i = 0; i < range; i++)
            {
                Swap(values, firstIndex, secondIndex);
                firstIndex++;
                secondIndex--;
            }

            return values;
        }

        private static double[] Swap(double[] numbers, int oneIndex, int otherIndex)
        {
            double temp = numbers[oneIndex];
            numbers[oneIndex] = numbers[otherIndex];
            numbers[otherIndex] = temp;

            return numbers;
        }
    }
}
