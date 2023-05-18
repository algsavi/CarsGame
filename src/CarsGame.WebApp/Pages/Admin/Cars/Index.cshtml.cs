using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarsGame.Application;

namespace CarsGame.WebApp.Pages.Admin.Cars;

public class IndexModel : PageModel
{
    private readonly CarService carService;

    public IndexModel(CarService carService)
    {
        this.carService = carService;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPostDelete(Guid id)
    {
        carService.DeleteCar(id);
        return RedirectToPage();
    }
}
