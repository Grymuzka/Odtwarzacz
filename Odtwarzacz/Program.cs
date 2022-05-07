using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUtwor u1 = new Utwor(1, "Dom", "Bitamina", "Kawalerka", 22230);

            u1.WyswietlDaneUtworu();

            Console.ReadKey();
        }
    }
}
//komentarz123
