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
        private List<Building> allBuildings; 

        // Якщо гру створюємо без вказаного рівня, то за замовчуванням рівень = 1
        public Game() : this(1) {}

        public Game(int DifficultyLevel)
        {
            this.DifficultyLevel = DifficultyLevel;
            this.CurrentRound = 1;
            allBuildings = new List<Building>();
        }

        public bool Start(List<Player> players)
        {
            try
            {
                bool isRun = true;
                while (isRun)
                {
                
                    foreach (var building in allBuildings)
                    {
                        building.Do(CurrentRound);
                    }
                    foreach (var player in players)
                    {
                        player.Turn(CurrentRound);
                    }
                    if (CurrentRound == 50)
                        isRun = false;

                    CurrentRound++;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // Додати будівлю
        public void AddBuilding(Building b)
        {
            allBuildings.Add(b);
        }
    }
}
