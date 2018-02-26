using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2Heroes
{
    partial class Program
    {
        public static void Swap(Hero[] heroes, int a, int b)
        {
            Hero r = heroes[a];
            heroes[a] = heroes[b];
            heroes[b] = r;
        }

        // Denna metod kommer göra så att det går att sortera
        // "heroes" i listan i namnordning, alltså vilken bokstav "hjälten" börjar på.
        // Vi har använt oss av BubbleSort.

        public static void SortByName(Hero[] heroes)
        {
            bool osorterad = true;

            int end = heroes.Length - 1;

            while (osorterad)
            {
                osorterad = false;

                for (int j = 0; j < end; j++)
                {
                    if (heroes[j].name.CompareTo(heroes[j + 1].name) > 0)
                    {
                        Swap(heroes, j, j + 1);
                        osorterad = true;
                    }
                }
                end--;
            }
        }
    }
}
