using Microsoft.AspNetCore.Mvc;

namespace RideHestenAPI.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HorseController : ControllerBase
    {


        private readonly ILogger<HorseController> _logger;

        public HorseController(ILogger<HorseController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHorses")]
        [MapToApiVersion("1.0")]
        public IActionResult Get()
        {
            var horses = new List<Horse>();
            horses.Add(new Horse() { Age = 13, DadName = "BLUE HORSE DOOLITTLE", MomDadName = "A-DUR", Name = "Dorthea", Height = 163, PictureUrls = new List<string>() { "https://ridehesten.com/pics/xl/2710c66a-0b00-4aa2-9bb3-02c4f47e5c70.jpg", "https://ridehesten.com/pics/xl/a652bbd3-d5ce-4630-a15f-8b303cdb73e1.jpg"  }, YoutubeUrls = new List<string>() { "http://www.youtube.com/watch?v=TgeHMJYOjac&rel=0" }, Gender = "Hoppe", Race = "Dansk Varmblod", PriceMaximum = 100000, PriceMinimum = 75000 });

            horses.Add(new Horse() { Age = 15, DadName = "Konge", MomDadName = "Gammel konge", Name = "Prins", Height = 174, PictureUrls = new List<string>() { "https://ridehesten.com/pics/xl/d85438ac-ef9f-42cc-ab21-0e063fe7020d.jpg", "https://ridehesten.com/pics/xl/5640ec16-65ae-4da5-8298-d269a55f6979.jpg", "https://ridehesten.com/pics/xl/ae2c093d-edfd-4009-b932-1181ea29714d.jpg" }, Gender = "Vallak", Race = "Dansk Varmblod", PriceMaximum = 50000, PriceMinimum = 30000 });

            horses.Add(new Horse() { Age = 19, DadName = "Happier", MomDadName = "Grumpy", Name = "Happy", Height = 143, PictureUrls = new List<string>() { "https://ridehesten.com/pics/xl/d85438ac-ef9f-42cc-ab21-0e063fe7020d.jpg", "https://ridehesten.com/pics/xl/a5f3416a-2a3c-4e2c-ac25-bad68376f70d.jpg" }, YoutubeUrls = new List<string>() { "http://www.youtube.com/watch?v=BS15KhVoEPM&rel=0", "http://www.youtube.com/watch?v=RBuuXSIXfik&rel=0" }, Gender = "Hoppe", PriceMaximum = 75000, PriceMinimum = 50000 });

            horses.Add(new Horse() { Age = 18, DadName = "LEANDRO", MomDadName = "MAGO XX", Name = "Lotus Royal", Height = 170, PictureUrls = new List<string>() { "https://ridehesten.com/pics/xl/393adeb6-ab85-4bb7-a0c4-ea62ae19a59e.jpg", "https://ridehesten.com/pics/xl/98765857-f342-4eb5-8cd5-d148e179d23a.jpg", "https://ridehesten.com/pics/xl/9a2abe51-0d10-4262-88bd-4d2dc2fad273.jpg" }, Gender = "Vallak", Race = "Dansk Varmblod", PriceMaximum = 50000, PriceMinimum = 30000});

            return Ok(horses);
        }
    }
}