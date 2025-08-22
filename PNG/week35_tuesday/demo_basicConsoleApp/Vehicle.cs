class Vehicle(string type)
{
  public string Type { get; set; } = type;

  public void PrintType()
  {
    Console.WriteLine($"This vehicle is a {Type}");
  }
}