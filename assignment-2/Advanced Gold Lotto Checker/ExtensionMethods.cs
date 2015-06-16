using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Gold_Lotto_Checker
{
    /// <summary>
    /// Contains extension methods
    /// </summary>
    public static class ExtensionMethods {
        /// <summary>
        /// Checks the given number against the array of int and returns a boolean value.
        /// </summary>
        /// <param name="array">An array of numbers.</param>
        /// <param name="number">A number to check against the array.</param>
        /// <returns>True if the given number currently exists in the array.</returns>
        public static bool HasNumber(this int[] array, int number) {
            bool duplicateExists = false;

            foreach (int element in array) {
                if (number == element) {
                    duplicateExists = true;
                }
                
            }

            return duplicateExists;
        }
    }
}
