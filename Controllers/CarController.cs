using Microsoft.AspNetCore.Mvc;
using p48_lessons_asp.Models;

namespace p48_lessons_asp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            Random rndm = new();
            List<string> brands = new(){"Toyota", "Volkswagen", "Ford"};
            List<string> model = new(){"Sedan", "Hetchback", "SUV"};

            List<CarModel> carModels = new();
            for (int i = 0; i < 4; i++)
            {
                carModels.Add(new CarModel
                {
                    Brand = brands[rndm.Next(0, brands.Count)],
                    Model = model[rndm.Next(0, model.Count)],
                    Price = Math.Round(rndm.NextDouble() * 100, 2)
                });
            }

            return View(carModels);
        }

    }
}
