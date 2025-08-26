class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hej och välkommen till C#!");

        Console.WriteLine("Mata in ditt namn:");
        string? namn = Console.ReadLine();

        Console.WriteLine("Hej " + namn + ", kul att du är här!");
    }
}
