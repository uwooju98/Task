using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal class ComputerPlay
    {
        public static bool computerSwitch = false;

        public static bool[] computerSelet = new bool[9];

        public static void ComputerTurn()
        {
            ShowComputer();

            if (Lobby.difficulty == 1)
            {
                Easy();
            }
            else if (Lobby.difficulty == 2)
            {
                Nomal();
            }
            else
            {
                Hard();
            }

            PlayerPlay.playerSwitch = true;
            computerSwitch = false;
        }
        public static void Easy()
        {
            do
            {
                int selet = Random.Shared.Next(1, 10);

                if (computerSelet[selet - 1] || PlayerPlay.playerSelet[selet - 1])
                {
                    continue;
                }
                else
                {
                    computerSelet[selet - 1] = true;
                    computerSwitch = false;
                    PlayerPlay.playerSwitch = true;
                    Console.Clear();
                }
            } while (computerSwitch);
        }

        public static void Nomal()
        {

        }

        public static void Hard()
        {

        }

        public static void ShowComputer()
        {
            Console.Clear();
            Play.PlayBoard();
            Console.WriteLine();
            Console.Write("              [컴퓨터]의 차례입니다 컴퓨터가 선택 하는 중");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.WriteLine(".");
            Thread.Sleep(300);
            Console.Write("                                      ");
        }

    }
}
