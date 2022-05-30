using System;

namespace EnumOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colors[] colors = (Colors[])Enum.GetValues(typeof(Colors));
            foreach(Colors color in colors)
            {
                Console.WriteLine(color.ToString());
            }

            Console.WriteLine("Pick a color:");
            string value = Console.ReadLine();
            try
            {
                Colors parsedColor = (Colors)Enum.Parse(typeof(Colors), value);
                Console.WriteLine("You picked: " + parsedColor.ToString());
            }
            catch
            {
                Console.WriteLine(value + " is not a valid color.");
            }
        }

        internal enum Colors
        {
            Pink,
            Blue,
            Green,
            Purple
        }
    }
}
