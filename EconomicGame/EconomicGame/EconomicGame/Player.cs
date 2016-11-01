using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame
{
    public class Player
    {
        // Ім'я гравця
        public string Name { get; private set; }

        // Ресурси гравця
        public Resources resources;

        //Якщо при створенні об'єкту ім'я не вказане - задаємо ім'я за замовчуванням
        public Player() : this("Anonymus") { }

        public Player(string Name)
        {
            this.Name = Name;
            resources = new Resources();
        }
    }

    public struct Resources
    {
        public int Coal; // Вугілля
        public int Iron_Ore; // Залізна руда
        public int Gold; // Золото
        public int Wood; // Дерево
        public int Clay; // Глина
        public int Sand; // Пісок
        public int Stone; // Камінь
    }
}
