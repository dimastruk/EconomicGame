using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame
{
    public struct Resources
    {
        public int Coal; // Вугілля
        public int Iron; // Залізо
        public int Gold; // Золото
        public int Wood; // Дерево
        public int Clay; // Глина
        public int Sand; // Пісок
        public int Stone; // Камінь

        public Resources(int coal, int iron, int gold, int wood, int clay, int sand, int stone) : this()
        {
            this.Coal = coal;
            this.Iron = iron;
            this.Gold = gold;
            this.Wood = wood;
            this.Clay = clay;
            this.Sand = sand;
            this.Stone = stone;
        }
    }
}
