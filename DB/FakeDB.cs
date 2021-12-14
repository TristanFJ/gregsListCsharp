using gregsListCsharp.Models;
namespace gregsListCsharp.DB
{
  public static class FakeDB
  {
    public static List<Car>? Cars { get; set; } = new List<Car>(){
      new Car(2020, "Zoomy fast", "Kit Meow", 30000, false),
      new Car(2021, "Cybertruck", "Make", 30346, true)
    };
  }
}