using CarsGame.Domain.Car;

namespace CarsGame.Application;

public class CarService
{
    private readonly ICarRepository carsRepository;

    public CarService(ICarRepository carRepository)
    {
        carsRepository = carRepository;
    }

    public Car? GetById(Guid id)
    {
        return carsRepository.GetById(id);
    }

    public Car? GetByModel(string model)
    {
        return carsRepository.GetByModel(model);
    }

    public IEnumerable<Car> GetAll()
    {
        return carsRepository.GetAll();
    }

    public void CrateCar(Car car)
    {
        carsRepository.Create(car);
    }

    public void UpdateCar(Car car)
    {
        carsRepository.Update(car);
    }

    public void DeleteCar(Guid id)
    {
        carsRepository.Delete(id);
    }
}
