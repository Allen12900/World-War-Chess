using System;

namespace World_War_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Board(10);
            PlayGame(b);
        }


        private static void PlayGame(Board b)
        {
            b.PrintBoard();
        }
    }
}
