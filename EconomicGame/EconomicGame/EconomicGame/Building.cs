using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame
{
    public abstract class Building
    {
        public int CurrentLevel; // Поточний рівень будівлі
        protected int MaximumLevel; // Максимальний рівень будівлі
        protected int CreatingTime; // Час створення будівлі
        protected int StartRound; // Стартовий раунд створення будівлі
        public Player Owner; // Власник будівлі
        public int State; // Стан будівлі
        public Resources Price; // Вартість будівлі

        public abstract void Do(int round);
    }

    // Стани для будівлі
    enum States
    {
        Building = 0, // Будується
        Working = 1, // Працює (виробляє або добуває щось)
        Updating = 2 // Підвищує рівень та властивості
    }
}