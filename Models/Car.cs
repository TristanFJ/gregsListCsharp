using System.ComponentModel.DataAnnotations;

namespace gregsListCsharp.Models
{
  public class Car
  {
    public string? Id { get; set; }

    public int Year { get; set; }

    public string? Model { get; set; }

    public string? Make { get; set; }

    public int Price { get; set; }

    public Car(int year, string? model, string? make, int price)
    {
      Id = Guid.NewGuid().ToString();
      Year = year;
      Model = model;
      Make = make;
      Price = price;
    }
  }
}