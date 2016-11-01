using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            players.Add(new Player("Dima"));

            Game game = new Game();
            CoalFactory cf = new CoalFactory(players[0]);
            game.AddBuilding(cf);
            if (game.Start(players))
                return;
            Console.WriteLine("Smth wrong!");
        }
    }
}