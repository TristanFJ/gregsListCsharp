using gregsListCsharp.DB;
using gregsListCsharp.Models;

namespace gregsListCsharp.Services
{
  public class CarsService
  {
    internal List<Car> Get()
    {
      return FakeDB.Cars;
    }

    internal Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }

    internal Car Update(Car updatedCar)
    {
      Car oldCar = Get(updatedCar.Id);
      oldCar.Year = updatedCar.Year != 0 ? updatedCar.Year : oldCar.Year;
      oldCar.Model = updatedCar.Model != null ? updatedCar.Model : oldCar.Model;
      oldCar.Make = updatedCar.Make != null ? updatedCar.Make : oldCar.Make;
      oldCar.Price = updatedCar.Price != 0 ? updatedCar.Price : oldCar.Price;

      return oldCar;
    }

    internal void Remove(string id)
    {
      Car car = Get(id);
      FakeDB.Cars.Remove(car);
    }
  }
}