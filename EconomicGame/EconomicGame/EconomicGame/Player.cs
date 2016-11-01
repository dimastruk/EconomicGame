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
            // Стартові ресурси
            resources = new Resources(100, 100, 100, 100, 100, 100, 100);
        }

        // Хід
        public void Turn(int currentRound)
        {
            // Виклик функції яка заставляє користувача зробити хід
        }
    }
}
