using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RpgCharacter hero = new RpgCharacter("Cloud strife", 999, 9999);

            Console.WriteLine(hero.name);
            Console.WriteLine(hero.str);
            Console.WriteLine(hero.hp);
            Console.ReadLine();
        }
    }
}
