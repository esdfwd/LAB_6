using Task_1;

namespace lab_5
{
    class Program
    {
        static void Main()
        {
            Car car = new Car { Speed = 60, Capacity = 4 };
            Bus bus = new Bus { Speed = 40, Capacity = 20 };
            Train train = new Train { Speed = 80, Capacity = 100 };

            TransportNetwork network = new TransportNetwork();
            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            network.ControlMovement();

            // Dисадка пасажирів
            car.BoardPassengers(3);
            bus.DisembarkPassengers(5);
        }
    }
}