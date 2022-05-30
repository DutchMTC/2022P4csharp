using System;
using System.IO;
using System.Linq;

namespace StringOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringsplit = File.ReadAllText(@"C:\School\L1P4\GD\C#\CSharp2 Opdrachten\StringOpdracht\stringsplit.txt");
            string[] result = stringsplit.Split(':');
            result = result.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string[] cijfers = result[1].Split(',');
            cijfers = cijfers.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string cijfer1 = cijfers[0].Replace(" ", "");
            string cijfer2 = cijfers[1].Replace(" ", "");

            Console.WriteLine(result[0]);
            Console.WriteLine(cijfer1);
            Console.WriteLine(cijfer2);
            Console.ReadLine();
        }
    }
}
