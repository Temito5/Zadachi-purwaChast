using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int faliedTime = 0; 
            int solvedProblemsCount=0;
            double gradesSum=0;
            string lastProblem = "";
            bool isFalied=true;

            while (faliedTime < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFalied = false;break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    faliedTime++;
                }
                gradesSum += grade;
                solvedProblemsCount++;  
                lastProblem = problemName;
            }

            if (isFalied)
            {
                Console.WriteLine($"You need a break,{failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score:{gradesSum/solvedProblemsCount}");
                Console.WriteLine($"Number of problems:{solvedProblemsCount:F2}");
                Console.WriteLine($"Last problem:{lastProblem}");
            }
        }
    }
}
