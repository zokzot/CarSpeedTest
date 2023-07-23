using TestCar.Modules;

namespace TestCar
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.CustomSchemaIds(type => type.ToString());
            });

            VehiclesService vehiclesService = new();
            services.AddSingleton(vehiclesService);

            #region testdata
            vehiclesService.AddVehicle(new Models.Vehicle
            {
                Name = "Bycicle",
                MaxSpeedKM = 40
            });
            vehiclesService.AddVehicle(new Models.Vehicle
            {
                Name = "Bus",
                MaxSpeedKM = 300
            });
            #endregion
        }
    }
}
