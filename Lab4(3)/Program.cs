

namespace Lab4_3_
{
    public class Program
    {
        public void Main(string[] args)
        {
            Movement movement = new Movement();

            movement.AddVehicle(new Vehicle(120, 2, "car", 50));
            movement.AddRoad(new Road(30, 6, 3, 50));
            Console.WriteLine(movement.roads);

            foreach (var road in movement.roads)
            {
                Console.WriteLine(road);
            }

        }
    }
}