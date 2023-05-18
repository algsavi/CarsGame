using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarsGame.Application;

namespace CarsGame.WebApp.Pages.Game
{
    public class GameModel : PageModel
    {
        private readonly CarService carService;

        [BindProperty]
        public decimal Price { get; set; }

        public GameModel(CarService carService)
        {
            this.carService = carService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostTry(Guid id)
        {
            carService.DeleteCar(id);
            return RedirectToPage();
        }
    }
}
