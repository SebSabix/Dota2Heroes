using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2Heroes
{
    partial class Program
    {
        public static void AddHero(Hero h) // 
        {
            Hero[] temp = new Hero[heroes.Length + 1];
            for (int i = 0; i < heroes.Length; i++)
            {
                temp[i] = heroes[i];
            }
            temp[heroes.Length] = h;
            heroes = temp;
        }

        public static Hero[] AddHero(Hero[] heroes, Hero h) 
        {
            Hero[] temp = new Hero[heroes.Length + 1];
            for (int i = 0; i < heroes.Length; i++)
            {
                temp[i] = heroes[i];
            }
            temp[heroes.Length] = h;
            return temp;
        }

        public static Hero[] SearchHeroesViaName(string searchPhrase) // Denna metod itererar genom vektorn av heroes utifrån sökfras.
        {
            Hero[] foundHeroes = new Hero[heroes.Length];
            int numberOfHeroes = 0;

            for (int i = 0; i < heroes.Length; i++)
            {
                if (heroes[i].name.ToUpper().Contains(searchPhrase.ToUpper()))
                {
                    foundHeroes[numberOfHeroes++] = heroes[i];
                }
            }

            Hero[] foundHeroesTrimmed = new Hero[numberOfHeroes];

            for (int i = 0; i < numberOfHeroes; i++)
            {
                foundHeroesTrimmed[i] = foundHeroes[i];
            }
            return foundHeroesTrimmed;  
        }

        public static Hero[] SearchHeroesViaRole(string searchPhrase) // SearchHeroViaRole
        {
            Hero[] foundHeroes = new Hero[heroes.Length];
            int numberOfHeroes = 0;

            for (int i = 0; i < heroes.Length; i++)
            {
                if (heroes[i].role.ToUpper().Contains(searchPhrase.ToUpper()))
                {
                    foundHeroes[numberOfHeroes++] = heroes[i];
                }
            }

            Hero[] foundHeroesTrimmed = new Hero[numberOfHeroes];

            for (int i = 0; i < numberOfHeroes; i++)
            {
                foundHeroesTrimmed[i] = foundHeroes[i];
            }
            return foundHeroesTrimmed;
        }

        public static Hero[] SearchHeroesViaAttribute(string searchPhrase) // Sök på hero genom attribut.
        {
            Hero[] foundHeroes = new Hero[heroes.Length];
            int numberOfHeroes = 0;

            for (int i = 0; i < heroes.Length; i++)
            {
                if (heroes[i].attribute.ToUpper().Contains(searchPhrase.ToUpper()))
                {
                    foundHeroes[numberOfHeroes++] = heroes[i];
                }
            }

            Hero[] foundHeroesTrimmed = new Hero[numberOfHeroes];

            for (int i = 0; i < numberOfHeroes; i++)
            {
                foundHeroesTrimmed[i] = foundHeroes[i];
            }
            return foundHeroesTrimmed;
        }
    }
}
