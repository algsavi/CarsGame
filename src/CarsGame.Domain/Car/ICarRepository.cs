namespace CarsGame.Domain.Car;

public interface ICarRepository
{
    Car? GetById(Guid id);
    Car? GetByModel(string name);
    IEnumerable<Car> GetAll();
    void Create(Car car);
    void Update(Car car);
    void Delete(Guid id);
}
