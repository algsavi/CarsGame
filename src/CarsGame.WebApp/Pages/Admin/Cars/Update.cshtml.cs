using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarsGame.Domain.Car;
using CarsGame.Application;

namespace CarsGame.WebApp.Pages.Admin.Cars
{
    public class UpdateModel : PageModel
    {
        private readonly CarService carService;

        public UpdateModel(CarService carService)
        {
            this.carService = carService;
        }

        [BindProperty]
        public Guid Id { get; set; }

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

        public IActionResult OnGet(Guid id)
        {
            var car = carService.GetById(id);

            if (car == null)
            {
                return NotFound();
            }

            Make = car.Make;
            Model = car.Model;
            Year = car.Year;
            Doors = car.Doors;
            Color = car.Color;
            Price = car.Price;

            return Page();
        }

        public IActionResult OnPost()
        {
            var existingCar = carService.GetById(Id);

            if (existingCar == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            existingCar = Car.Update(Id, Make, Model, Year, Doors, Color, Price);

            carService.UpdateCar(existingCar);

            return RedirectToPage("Index");
        }
    }
}
