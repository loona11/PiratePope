using System;

namespace LabaPirate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            bool a = game.play;
            Game(a, game);

        }
        public static void Game(bool a, Game game)
        {
            game.GetName();
            while (a)
            {
                //game.GetName();
                game.GetFirstTurn();
            }
        }
    }
}
