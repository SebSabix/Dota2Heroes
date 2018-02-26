using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Dota2Heroes
{
    partial class Program
    {
        public static void Save()
        {
            SaveHeroes();
        }
        public static void Load()
        {
            LoadHeroes();
        }

        public static void LoadHeroes() // Metoden LoadHeroes skall läsa in heroes från textfil "heroes.txt" och sedan läggas i listan heroes.
        {
            StreamReader infil = new StreamReader("heroes.txt");

            while (true)  
            {
                try // Här har jag lagt till en try-catch, och allt inom detta kodblock kan kastas om det är så att 
                {                                            // ett undantag uppstår.
                    string line = infil.ReadLine();
                    if (line == null) break;

                    string[] parts = line.Split('\t');

                    Hero hero = new Hero();
                    hero.name = parts[0];
                    hero.role = parts[1];
                    hero.attribute = parts[2];

                    AddHero(hero);
                }
                catch (IndexOutOfRangeException)   // Detta catch-block säger till oss att en ändring har skett i ett element i heroes.txt
                {                                           // vilket kan ha påverkan på de olika funktionerna i programmet när vi vill ha fram en hero.
                    Console.WriteLine("En ändring har skett i heroes.txt.!"); // Vi får en varning om detta vid uppstart av programmet.                                                                    
                }                                                             
            }                                                             

            infil.Close();

        }

        public static void SaveHeroes() // Denna metod sparar ändringar vi har gjort i heroes.txt.
        {
            StreamWriter utfil = new StreamWriter("heroes.txt", false);

            for (int i = 0; i < heroes.Length; i++)
            {
                Hero hero = heroes[i];
                utfil.WriteLine("{0}\t{1}\t{2}", hero.name, hero.role, hero.attribute);
            }

            utfil.Close();
        }
    }
}
