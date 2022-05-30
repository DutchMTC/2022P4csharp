using System;
using System.IO;
using System.Threading;

namespace FileIOOpdracht
{
    internal class Program
    {
        public static void Main()
        {
            string output = @"C:\School\L1P4\GD\C#\CSharp2 Opdrachten\FileIOOpdracht\output";
            Directory.CreateDirectory(output);

            string path = @"C:\School\L1P4\GD\C#\CSharp2 Opdrachten\FileIOOpdracht\output\text.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("We're no strangers to love");
                    sw.WriteLine("You know the rules and so do I (do I)");
                    sw.WriteLine("A full commitment's what I'm thinking of");
                    sw.WriteLine("You wouldn't get this from any other guy");
                }
            }
            
            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Add a line to the file:");
            string input = Console.ReadLine();
            File.AppendAllText(path, input);

        }
    }
}
