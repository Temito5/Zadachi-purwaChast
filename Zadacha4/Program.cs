using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps=0;
            string command = "";
            while (totalSteps<10000 && (command=Console.ReadLine()) != "Going home")
            {
                int steps = int.Parse(command);
                totalSteps += steps;
                if (totalSteps>=10000)
                {
                    Console.WriteLine("Goal reached Good job!");break;
                }
            }
            if (command=="Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                if (totalSteps+stepsToHome >=10000)
                {
                    Console.WriteLine("Goal reached!Good job!");
                }
                else
                {
                    Console.WriteLine($"{10000-totalSteps-stepsToHome} more steps to reach goal.");
                }
            }
        }
    }
}
