using Advanced_Gold_Lotto_Checker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advanced_Gold_Lotto_Checker {
    class Program {
        static void Main() {
            const int NUMBER_OF_ROWS = 12;
            const int LOTTO_NO_MIN = 1;
            const int LOTTO_NO_MAX = 46;

            int[][] lottoNumbers ={ 
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6] 
                              };

            int[] drawNumbers = new int[8];

            DisplayTitle();
            DrawLottoNumbers(lottoNumbers, LOTTO_NO_MIN, LOTTO_NO_MAX, NUMBER_OF_ROWS);
            DrawWinningNumbers(drawNumbers, LOTTO_NO_MIN, LOTTO_NO_MAX);
            CheckNumbers(lottoNumbers, drawNumbers);

            ExitProgram();
        }

        /// <summary>
        /// Displays a welcome message for Advanced Gold Lotto Checker
        /// </summary>
        static void DisplayTitle()
        {
            Console.WriteLine("\n\n\tWelcome to Advanced Gold Lotto Checker\n\n\n");
        }//end DisplayTitle

        /// <summary>
        /// Generates a jagged array of random and unique numbers
        /// which represent a player's choice of lotto numbers.
        /// </summary>
        /// <param name="lottoNumbers">A jagged array of numbers which represent a player's choice of lotto numbers.</param>
        /// <param name="minRange">A number which represents a lotto game's minimum number range.</param>
        /// <param name="maxRange">A number which represents a lotto game's maximum number range.</param>
        /// <param name="gameNo">A number which represents the current game being checked.</param>
        static void DrawLottoNumbers(int[][] lottoNumbers, int minRange, int maxRange, int gameNo) {
            Random RNGesus = new Random();
            int number = 0;
            int j;

            for (int i = 0; i < lottoNumbers.Length; i++) {                
                for (j = 0; j < lottoNumbers[i].Length; j++) {
                    number = RNGesus.Next(minRange, maxRange);

                    while(lottoNumbers[i].HasNumber(number)) {
                        number = RNGesus.Next(minRange, maxRange);
                    }
                    lottoNumbers[i][j] = number;
                }                
            }

            DisplayLottoNumbers(lottoNumbers);
        }//end DrawLottoNumbers
        
        /// <summary>
        /// Generates an array of random and unique numbers
        /// which represent a lotto game's winning (first six numbers) and supplementary numbers.
        /// </summary>
        /// <param name="drawNumbers">An array of numbers which represents a game's winning numbers.</param>
        /// <param name="minRange">A number which represents a lotto game's minimum number range.</param>
        /// <param name="maxRange">A number which represents a lotto game's maximum number range.</param>
        static void DrawWinningNumbers(int[] drawNumbers, int minRange, int maxRange) {
            Random RNGesus = new Random();
            int number;

            for (int i = 0; i < drawNumbers.Length; i++) {
                number = RNGesus.Next(minRange, maxRange);
                
                while (drawNumbers.HasNumber(number)) {
                    number = RNGesus.Next(minRange, maxRange);
                }

                drawNumbers[i] = number;
            }

            DisplayDrawNumbers(drawNumbers);
        }//end DrawWinningNumbers

        /// <summary>
        /// Displays a jagged array of random and unique numbers
        /// which represent a player's choice of lotto numbers.
        /// </summary>
        /// <param name="lottoNumbers">A jagged array of numbers which represent a player's choice of lotto numbers.</param>
        static void DisplayLottoNumbers(int[][] lottoNumbers) {
            int gameCounter = 1;
            
            Console.WriteLine("Your lotto numbers are:\n");

            foreach (int[] numberSet in lottoNumbers) {
                Array.Sort(numberSet);

                Console.Write("Game   {0}:", gameCounter);

                foreach (int number in numberSet) {
                    Console.Write("{0,5}", number);
                }

                Console.WriteLine("\n");

                gameCounter++;
            }
        }//end DisplayLottoNumbers

        /// <summary>
        /// Displays an array of random and unique numbers
        /// which represent a lotto game's winning (first six numbers) and complementary numbers.
        /// </summary>
        /// <param name="drawNumbers">An array of numbers which represents a game's winning numbers.</param>
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
        /// <param name="gameNo">A number which represents the current game being checked.</param>
        /// <param name="winningNoCounter">A number which represents how many winning numbers were found for a particular game.</param>
        /// <param name="supplementaryNoCounter">A number which represents how many complementary numbers were found for a particular game</param>
        static void DisplayGameResults(int gameNo, int winningNoCounter, int supplementaryNoCounter) {
            Console.WriteLine("\tFound {0} winning numbers and {1} supplementary numbers in Game {2}\n\n\n",
                winningNoCounter,
                supplementaryNoCounter,
                gameNo
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

    } //end class Program
}
