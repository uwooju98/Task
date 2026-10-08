using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal class Lobby
    {
        public static int difficulty = 0;
        public static void SeletDifficulty()
        {
            

            bool lobbySwitch = true;
            do
            {
                Console.Clear();
                ShowLobby();
                Console.WriteLine();
                Console.WriteLine("                           [난이도를 입력해주세요]");
                Console.WriteLine();
                Console.Write("                                      ");
                string selet = Console.ReadLine();
                Console.WriteLine("            ");
                bool input = int.TryParse(selet, out difficulty);

                if (!input)
                {
                    Console.Clear();
                    ShowLobby();
                    Console.WriteLine();
                    lobbySwitch = true;
                    Console.WriteLine("              [올바른 입력이 아닙니다 숫자[1 ~ 3]를 입력해주세요]");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (!(difficulty > 0 && difficulty < 4))
                {
                    Console.Clear();
                    ShowLobby();
                    Console.WriteLine();
                    lobbySwitch = true;
                    Console.WriteLine("              [올바른 입력이 아닙니다 숫자[1 ~ 3]를 입력해주세요]");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    lobbySwitch = false;

                    if (difficulty == 1)
                    {
                        Console.Clear();
                        ShowLobby();
                        Console.WriteLine();
                        Console.WriteLine("                        [난이도 쉬움을 선택 했습니다]");
                        Console.WriteLine();
                        Console.Write("                                      ");
                        Thread.Sleep(1200);
                    }
                    else if (difficulty == 2)
                    {
                        Console.Clear();
                        ShowLobby();
                        Console.WriteLine();
                        Console.WriteLine("                        [난이도 보통을 선택 했습니다]");
                        Console.WriteLine();
                        Console.Write("                                      ");
                        Thread.Sleep(1200);
                    }
                    else
                    {
                        Console.Clear();
                        ShowLobby();
                        Console.WriteLine();
                        Console.WriteLine("                        [난이도 어려움을 선택 했습니다]");
                        Console.WriteLine();
                        Console.Write("                                      ");
                        Thread.Sleep(1200);
                    }
                }
            } while (lobbySwitch);
        }




        public static void ShowLobby()
        {
            Title.TitleStart();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                               [ 난이도 선택 ]");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                 [1] - Easy");
            Console.WriteLine();
            Console.WriteLine("                                 [2] - Nomal");
            Console.WriteLine();
            Console.WriteLine("                                 [3] - Hard");
            Console.WriteLine();
            Console.WriteLine();
            Title.TitleEnd();
        }
    }
}
