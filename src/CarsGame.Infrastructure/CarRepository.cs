using CarsGame.Domain.Car;

namespace CarsGame.Infrastructure;

public class CarRepository : ICarRepository
{
    private static List<Car> cars = new List<Car>();

    public CarRepository()
    {
        cars.Add(Car.Create("Audi", "R8", 2018, 2, "Red", 79995));
        cars.Add(Car.Create("Tesla", "3", 2018, 4, "Black", 54995));
        cars.Add(Car.Create("Porsche", "911 991", 2020, 2, "White", 155000));
        cars.Add(Car.Create("Mercedes-Benz", "GLE 63S", 2021, 5, "Blue", 83995));
        cars.Add(Car.Create("BMW", "X6 M", 2020, 5, "Silver", 62995));
    }

    public Car? GetById(Guid id)
    {
        return cars.FirstOrDefault(car => car.Id == id);
    }

    public Car? GetByModel(string model)
    {
        return cars.FirstOrDefault(car => car.Model == model);
    }

    public IEnumerable<Car> GetAll()
    {
        return cars.ToList();
    }

    public void Create(Car car)
    {
        cars.Add(car);
    }

    public void Update(Car car)
    {
        var carToUpdateIndex = cars.FindIndex(c => c.Id == car.Id);

        if (carToUpdateIndex != -1)
        {
            cars[carToUpdateIndex] = car;
        }
    }

    public void Delete(Guid id)
    {
        var car = GetById(id);

        if (car != null)
        {
            cars.Remove(car);
        }
    }
}