using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal class Result
    {
        public static void GameEnd()
        {
            Console.Clear();
            Play.PlayBoard();

            if (Play.playerWin)
            {
                Console.WriteLine();
                Console.WriteLine("                              [플레이어]의 승리");
                Console.WriteLine();
                Console.Write("                                      ");
                Thread.Sleep(1000);
            }
            else if (Play.computerWin)
            {
                Console.WriteLine();
                Console.WriteLine("                               [컴퓨터]의 승리");
                Console.WriteLine();
                Console.Write("                                      ");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("                                  [무승부]");
                Console.WriteLine();
                Console.Write("                                      ");
                Thread.Sleep(1000);
            }
        }

        public static bool ReStart()
        {

            bool[] playerRestart = new bool[9];
            bool[] computerRestart = new bool[9];

            while (true)
            {
                Console.Clear();
                Play.PlayBoard();
                Console.WriteLine();
                Console.WriteLine("                        다시 플레이하시겠습니까? [Y / N]");
                Console.WriteLine();
                Console.Write("                                      ");
                string input = Console.ReadLine();
                Console.Write("                                      ");


                if (input.ToUpper() == "Y")
                {
                    Lobby.difficulty = 0;
                    Play.playerWin = false;
                    Play.computerWin = false;
                    PlayerPlay.playerSwitch = true;
                    ComputerPlay.computerSwitch = false;
                    PlayerPlay.playerSelet = playerRestart;
                    ComputerPlay.computerSelet = computerRestart;
                    return true;
                }
                else if (input.ToUpper() == "N")
                {
                    return false;
                }
                else
                {
                    Console.Clear();
                    Play.PlayBoard();
                    Console.WriteLine();
                    Console.WriteLine("                            [Y / N]을 입력해 주세요");
                    Console.WriteLine();
                    Console.Write("                                      ");
                    Thread.Sleep(1200);
                }
            }

        }
    }
}
