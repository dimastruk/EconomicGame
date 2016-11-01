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
        public int CollectAmount; // Кількість накопиченого ресурсу
    }

    // Завод видобутку вугілля
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
            Price.Iron = 20;
            Price.Gold = 20;
            Price.Wood = 10;
            Price.Clay = 5;
            Price.Sand = 5;
            Price.Stone = 10;
            CollectAmount = 30;
        }
    }

    // Завод видобутку заліза
    public class IronFactory: CollectBuilding
    {
        // Побудова заводу
        public IronFactory(Player Owner)
        {
            CurrentLevel = 1;
            MaximumLevel = 5;
            CreatingTime = 6;
            this.Owner = Owner;
            State = (int)States.Building;
            Price.Coal = 10;
            Price.Iron = 0;
            Price.Gold = 30;
            Price.Wood = 5;
            Price.Clay = 10;
            Price.Sand = 10;
            Price.Stone = 15;
            CollectAmount = 15;
        }
    }

    // Завод видобутку золота
    public class GoldFactory : CollectBuilding
    {
        // Побудова заводу
        public GoldFactory(Player Owner)
        {
            CurrentLevel = 1;
            MaximumLevel = 7;
            CreatingTime = 7;
            this.Owner = Owner;
            State = (int)States.Building;
            Price.Coal = 15;
            Price.Iron = 15;
            Price.Gold = 0;
            Price.Wood = 10;
            Price.Clay = 15;
            Price.Sand = 15;
            Price.Stone = 10;
            CollectAmount = 10;
        }
    }

    // Завод видобутку дерева
    public class WoodFactory : CollectBuilding
    {
        // Побудова заводу
        public WoodFactory(Player Owner)
        {
            CurrentLevel = 1;
            MaximumLevel = 6;
            CreatingTime = 6;
            this.Owner = Owner;
            State = (int)States.Building;
            Price.Coal = 10;
            Price.Iron = 10;
            Price.Gold = 5;
            Price.Wood = 0;
            Price.Clay = 0;
            Price.Sand = 0;
            Price.Stone = 15;
            CollectAmount = 30;
        }
    }

    // Завод видобутку глини
    public class ClayFactory : CollectBuilding
    {
        // Побудова заводу
        public ClayFactory(Player Owner)
        {
            CurrentLevel = 1;
            MaximumLevel = 4;
            CreatingTime = 3;
            this.Owner = Owner;
            State = (int)States.Building;
            Price.Coal = 10;
            Price.Iron = 5;
            Price.Gold = 5;
            Price.Wood = 10;
            Price.Clay = 0;
            Price.Sand = 10;
            Price.Stone = 10;
            CollectAmount = 40;
        }
    }

    // Завод видобутку піску
    public class SandFactory : CollectBuilding
    {
        // Побудова заводу
        public SandFactory(Player Owner)
        {
            CurrentLevel = 1;
            MaximumLevel = 4;
            CreatingTime = 3;
            this.Owner = Owner;
            State = (int)States.Building;
            Price.Coal = 5;
            Price.Iron = 5;
            Price.Gold = 10;
            Price.Wood = 10;
            Price.Clay = 5;
            Price.Sand = 0;
            Price.Stone = 15;
            CollectAmount = 35;
        }
    }

    // Завод видобутку каменю
    public class StoneFactory : CollectBuilding
    {
        // Побудова заводу
        public StoneFactory()
        {
            CurrentLevel = 1;
            MaximumLevel = 5;
            CreatingTime = 4;
            this.Owner = Owner;
            State = (int)States.Building;
            Price.Coal = 10;
            Price.Iron = 10;
            Price.Gold = 5;
            Price.Wood = 10;
            Price.Clay = 5;
            Price.Sand = 5;
            Price.Stone = 0;
            CollectAmount = 25;
        }
    }
}
