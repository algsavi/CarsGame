namespace CarsGame.Domain.Car;

public class Car : Entity
{
    public string Make { get; private set; }
    public string Model { get; private set; }
    public int Year { get; private set; }
    public int Doors { get; private set; }
    public string Color { get; private set; }
    public decimal Price { get; private set; }

    public Car()
    {
    }

    public static Car Create(string make, string model, int year, int doors, string color, decimal price)
    {
        if (string.IsNullOrEmpty(make))
        {
            throw new ArgumentException("Please inform a valid [MAKE]");
        }

        if (string.IsNullOrEmpty(model))
        {
            throw new ArgumentException("Please inform a valid [MODEL]");
        }

        if (year <= 0)
        {
            throw new ArgumentException("Please inform a valid [YEAR]");
        }

        if (doors <= 0)
        {
            throw new ArgumentException("Please inform a valid number of [DOORS]");
        }

        if (string.IsNullOrEmpty(color))
        {
            throw new ArgumentException("Please inform a valid [COLOR]");
        }

        if (price <= 0)
        {
            throw new ArgumentException("Please inform a valid [PRICE]");
        }

        var car = new Car
        {
            Id = Guid.NewGuid(),
            Make = make,
            Model = model,
            Year = year,
            Doors = doors,
            Color = color,
            Price = price,
        };

        return car;
    }

    public static Car Update(Guid id, string make, string model, int year, int doors, string color, decimal price)
    {
        var car = new Car
        {
            Id = id,
            Make = make,
            Model = model,
            Year = year,
            Doors = doors,
            Color = color,
            Price = price,
        };

        return car;
    }
}