using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxHealth = 10;
            int mana = 7, maxMana = 10;

            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, 0);
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.Write("Введите число, на которое измениться жизнь: ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число, на которое измениться мана: ");
                mana += Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int posititon, char symbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, posititon);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = 0; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
