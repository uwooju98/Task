using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(78, 23);

            do
            {
                Lobby.SeletDifficulty();
                Play.Playing();
                Result.GameEnd();
            } while (Result.ReStart());

        }
    }
}

