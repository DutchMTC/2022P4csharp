using System;
using System.Collections.Generic;

namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string>();
            birds.Add("uil");
            birds.Add("kraai");
            birds.Add("hond");
            birds.Add("papegaai");

            List<string> birds2 = new List<string>();
            birds2.Add("meeuw");
            birds2.Add("duif");

            birds.AddRange(birds2);
            Console.WriteLine("hond is at index: " + birds.IndexOf("hond"));
            birds.RemoveAt(birds.IndexOf("hond"));
            Console.WriteLine("hond removed");

            if (birds.IndexOf("kip") != -1)
            {
                birds.RemoveAt(birds.IndexOf("kip"));
                Console.WriteLine("kip removed");
            }
            else
            {
                Console.WriteLine("kip doesn't exist");
            }

            foreach (string bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}
