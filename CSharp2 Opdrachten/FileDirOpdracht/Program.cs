using System;
using System.IO;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo mainDir = new DirectoryInfo(@"C:\School\L1P4\GD\C#\CSharp2 Opdrachten");

            foreach (FileInfo fi in mainDir.GetFiles("*", SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
