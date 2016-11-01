using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame
{
    public class Game
    {
        // Рівень складності
        public int DifficultyLevel { get; private set; } 

        // Якщо гру створюємо без вказаного рівня, то за замовчуванням рівень = 1
        public Game() : this(1) { }

        public Game(int DifficultyLevel)
        {
            this.DifficultyLevel = DifficultyLevel;
        }

        public void Start(List<Player> players)
        {
            // Задання початкових ресурсів (поки що немає прив'язки до рівня складності)
            foreach(var player in players)
            {
                player.resources.Coal = 100;
                player.resources.Iron = 100;
                player.resources.Gold = 100;
                player.resources.Wood = 100;
                player.resources.Clay = 100;
                player.resources.Sand = 100;
                player.resources.Stone = 100;
            }
        }
    }
}
