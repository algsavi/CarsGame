using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarsGame.Domain.Car;
using CarsGame.Application;

namespace CarsGame.WebApp.Pages.Game
{
    public class GameTryModel : PageModel
    {
        private readonly CarService carService;

        [BindProperty]
        public Car Car { get; set; }
        
        [BindProperty]
        public decimal Price { get; set; }

        public GameTryModel(CarService carService)
        {
            this.carService = carService;
        }

        public IActionResult OnGet(Guid id)
        {
            Car = carService.GetById(id);

            if (Car == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Game/Game");
        }
    }
}
