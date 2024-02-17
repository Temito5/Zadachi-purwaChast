using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widthOfSpace = int.Parse(Console.ReadLine());
            int lengthOfSpace = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());


            int volume = widthOfSpace * lengthOfSpace * height;
            bool hasVolume = true;

            string command = Console.ReadLine();

            while (!(command == "Done"))
            {
                int box = int.Parse(Console.ReadLine());

                volume -= box;

                if (volume < 0)
                {
                    hasVolume = false;
                    break;
                }
                command = Console.ReadLine();
            }
            if (hasVolume)
                Console.WriteLine("{0}Cubis meters left.", volume);
            else
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(volume));
        }
    }
}
