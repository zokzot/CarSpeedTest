using TestCar.Models;

namespace TestCar.Modules
{
    public class VehiclesService
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();

        public VehiclesService() {
            Console.WriteLine("CreateService");
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }
        
        public bool CheckSpeed(Vehicle vehicle, int speed)
        {
            if (speed <= vehicle.MaxSpeedKM)
                return true;

            return false;
        }
    }
}
