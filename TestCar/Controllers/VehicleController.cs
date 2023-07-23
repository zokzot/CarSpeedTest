using Microsoft.AspNetCore.Mvc;
using TestCar.Models;
using TestCar.Modules;

namespace TestCar.Controllers
{
    [ApiController]
    [Route("api/vehicles")]
    public class VehicleController : Controller
    {
        private VehiclesService _vehiclesService;

        public VehicleController(VehiclesService vehiclesService) {
            _vehiclesService = vehiclesService;
        }

        [HttpGet]
        [Route("getvehicles")]
        public List<Vehicle> GetVehicles()
        {
            return _vehiclesService.GetVehicles();
        }

        [HttpPost]
        [Route("checkspeed/{speed}")]
        public bool CheckSpeed([FromBody] Vehicle vehicle, int speed)
        {
            return _vehiclesService.CheckSpeed(vehicle, speed);
        }
    }
}
