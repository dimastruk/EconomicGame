using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame
{
    public abstract class Building
    {
        public int CurrentLevel { get; protected set; }// Поточний рівень будівлі
        protected int MaximumLevel; // Максимальний рівень будівлі
        protected int CreatingTime; // Час створення будівлі
        protected int StartRound; // Стартовий раунд створення будівлі
        public Player Owner { get; protected set; } // Власник будівлі
        public int State { get; protected set; } // Стан будівлі
        protected Resources Price; // Вартість будівлі

        public abstract void Do(int round);
        protected abstract void Build(int round);
        protected abstract void Working(int round);
        protected abstract void Updating(int round);
    }

    // Стани для будівлі
    enum States
    {
        Build = 0, // Будується
        Working = 1, // Працює (виробляє або добуває щось)
        Updating = 2 // Підвищує рівень та властивості
    }
}