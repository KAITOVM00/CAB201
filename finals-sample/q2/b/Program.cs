using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
            foreach (int n in numbers)
            {
                Console.Write(n.ToString() + " ");
            }
            Console.WriteLine("\n");
            Console.Write(numbers.IsSorted().ToString());
                        
            Console.ReadKey();
        }
    }
}
