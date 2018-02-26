using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2Heroes
{
    partial class Program
    {
        public static void FindHeroesViaName() // Denna metod gör så vi kan söka på en specifik hero via namn.
        {
            Console.Write("Ange namn: ");
            string searchPhrase = Console.ReadLine();
            Hero[] foundHeroes = SearchHeroesViaName(searchPhrase); 
            PrintHeroes(foundHeroes);
        }

        public static void FindHeroesViaRole() // Denna metod gör så att vi kan söka på en specifik hero via roll.
        {           
            Console.Write("Ange roll: ");
            string searchPhrase = Console.ReadLine();
            Hero[] foundHeroes = SearchHeroesViaRole(searchPhrase);
            SortByName(foundHeroes); // När vi nu söker på roll så kommer alla träffas listas i bokstavsordning, 
            PrintHeroes(foundHeroes);  // genom BubbleSort.   
        }

        public static void FindHeroesViaAttribute() // Denna metod gör så att vi kan söka på en specifik hero via attribut.
        {
            Console.Write("Ange attribut: ");
            string searchPhrase = Console.ReadLine();
            Hero[] foundHeroes = SearchHeroesViaAttribute(searchPhrase);
            SortByName(foundHeroes);  // Precis som metoden ovan ser vi "hjältarna" i bokstavsordning här med.
            PrintHeroes(foundHeroes);
        }
    }
}
