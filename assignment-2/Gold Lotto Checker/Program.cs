using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Lotto_Checker {
    
    class Program {
        
        static void Main() {
            int[][] lottoNumbers = {
                             new int [] { 4, 7, 19, 23, 28, 36},
                             new int [] { 14, 18, 26, 34, 38, 45},
                             new int [] { 8, 10,11, 19, 28, 30},
                             new int [] { 15, 17, 19, 24, 43, 44},
                             new int [] { 10, 27, 29, 30, 32, 41},
                             new int [] { 9, 13, 26, 32, 37,  43},
                             new int [] { 1, 3, 25, 27, 35, 41},
                             new int [] { 7, 9, 17, 26, 28, 44},
                             new int [] { 17, 18, 20, 28, 33, 38}
            };

            int[] drawNumbers = new int[] { 44, 9, 17, 43, 26, 7, 28, 19 };

            DisplayTitle();
            DisplayLottoNumbers(lottoNumbers);
            DisplayDrawNumbers(drawNumbers);
            CheckNumbers(lottoNumbers, drawNumbers);

            ExitProgram();
        }//end Main       

        /// <summary>
        /// Displays a welcome message for Gold Lotto Checker
        /// </summary>
        static void DisplayTitle() {
            Console.WriteLine("\n\n\tWelcome to Gold Lotto Checker\n\n\n");
        }//end DisplayTitle

        /// <summary>
        /// Displays a player's list of lotto numbers for each game.
        /// </summary>
        /// <param name="lottoNumbers">A jagged array containing a player's choice of numbers for each game.</param>
        static void DisplayLottoNumbers(int[][] lottoNumbers) {
            int gameCounter = 1;

            Console.WriteLine("Your lotto numbers are:\n");
            
            foreach (int[] numberSet in lottoNumbers) {
                Console.Write("Game   {0}:", gameCounter);

                foreach (int number in numberSet) {
                    Console.Write("{0,5}", number);
                }

                Console.WriteLine("\n");

                gameCounter++;
            }
        }//end DisplayLottoNumbers

        /// <summary>
        /// Displays a list of winning and supplementary lotto numbers that the game has picked.
        /// </summary>
        /// <param name="drawNumbers">An array of numbers that the game has drawn.</param>
        static void DisplayDrawNumbers(int[] drawNumbers) {
            Console.WriteLine("\n\nLotto draw numbers are:\n");

            foreach (int number in drawNumbers) {
                Console.Write("{0,5}", number);
            }

            Console.WriteLine("\n\n");
        }//end DisplayDrawNumbers

        /// <summary>
        /// Displays how many winning and supplementary numbers were found for a particular lotto game.
        /// </summary>
        /// <param name="gameNumber">A number the current game.</param>
        /// <param name="winningNoCounter">A number indicating how many winnings numbers were found in a particular game.</param>
        /// <param name="supplementaryNoCounter">A number indicating how many supplementary numbers were found in a particular game.</param>
        static void DisplayGameResults(int gameNumber, int winningNoCounter, int supplementaryNoCounter) {
            Console.WriteLine("\tFound {0} winning numbers and {1} supplementary numbers in Game {2}\n\n\n",
                winningNoCounter,
                supplementaryNoCounter,
                gameNumber
            );
        }//end DisplayGameResults

        /// <summary>
        /// Compares a player's lotto numbers to the numbers drawn by the game.
        /// </summary>
        /// <param name="lottoNumbers">Array of arrays containing a player's lotto numbers per game.</param>
        /// <param name="drawNumbers">Array of integers that the game has picked.</param>
        static void CheckNumbers(int[][] lottoNumbers, int[] drawNumbers) {
            int winningNoCounter = 0;
            int supplementaryNoCounter = 0;
            int gameCounter = 1;

            for (int i = 0; i < lottoNumbers.Length; i++) {
                for (int j = 0; j < lottoNumbers[i].Length; j++) {
                    for (int k = 0; k < drawNumbers.Length; k++) {
                        if (lottoNumbers[i][j] == drawNumbers[k]) {
                            if (k <= 5) {
                                winningNoCounter++;
                                break;
                            } else {
                                supplementaryNoCounter++;
                                break;
                            }
                        }
                    }
                }

                DisplayGameResults(gameCounter, winningNoCounter, supplementaryNoCounter);

                winningNoCounter = 0;
                supplementaryNoCounter = 0;
                gameCounter++;
            }
        }//end PlayGame

        /// <summary>
        /// Exits the program.
        /// </summary>
        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram

    }//end class Program
}
