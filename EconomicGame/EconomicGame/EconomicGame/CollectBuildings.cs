using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dmytro's workspace
namespace EconomicGame
{
    public abstract class CollectBuilding : Building
    {
        public int CollectTime; // Час накопичення ресурсу
        public int CollectAmount; // Кількість накопиченого ресурсу
    }

    // Вугільний завод
    public class CoalFactory : CollectBuilding
    {
        // Побудова заводу
        public CoalFactory(Player Owner)
        {
            CurrentLevel = 1;
            MaximumLevel = 5;
            CreatingTime = 5;
            this.Owner = Owner;
            State = (int)States.Building;
            Price.Coal = 0;
            Price.Iron_Ore = 20;
            Price.Gold = 20;
            Price.Wood = 10;
            Price.Clay = 5;
            Price.Sand = 5;
            Price.Stone = 10;
            CollectTime = 10;
            CollectAmount = 20;
        }

        
        public override void Do(int round)
        {
            Console.WriteLine("Coal factory");
        }
    }
}
