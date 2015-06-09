using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rainfall = { 15, 0, -53, 5, 2, 9999 };
            Console.Write(AverageRainfall(rainfall).ToString());

            Console.ReadKey();
        }

        private static double AverageRainfall(int[] rainfall)
        {
            List<int> data = new List<int>();

            foreach (int n in rainfall)
            {
                if (n < 0)
                {
                    data.Add(0);
                }
                else if (n == 9999)
                {
                    break;
                }
                else
                {
                    data.Add(n);
                }
            }

            double average = 0;
            foreach (int entry in data)
            {
                average += entry;
            }

            return average / data.Count();
        }
    }
}
