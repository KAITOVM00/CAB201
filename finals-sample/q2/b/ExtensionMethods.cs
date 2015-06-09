using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2_b
{
    public static class ExtensionMethods
    {
        public static Boolean IsSorted(this int[] numbers)
        {
            Boolean isAscending = false;
            Boolean isDescending = false;

            List<int> sortedNumbers = new List<int>();
            foreach (int n in numbers)
            {
                sortedNumbers.Add(n);
            }

            sortedNumbers = (sortedNumbers.OrderBy(i => i)).ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == sortedNumbers[i] && i >= numbers.Length - 1)
                {
                    isAscending = true;
                }
                else if (numbers[i] != sortedNumbers[i])
                {
                    isAscending = false;
                    break;
                }
            }
            
            sortedNumbers = (sortedNumbers.OrderByDescending(i => i)).ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == sortedNumbers[i] && i >= numbers.Length - 1)
                {
                    isDescending = true;
                }
                else if (numbers[i] != sortedNumbers[i])
                {
                    isDescending = false;
                    break;
                }
            }

            return isAscending || isDescending;
        }
    }
}
