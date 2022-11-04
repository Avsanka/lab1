using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Card
    {
        int value;
        public string suit;
        public string name;

        public int RetVal()
        {
            return this.value;
        }

        public void UserSet(string name, string suit, int value)
        {
            this.suit = suit;
            this.value = value;
            this.NameCreate(value);
        }
        void NameCreate(int value)
        {
            switch (value) {
                case 11:
                    name = "Валет";
                    break;
                case 12:
                    name = "Дама";
                    break;
                case 13:
                    name = "Король";
                    break;
                case 14:
                    name = "Туз";
                    break;
                default:
                    name = value.ToString();
                    break;
            }
        }
        public void Random()
        {
            Random rand = new Random();
            this.value = rand.Next(6, 15);
            NameCreate(this.value);

            switch (rand.Next(0, 4))
            {
                case 0:
                    this.suit = "Черви";
                    break;
                case 1:
                    this.suit = "Буби";
                    break;
                case 2:
                    this.suit = "Крести";
                    break;
                case 3:
                    this.suit = "Пики";
                    break;
                default:
                    break;
            }
        }

        public int battle(Card User, Card comp)
        {
            if (User.suit != comp.suit)
                return 0;
            else if (User.value > comp.value)
                return 1;
            else if (User.value == comp.value)
                return 0;
            else
                return 2;
        }
    }
}
