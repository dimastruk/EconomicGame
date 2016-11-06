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
        protected int CollectAmount; // Кількість накопиченого ресурсу
        public override void Do(int round)
        {
            if (this.State == (int)States.Build)
            {
                Build(round);
            }

            if (this.State == (int)States.Working)
            {
                Working(round);
            }

            if (this.State == (int)States.Updating)
            {
                Updating(round);
            }
        }

        public CollectBuilding()
        {
            CurrentLevel = 1;
        }
    }

    // Завод видобутку вугілля
    public class CoalFactory : CollectBuilding
    {
        // Побудова заводу
        public CoalFactory(Player Owner)
        {
            MaximumLevel = 5;
            CreatingTime = 5;
            this.Owner = Owner;
            State = (int)States.Build;
            Price.Coal = 0;
            Price.Iron = 20;
            Price.Gold = 20;
            Price.Wood = 10;
            Price.Clay = 5;
            Price.Sand = 5;
            Price.Stone = 10;
            CollectAmount = 30;
        }

        protected override void Build(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Working(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Updating(int round)
        {
            throw new NotImplementedException();
        }
    }

    // Завод видобутку заліза
    public class IronFactory: CollectBuilding
    {
        // Побудова заводу
        public IronFactory(Player Owner)
        {
            MaximumLevel = 5;
            CreatingTime = 6;
            this.Owner = Owner;
            State = (int)States.Build;
            Price.Coal = 10;
            Price.Iron = 0;
            Price.Gold = 30;
            Price.Wood = 5;
            Price.Clay = 10;
            Price.Sand = 10;
            Price.Stone = 15;
            CollectAmount = 15;
        }

        protected override void Build(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Working(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Updating(int round)
        {
            throw new NotImplementedException();
        }
    }

    // Завод видобутку золота
    public class GoldFactory : CollectBuilding
    {
        // Побудова заводу
        public GoldFactory(Player Owner)
        {
            MaximumLevel = 7;
            CreatingTime = 7;
            this.Owner = Owner;
            State = (int)States.Build;
            Price.Coal = 15;
            Price.Iron = 15;
            Price.Gold = 0;
            Price.Wood = 10;
            Price.Clay = 15;
            Price.Sand = 15;
            Price.Stone = 10;
            CollectAmount = 10;
        }

        protected override void Build(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Working(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Updating(int round)
        {
            throw new NotImplementedException();
        }
    }

    // Завод видобутку дерева
    public class WoodFactory : CollectBuilding
    {
        // Побудова заводу
        public WoodFactory(Player Owner)
        {
            MaximumLevel = 6;
            CreatingTime = 6;
            this.Owner = Owner;
            State = (int)States.Build;
            Price.Coal = 10;
            Price.Iron = 10;
            Price.Gold = 5;
            Price.Wood = 0;
            Price.Clay = 0;
            Price.Sand = 0;
            Price.Stone = 15;
            CollectAmount = 30;
        }

        protected override void Build(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Working(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Updating(int round)
        {
            throw new NotImplementedException();
        }
    }

    // Завод видобутку глини
    public class ClayFactory : CollectBuilding
    {
        // Побудова заводу
        public ClayFactory(Player Owner)
        {
            MaximumLevel = 4;
            CreatingTime = 3;
            this.Owner = Owner;
            State = (int)States.Build;
            Price.Coal = 10;
            Price.Iron = 5;
            Price.Gold = 5;
            Price.Wood = 10;
            Price.Clay = 0;
            Price.Sand = 10;
            Price.Stone = 10;
            CollectAmount = 40;
        }

        protected override void Build(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Working(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Updating(int round)
        {
            throw new NotImplementedException();
        }
    }

    // Завод видобутку піску
    public class SandFactory : CollectBuilding
    {
        // Побудова заводу
        public SandFactory(Player Owner)
        {
            MaximumLevel = 4;
            CreatingTime = 3;
            this.Owner = Owner;
            State = (int)States.Build;
            Price.Coal = 5;
            Price.Iron = 5;
            Price.Gold = 10;
            Price.Wood = 10;
            Price.Clay = 5;
            Price.Sand = 0;
            Price.Stone = 15;
            CollectAmount = 35;
        }

        protected override void Build(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Working(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Updating(int round)
        {
            throw new NotImplementedException();
        }
    }

    // Завод видобутку каменю
    public class StoneFactory : CollectBuilding
    {
        // Побудова заводу
        public StoneFactory(Player Owner)
        {
            MaximumLevel = 5;
            CreatingTime = 4;
            this.Owner = Owner;
            State = (int)States.Build;
            Price.Coal = 10;
            Price.Iron = 10;
            Price.Gold = 5;
            Price.Wood = 10;
            Price.Clay = 5;
            Price.Sand = 5;
            Price.Stone = 0;
            CollectAmount = 25;
        }

        protected override void Build(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Working(int round)
        {
            throw new NotImplementedException();
        }

        protected override void Updating(int round)
        {
            throw new NotImplementedException();
        }
    }
}
