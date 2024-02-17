using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeSize = cakeLenght * cakeWidth;

            try
            {
                while (cakeSize >= 0)
                {
                    int piecesTaken = int.Parse(Console.ReadLine());
                    cakeSize = cakeSize - piecesTaken;
                }
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
            catch
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
