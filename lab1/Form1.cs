using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClass;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThrowUser(Card card)
        {
            labelTable.Text = card.name + " " + card.suit;
        }

        private void ThrowComp(Card card)
        {
            labelTable2.Text = card.name + " " + card.suit;
        }

        private void battleOutput(int res)
        {
            switch (res)
            {
                case 1:
                    MessageBox.Show("Вы выиграли!");
                    break;
                case 2:
                    MessageBox.Show("Вы проиграли(");
                    break;
                default:
                    MessageBox.Show("Ничья");
                    break;
            }
        }

        Card userCard = new Card();
        private int userVal(string name)
        {
            int value = 0;
            try
            {
                value = int.Parse(name);
            }
            catch (System.FormatException)
            {
                if (name == "Валет")
                    value = 11;
                else if (name == "Дама")
                    value = 12;
                else if (name == "Король")
                    value = 13;
                else if (name == "Туз")
                    value = 14;
                else
                    value = 0;
            }
            return value;
        }

        private string UserSuit()
        {
            string suit = " ";
            if (radioButton1.Checked)
                suit = "Черви";
            else if (radioButton2.Checked)
                suit = "Буби";
            else if (radioButton3.Checked)
                suit = "Крести";
            else
                suit = "Пики";
            return suit;
        }
        
        //
        //
        //
        private void Button1_Click(object sender, EventArgs e)
        {
            userCard.Random();
            ThrowUser(userCard);
        }

        private void ButtonUserSet_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string suit = UserSuit();
            int value = userVal(name);
            if (value < 6 || value > 14)
            {
            
                MessageBox.Show("Ошибка! Нет такой карты!");
            }
            else
            {
                userCard.UserSet(name, suit, value);
                ThrowUser(userCard);
            }
        }

        private void ButtonBattle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userCard.name))
            {
                Card compCard = new Card();
                compCard.Random();
                ThrowComp(compCard);
                battleOutput(userCard.battle(userCard, compCard));
            }
            else
                MessageBox.Show("Для начала выберите карту");
        }
    }
}
