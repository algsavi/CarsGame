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

        public Car Car { get; set; }

        public IActionResult OnGet(Guid id)
        {
            Car = carService.GetById(id);

            if (Car == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(Car car)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            carService.UpdateCar(Car);

            return RedirectToPage("Index");
        }
    }
}
