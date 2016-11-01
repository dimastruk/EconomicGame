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
        // Номер поточного раунду
        public int CurrentRound { get; private set; } 
        // Список будівель

        // Якщо гру створюємо без вказаного рівня, то за замовчуванням рівень = 1
        public Game() : this(1) {}

        public Game(int DifficultyLevel)
        {
            this.DifficultyLevel = DifficultyLevel;
            this.CurrentRound = 1;
        }

        public bool Start(List<Player> players)
        {
            try
            {
                // Задання початкових ресурсів (поки що немає прив'язки до рівня складності)
                foreach (var player in players)
                {
                    player.resources.Coal = 100;
                    player.resources.Iron_Ore = 100;
                    player.resources.Gold = 100;
                    player.resources.Wood = 100;
                    player.resources.Clay = 100;
                    player.resources.Sand = 100;
                    player.resources.Stone = 100;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
