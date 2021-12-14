using gregsListCsharp.Models;
namespace gregsListCsharp.DB
{
  public static class FakeDB
  {
    public static List<Car>? Cars { get; set; } = new List<Car>(){
      new Car(2020, "Model", "Make", 30000),
      new Car(2021, "Model", "Make", 30346)
    };
  }
}