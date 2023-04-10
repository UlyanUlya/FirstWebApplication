using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    { 
        
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCars")]



        public IEnumerable<Car> Get()
        {
            var carsList = new List<Car>
            {
                new Car { Manufacturer = "BMW", Model = "X6", Class = "A+", Color = "Yellow", Year = 2023 },
                new Car { Manufacturer = "BMW", Model = "X4", Class = "A++", Color = "Yellow", Year = 2023 },
                new Car { Manufacturer = "BMW", Model = "X5", Class = "A", Color = "Yellow", Year = 2023 }
            };

            
            return carsList;
        }
    }

    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }
    }
}