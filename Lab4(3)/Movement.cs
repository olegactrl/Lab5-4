using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_
{
    public class Movement : Vehicle, IDriveable
    {
        public Movement(int speed, int size, string type, int quality) : base(speed, size, type, quality)
        {
        }

        internal List<Vehicle> _vehicles { get; private set; } = new List<Vehicle>();
        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }
        internal List<Road> roads { get; private set; } = new List<Road>();
        public void AddRoad(Road road)
        {
            roads.Add(road);
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            if(vehicle.CarQuality <= 10)
            _vehicles.Remove(vehicle);
        }
        public void RemoveRoad(Road road)
        {
            if (road.RoadQuality <= 10)
                roads.Remove(road);
        }
    }
}
