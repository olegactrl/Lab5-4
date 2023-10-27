using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Ecosystem : Creatures, IReproducible, IPredator
    {
        public void Plant(int FinalTime = 10)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            for (int i = 1; i <= FinalTime; i++)
            {
                switch (i)
                {
                    case 1:
                        dateTime = dateTime.AddDays(10);
                        Console.WriteLine("Here u go; days spent: " + FinalTime + ' ' + dateTime);
                        break;
                    case 2:
                        Console.WriteLine("for the next wait: " + (FinalTime) + " days");
                        break;
                }
            }
        }

        public void Weight()
        {
            Console.WriteLine("Type high of ur animal: ");
            if (int.TryParse(Console.ReadLine(), out high))
            {
                if (high >= 160)
                {
                    int weight = high - 110;
                    Console.WriteLine("Ur animal weight is: " + weight);
                }
                else
                {
                    Console.WriteLine("u`r too low");
                }
            }
        }

        public void Reproduct()
        {
            Console.WriteLine("Enter the number of desired animals: ");
            int.TryParse(Console.ReadLine(), out int number);
            switch (number)
            {
                case 1:
                    energy -= 10;
                    Console.WriteLine($"produced): {number}");
                    break;
                default:
                    Console.WriteLine("u can't");
                    break;

            }
        }
        public void Hunt()
        {

            Console.WriteLine("Hunt or Rest");
            string check = Console.ReadLine();
            switch (check)
            {
                case "hunt":
                    if (energy >= 50)
                    {
                        energy -= 10;
                        Console.WriteLine("the prey was caught! " + energy + " - energy remains");
                    }
                    else
                        Console.WriteLine("u can't hunt, ur energy = " + energy);
                    break;
                default:
                    Console.WriteLine("rest...");
                    break;
            }
        }
        public void Number(int number = 2)
        {
            DateTime dateTime2 = DateTime.Now;
            Console.WriteLine(dateTime2);
            for (int days = 0; days <= 90; days++)
            {
                number += 10;
                dateTime2.AddDays(1);
                Console.WriteLine("Day " + days + ' ' + dateTime2.AddDays(1) + ": number of microorg: " + number);
            }
        }
    }
}

