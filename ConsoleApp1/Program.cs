using System;
namespace ConditionalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForTrip = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spentDays = 0; 

            while (true)
            {
                string toDo = Console.ReadLine();
                double moneyToSpend = double.Parse(Console.ReadLine());
                days++;
                if (toDo == "save")
                {
                    currentMoney = moneyToSpend + currentMoney;
                    spentDays = 0; 
                }
                else if (toDo == "spend") 
                {
                    currentMoney = currentMoney - moneyToSpend;
                    spentDays++; 
                }
                if (currentMoney < 0)
                {
                    currentMoney = 0;
                }
                if (spentDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
                else if (currentMoney >= moneyNeededForTrip)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }

            }
        }
    }
}