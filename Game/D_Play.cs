using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal class Play
    {
        public static bool playerWin = false;
        public static bool computerWin = false;

        public static void Playing()
        {
            for (int i = 0; i < 9;)
            {
                Console.Clear();
                PlayBoard();
                if (PlayerPlay.playerSwitch == true)
                {
                    PlayerPlay.PlayerTurn();
                    if (PlayerWinCheck())
                    {
                        playerWin = true;
                        break;
                    }
                    Console.Clear();
                    i++;
                    if (i == 9)
                    {
                        break;
                    }
                }
                
                
                if (ComputerPlay.computerSwitch == true)
                {
                    ComputerPlay.ComputerTurn();
                    if (ComputerWinCheck())
                    {
                        computerWin = true;
                        break;
                    }
                    Console.Clear();
                    i++;
                    if (i == 9)
                    {
                        break;
                    }
                }
            }
        }

        
        public static bool PlayerWinCheck()
        {
            if (PlayerPlay.playerSelet[0] && PlayerPlay.playerSelet[1] && PlayerPlay.playerSelet[2])
            {
                return true;
            }    
            else if (PlayerPlay.playerSelet[3] && PlayerPlay.playerSelet[4] && PlayerPlay.playerSelet[5])
            {
                return true;
            }
            else if (PlayerPlay.playerSelet[6] && PlayerPlay.playerSelet[7] && PlayerPlay.playerSelet[8])
            {
                return true;
            }
            else if (PlayerPlay.playerSelet[0] && PlayerPlay.playerSelet[3] && PlayerPlay.playerSelet[6])
            {
                return true;
            }
            else if (PlayerPlay.playerSelet[1] && PlayerPlay.playerSelet[4] && PlayerPlay.playerSelet[7])
            {
                return true;
            }
            else if (PlayerPlay.playerSelet[2] && PlayerPlay.playerSelet[5] && PlayerPlay.playerSelet[8])
            {
                return true;
            }
            else if (PlayerPlay.playerSelet[0] && PlayerPlay.playerSelet[4] && PlayerPlay.playerSelet[8])
            {
                return true;
            }
            else if (PlayerPlay.playerSelet[2] && PlayerPlay.playerSelet[4] && PlayerPlay.playerSelet[6])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ComputerWinCheck()
        {
            if (ComputerPlay.computerSelet[0] && ComputerPlay.computerSelet[1] && ComputerPlay.computerSelet[2])
            {
                return true;
            }
            else if (ComputerPlay.computerSelet[3] && ComputerPlay.computerSelet[4] && ComputerPlay.computerSelet[5])
            {
                return true;
            }
            else if (ComputerPlay.computerSelet[6] && ComputerPlay.computerSelet[7] && ComputerPlay.computerSelet[8])
            {
                return true;
            }
            else if (ComputerPlay.computerSelet[0] && ComputerPlay.computerSelet[3] && ComputerPlay.computerSelet[6])
            {
                return true;
            }
            else if (ComputerPlay.computerSelet[1] && ComputerPlay.computerSelet[4] && ComputerPlay.computerSelet[7])
            {
                return true;
            }
            else if (ComputerPlay.computerSelet[2] && ComputerPlay.computerSelet[5] && ComputerPlay.computerSelet[8])
            {
                return true;
            }
            else if (ComputerPlay.computerSelet[0] && ComputerPlay.computerSelet[4] && ComputerPlay.computerSelet[8])
            {
                return true;
            }
            else if (ComputerPlay.computerSelet[2] && ComputerPlay.computerSelet[4] && ComputerPlay.computerSelet[6])
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public static void PlayBoard()
        {

            string[] num = new string[9];

            for (int i = 0; i < 9; i++)
            {
                if (PlayerPlay.playerSelet[i])
                {
                    num[i] = "O";
                }
                else if (ComputerPlay.computerSelet[i])
                {
                    num[i] = "X";
                }
                else
                {
                    num[i] = ".";
                }

            }
            Title.TitleStart();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                           "); Console.Write($"{num[0]} | {num[1]} | {num[2]}"); Console.Write("      "); Console.WriteLine("1 | 2 | 3");
            Console.Write("                           "); Console.Write("---------"); Console.Write("      "); Console.WriteLine("---------");
            Console.Write("                           "); Console.Write($"{num[3]} | {num[4]} | {num[5]}"); Console.Write("      "); Console.WriteLine("4 | 5 | 6");
            Console.Write("                           "); Console.Write("---------"); Console.Write("      "); Console.WriteLine("---------");
            Console.Write("                           "); Console.Write($"{num[6]} | {num[7]} | {num[8]}"); Console.Write("      "); Console.WriteLine("7 | 8 | 9");
            Console.WriteLine();
            Console.WriteLine();
            Title.TitleEnd();
        }
    }
}

