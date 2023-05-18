using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarsGame.Application;
using CarsGame.Domain.Car;

namespace CarsGame.WebApp.Pages.Admin.Cars
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string Make { get; set; }

        [BindProperty]
        public string Model { get; set; }

        [BindProperty]
        public int Year { get; set; }

        [BindProperty]
        public int Doors { get; set; }

        [BindProperty]
        public string Color { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        private readonly CarService carService;

        public CreateModel(CarService carService)
        {
            this.carService = carService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var car = Car.Create(Make, Model, Year, Doors, Color, Price);

            carService.CrateCar(car);

            return RedirectToPage("/Admin/Cars/Index");
        }
    }
}
