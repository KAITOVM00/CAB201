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
            double[] data = { 8.5, 12.0, 23.2, 18.0, 15.5, 5.0, 10.5 };
            OutputData(data);

            data = Reverse(data, 2, 5);
            OutputData(data);

            Console.ReadKey();
        }

        private static double[] Reverse(double[] values, int start, int finish)
        {
            int n = finish - start + 1;
            int firstIndex = start;
            int secondIndex = finish;
            int range = n / 2;

            for (int i = 0; i < range; i++)
            {
                values.Swap(firstIndex, secondIndex);
                firstIndex++;
                secondIndex--;
            }

            return values;
        }

        private static void OutputData(double[] numbers)
        {
            foreach (double n in numbers)
            {
                Console.Write(n.ToString() + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
