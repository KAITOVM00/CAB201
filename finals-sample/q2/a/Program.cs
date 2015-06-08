using System;

namespace q2_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = { 8.5, 12.0, 23.2, 18.0, 15.5, 5.0, 10.5 };
            OutputData(data);

            data.Reverse(2, 5);
            OutputData(data);

            Console.ReadKey();
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
