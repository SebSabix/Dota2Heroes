using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2Heroes
{
    partial class Program
    {
        public static string Formatter(string s, int length)
        {
            string n = s + new string(' ', length);
            return n.Substring(0, length);
        }

        public static void PrintHeroes(Hero[] heroes) // Denna metod skriver ut alla heroes i en och samma lista.
        {
            Console.WriteLine("\n" +
                Formatter("Name: ", 20) + " " +
                Formatter("Role: ", 30) + " " +
                Formatter("Attribute: ", 30));

            for (int i = 0; i < heroes.Length; i++)
            {
                SortByName(heroes); // Här har vi anropat metoden SortByName så att när vi printar ut alla
                PrintHero(heroes[i]); // heroes kommer alla att listas i namnordning.
            }
        }

        public static void PrintHero(Hero h)
        {
            Console.WriteLine(
                Formatter(h.name, 20) + " " +
                Formatter(h.role, 30) + " " +
                h.attribute);
        }
    }
}
