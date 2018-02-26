using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2Heroes
{
    partial class Program
    {
        public static void RegisterHero() // Denna metod ser till så att vi kan lägga till en ny hero i programmet om vi vill.
        {
            Console.Write("Skriv in namn: ");
            string name = Console.ReadLine();
            Console.Write("Skriv in roll: ");
            string role = Console.ReadLine();
            Console.Write("Skriv in attribut: ");
            string attribute = Console.ReadLine();

            Hero h = CreateHero(name, role, attribute);
            AddHero(h);
            SaveHeroes(); // Här har jag lagt till SaveHeroes-metoden så att när vi lägger till en ny hero och avslutar skall den sparas.
        }

        public static Hero CreateHero(string name, string role, string attribute)
        {
            Hero h = new Hero();
            h.name = name;
            h.role = role;
            h.attribute = attribute;
            return h;
        }      
    }
}
