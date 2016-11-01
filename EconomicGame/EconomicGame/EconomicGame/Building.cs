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
        public int MaximumLevel = 10; // Максимальний рівень будівлі
        public int CreatingTime; // Поточний час створення будівлі
        public int FullCreatingTime; // Тривалість створення будівлі
        public Player Owner; // Власник будівлі
        public int State; // Стан будівлі
        public Resources Price; // Вартість будівлі
    }

    // Стани для будівлі
    enum States
    {
        Building = 0, // Будується
        Working = 1 // Працює (виробляє або добуває щось)
    }
}