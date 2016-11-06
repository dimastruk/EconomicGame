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

        public Resources(int Coal, int Iron, int Gold, int Wood, int Clay, int Sand, int Stone) : this()
        {
            this.Coal = Coal;
            this.Iron = Iron;
            this.Gold = Gold;
            this.Wood = Wood;
            this.Clay = Clay;
            this.Sand = Sand;
            this.Stone = Stone;
        }
    }
}