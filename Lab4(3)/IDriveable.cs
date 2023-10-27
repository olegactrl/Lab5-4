using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_
{
    public interface IDriveable
    {
        public void Move(Vehicle vehicle)
        {
            int MainRoad = int.Parse(Console.ReadLine());
            switch (MainRoad)
            {
                case 69:
                    for (vehicle.Speed = 0; vehicle.Speed <= 130; vehicle.Speed += 10)
                    {
                        Console.WriteLine(vehicle.Speed);
                    }
                    break;
                case 03:
                    for (vehicle.Speed = 0; vehicle.Speed <= 110; vehicle.Speed += 10)
                    {
                        Console.WriteLine(vehicle.Speed);
                    }
                    break;
                case 39:
                    for (vehicle.Speed = 0; vehicle.Speed <= 90; vehicle.Speed += 10)
                    {
                        Console.WriteLine(vehicle.Speed);
                    }
                    break;
                default:
                    for (vehicle.Speed = 0; vehicle.Speed <= 70; vehicle.Speed += 10)
                    {
                        Console.WriteLine(vehicle.Speed);
                    }
                    break;
                    break;
            }
        }
        public void Stop(Vehicle vehicle) 
        { 
            if(vehicle.Size > 3)
            {
                vehicle.Speed = 0;
            }
        }
    }
}
