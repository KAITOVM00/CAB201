using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2_a
{
    public static class ExtensionMethods
    {
        public static double[] Reverse(this double[] numbers, int start, int finish)
        {
            int n = finish - start + 1;
            int firstIndex = start;
            int secondIndex = finish;
            int range = n / 2;

            for (int i = 0; i < range; i++)
            {
                numbers.Swap(firstIndex, secondIndex);
                firstIndex++;
                secondIndex--;
            }

            return numbers;
        }

        public static double[] Swap(this double[] numbers, int oneIndex, int otherIndex)
        {
            double temp = numbers[oneIndex];
            numbers[oneIndex] = numbers[otherIndex];
            numbers[otherIndex] = temp;

            return numbers;
        }
    }
}
