using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal class PlayerPlay
    {
        public static bool playerSwitch = true;

        public static bool[] playerSelet = new bool[9];

        public static void PlayerTurn()
        {
            do
            {
                Console.Clear();
                Play.PlayBoard();
                Console.WriteLine();
                Console.WriteLine("            [플레이어]의 차례입니다 숫자를 입력해 주세요 [ 1 ~ 9 ]");
                Console.WriteLine();
                Console.Write("                                      ");
                string index = Console.ReadLine();

                bool input = int.TryParse(index, out int selet);

                if (!input)
                {
                    playerSwitch = true;
                    Console.Clear();
                    Play.PlayBoard();
                    Console.WriteLine();
                    Console.WriteLine("             [올바른 입력이 아닙니다 숫자[1 ~ 9]를 입력해주세요]");
                    Console.WriteLine();
                    Console.Write("                                       ");
                    Thread.Sleep(1200);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Clear();
                    Play.PlayBoard();
                }
                else if (!(selet > 0 && selet < 10))
                {
                    playerSwitch = true;
                    Console.Clear();
                    Play.PlayBoard();
                    Console.WriteLine();
                    Console.WriteLine("             [올바른 입력이 아닙니다 숫자[1 ~ 9]를 입력해주세요]");
                    Console.WriteLine();
                    Console.Write("                                      ");
                    Thread.Sleep(1200);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Clear();
                    Play.PlayBoard();
                }
                else
                {
                    if (ComputerPlay.computerSelet[selet - 1] || playerSelet[selet - 1])
                    {
                        playerSwitch = true;
                        Console.Clear();
                        Play.PlayBoard();
                        Console.WriteLine();
                        Console.WriteLine("                   [이미 선택한 자리는 선택할 수 없습니다]");
                        Console.WriteLine();
                        Console.Write("                                      ");
                        Thread.Sleep(1200);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Clear();
                        Play.PlayBoard();
                    }
                    else
                    {
                        playerSelet[selet - 1] = true;
                        playerSwitch = false;
                        ComputerPlay.computerSwitch = true;
                        Console.Clear();
                    }
                }
            } while (playerSwitch);
        }
    }
}
/*
 *             Program.Title();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("            ┏ ━ ┓ ┃ ┏ ━ ┓ ┃ ┏ ━ ┓");
            Console.WriteLine("            ┃   ┃ ┃ ┃   ┃ ┃ ┃   ┃");
            Console.WriteLine("            ┗ ━ ┛ ┃ ┗ ━ ┛ ┃ ┗ ━ ┛");
            Console.WriteLine("            ━━━━━━╋━━━━━━━╋━━━━━━");
            Console.WriteLine("            ┏ ━ ┓ ┃ ┏ ━ ┓ ┃ ┏ ━ ┓");
            Console.WriteLine("            ┃   ┃ ┃ ┃   ┃ ┃ ┃   ┃");
            Console.WriteLine("            ┗ ━ ┛ ┃ ┗ ━ ┛ ┃ ┗ ━ ┛");
            Console.WriteLine("            ━━━━━━╋━━━━━━━╋━━━━━━");
            Console.WriteLine("            ┏ ━ ┓ ┃ ┏ ━ ┓ ┃ ┏ ━ ┓");
            Console.WriteLine("            ┃   ┃ ┃ ┃   ┃ ┃ ┃   ┃");
            Console.WriteLine("            ┗ ━ ┛ ┃ ┗ ━ ┛ ┃ ┗ ━ ┛");
            Console.WriteLine();
            Console.WriteLine();
            Program.TitleTo();

            Program.Title();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("            ┏   ┓ ┃ ┏   ┓ ┃ ┏   ┓                 ┃       ┃      ");
            Console.WriteLine("                  ┃       ┃                   ①  ┃   ②  ┃   ③ ");
            Console.WriteLine("            ┗   ┛ ┃ ┗   ┛ ┃ ┗   ┛                 ┃       ┃      ");
            Console.WriteLine("            ━━━━━━╋━━━━━━━╋━━━━━━           ━━━━━━╋━━━━━━━╋━━━━━━");
            Console.WriteLine("            ┏ ━ ┓ ┃ ┏ ━ ┓ ┃ ┏ ━ ┓                 ┃       ┃      ");
            Console.WriteLine("            ┃   ┃ ┃ ┃   ┃ ┃ ┃   ┃             ④  ┃   ⑤  ┃   ⑥ ");
            Console.WriteLine("            ┗ ━ ┛ ┃ ┗ ━ ┛ ┃ ┗ ━ ┛                 ┃       ┃      ");
            Console.WriteLine("            ━━━━━━╋━━━━━━━╋━━━━━━           ━━━━━━╋━━━━━━━╋━━━━━━");
            Console.WriteLine("            ┏ ━ ┓ ┃ ┏ ━ ┓ ┃ ┏ ━ ┓                 ┃       ┃      ");
            Console.WriteLine("            ┃   ┃ ┃ ┃   ┃ ┃ ┃   ┃             ⑦  ┃   ⑧  ┃   ⑨ ");
            Console.WriteLine("            ┗ ━ ┛ ┃ ┗ ━ ┛ ┃ ┗ ━ ┛                 ┃       ┃      ");
            Console.WriteLine();
            Console.WriteLine();
            Program.TitleTo();

            Program.Title();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   ┃        ┃                        ┃       ┃      ");
            Console.WriteLine("                                              ①  ┃   ②  ┃   ③ ");
            Console.WriteLine("                   ┃        ┃                        ┃       ┃      ");
            Console.WriteLine("            ━━━━━━╋━━━━━━━╋━━━━━━           ━━━━━━╋━━━━━━━╋━━━━━━");
            Console.WriteLine("                   ┃        ┃                        ┃       ┃      ");
            Console.WriteLine("                   ┃        ┃                    ④  ┃   ⑤  ┃   ⑥ ");
            Console.WriteLine("                   ┃        ┃                        ┃       ┃      ");
            Console.WriteLine("            ━━━━━━╋━━━━━━━╋━━━━━━           ━━━━━━╋━━━━━━━╋━━━━━━");
            Console.WriteLine("                   ┃        ┃                        ┃       ┃      ");
            Console.WriteLine("                   ┃        ┃                    ⑦  ┃   ⑧  ┃   ⑨ ");
            Console.WriteLine("                   ┃        ┃                        ┃       ┃      ");
            Console.WriteLine();
            Console.WriteLine();
            Program.TitleTo();
*/