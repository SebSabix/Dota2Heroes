using System;
using System.Collections.Generic;             
using System.Linq;
using System.Text;

namespace Dota2Heroes  //Kodat av Sebastian Sabel
{
    partial class Program // Här har jag delat upp "Program" i flera delar så att all kod skall bli mer lättöverskådlig.
    {
        public static Hero[] heroes = new Hero[0]; // Detta är "Hero" vektor som räcker för vårt projekt, eftersom det endast är heroes som skall behandlas.
                                                  // Vektorn skall alltid starta tom, alltså skall den stå på 0.
        public static void Main(string[] args)
        {
            Load();

            int menuchoice = 0;

            while ((menuchoice = MainMenuChoice()) != 0) // Denna while-loop itererar igenom alla menyval tills man skriver in det korrekta och genomför följande metod.
            {
                if (menuchoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Alla heroes i Dota 2: ");
                    PrintHeroes(heroes);                  
                }
                else if (menuchoice == 2)
                {
                    Console.Clear();
                    FindHeroesViaName();
                }
                else if (menuchoice == 3)
                {
                    Console.Clear();
                    FindHeroesViaRole();
                }
                else if (menuchoice == 4)
                {
                    Console.Clear();
                    FindHeroesViaAttribute();
                }
                else if (menuchoice == 5)
                {
                    Console.Clear();
                    RegisterHero();
                }            
                else if (menuchoice == 6)
                {
                    SaveHeroes();
                    break;
                }
                else if (menuchoice > 6)
                {
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatning!\n"); // Om vi matar in ett tal större än 6 så får vi ett felmeddelande
                }                                               // om att det som blivit inmatat ej är korrekt.
                Console.WriteLine();
            }
            Save();
        }

        // Lista menyval

        public static int MainMenuChoice() // 
        {
            Console.WriteLine("==========Dota 2 Heroes Register==========");
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Visa alla heroes");
            Console.WriteLine("2. Sök på namn");
            Console.WriteLine("3. Sök på roll");
            Console.WriteLine("4. Sök på attribut");
            Console.WriteLine("----------------------------");
            Console.WriteLine("5. Lägg till en hero");
            Console.WriteLine("----------------------------");
            Console.WriteLine("6. Avsluta");
            Console.WriteLine("----------------------------");
            Console.Write("Ange menyval: ");

            string menuchoice = Console.ReadLine();
            int choice;
            while (!int.TryParse(menuchoice, out choice))
            {
                Console.WriteLine();
                Console.WriteLine("Felaktig inmatning!");
                Console.Write("Ange menyval: ");
                menuchoice = Console.ReadLine();
            }

            return choice;
        }
    }
}
