using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTo2
{
    class Program
    {
        #region Variables        
        private static string input;

        private static bool gameOver = false;
        private static string[,] playableNumbersreset =
        {
            {"1","2","3" },
            {"4","5","6" },
            {"7","8","9" },
        };
        private static string[,] playableNumbers =
        {
            {"1","2","3" },
            {"4","5","6" },
            {"7","8","9" },
        };
        static string  whichPlayer = "x";
        private static int numberCheck;
        private static bool noPlayerChange = false;
        #endregion

        static void Main()
        {
            Console.Title = "Tic Tac To";
            while (gameOver == false)
            {
                BuildScreen();
                InputAndCheck();
                CheckForWin();
                TieReset();
            }
        }

        private static void TieReset()
        {
            if (playableNumbers[0, 0] != "1" &&
                playableNumbers[0, 1] != "2" &&
                playableNumbers[0, 2] != "3" &&
                playableNumbers[1, 0] != "4" &&
                playableNumbers[1, 1] != "5" &&
                playableNumbers[1, 2] != "6" &&
                playableNumbers[2, 0] != "7" &&
                playableNumbers[2, 1] != "8" &&
                playableNumbers[2, 2] != "9")
            {
                ResetTheGame();


            }
        }

        private static void CheckForWin()
        {
            if (playableNumbers[0, 0] == playableNumbers[0, 1] &&
                playableNumbers[0, 0] == playableNumbers[0, 2])
            {
                VictorySetup();
            }
            else if (playableNumbers[0, 0] == playableNumbers[1, 0] &&
               playableNumbers[0, 0] == playableNumbers[2, 0])
            {
                VictorySetup();
            }
            else if (playableNumbers[1, 0] == playableNumbers[1, 1] &&
               playableNumbers[1, 0] == playableNumbers[1, 2])
            {
                VictorySetup();
            }
            else if (playableNumbers[2, 0] == playableNumbers[2, 1] &&
               playableNumbers[2, 0] == playableNumbers[2, 2])
            {
                VictorySetup();
            }
            else if (playableNumbers[0, 1] == playableNumbers[1, 1] &&
               playableNumbers[0, 1] == playableNumbers[2, 1])
            {
                VictorySetup();
            }
            else if (playableNumbers[0, 2] == playableNumbers[1, 2] &&
               playableNumbers[0, 2] == playableNumbers[2, 2])
            {
                VictorySetup();
            }
            else if (playableNumbers[0, 0] == playableNumbers[1, 1] &&
               playableNumbers[0, 0] == playableNumbers[2, 2])
            {
                VictorySetup();
            }
            else if (playableNumbers[0, 2] == playableNumbers[1, 1] &&
               playableNumbers[0, 2] == playableNumbers[2, 0])
            {
                VictorySetup();
            }
        }

        private static void VictorySetup()
        {
            BuildScreen();
            PlayerChange();
            Console.WriteLine("Player " + whichPlayer + " is the WINNER!!!!!");
            Console.ReadKey();
            gameOver = true;
        }

        private static void InputAndCheck()
        {
            input = Console.ReadLine();
            switch (input)
            {
                case "q":
                    gameOver = true;
                    break;
                case "1":
                    if (playableNumbers[0, 0] == "1")
                    {
                        playableNumbers[0, 0] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "2":
                    if (playableNumbers[0, 1] == "2")
                    {
                        playableNumbers[0, 1] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "3":
                    if (playableNumbers[0, 2] == "3")
                    {
                        playableNumbers[0, 2] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "4":
                    if (playableNumbers[1, 0] == "4")
                    {
                        playableNumbers[1, 0] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "5":
                    if (playableNumbers[1, 1] == "5")
                    {
                        playableNumbers[1, 1] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "6":
                    if (playableNumbers[1, 2] == "6")
                    {
                        playableNumbers[1, 2] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "7":
                    if (playableNumbers[2, 0] == "7")
                    {
                        playableNumbers[2, 0] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "8":
                    if (playableNumbers[2, 1] == "8")
                    {
                        playableNumbers[2, 1] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "9":
                    if (playableNumbers[2, 2] == "9")
                    {
                        playableNumbers[2, 2] = whichPlayer;
                    }
                    else
                    {
                        BadChoice();
                    }
                    break;
                case "r":
                    ResetTheGame();
                    noPlayerChange = true;
                    break;
                default:
                    break;
            }
            if (noPlayerChange == false)
            {
                PlayerChange();
            }
            else
            {
                noPlayerChange = false;
            }
        }

        private static void PlayerChange()
        {
            if (whichPlayer == "x")
            {
                whichPlayer = "o";
            }
            else
            {
                whichPlayer = "x";
            }
        }

        private static void ResetTheGame()
        {
            playableNumbers[0, 0] = playableNumbersreset[0, 0];
            playableNumbers[0, 1] = playableNumbersreset[0, 1];
            playableNumbers[0, 2] = playableNumbersreset[0, 2];
            playableNumbers[1, 0] = playableNumbersreset[1, 0];
            playableNumbers[1,1] = playableNumbersreset[1,1];
            playableNumbers[1,2] = playableNumbersreset[1,2];
            playableNumbers[2, 0] = playableNumbersreset[2, 0];
            playableNumbers[2,1] = playableNumbersreset[2,1];
            playableNumbers[2,2] = playableNumbersreset[2,2];
            whichPlayer = "x";
        }

        private static void BadChoice()
        {
            Console.WriteLine("that Choice has Been Taken already");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            noPlayerChange = true;
        }

        private static void BuildScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic-Tac-To");
            Console.WriteLine("to quit at any time type q");
            Console.WriteLine("To restart type r");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + playableNumbers[0, 0] + "  |  " + playableNumbers[0, 1] + "  |  " + playableNumbers[0, 2] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + playableNumbers[1, 0] + "  |  " + playableNumbers[1, 1] + "  |  " + playableNumbers[1, 2] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + playableNumbers[2, 0] + "  |  " + playableNumbers[2, 1] + "  |  " + playableNumbers[2, 2] + "  ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("Please Select a Place by Number: ");
        }
    }
}
