class Program
{
    static void Main(string[] args)
    {
        // Exempel på olika datatyper
        int heltal = 10;
        double temp = 36.6;
        string name = "Lisa";
        bool hasLicense = true;

        Console.WriteLine("Namn: " + name);
        Console.WriteLine("Heltal: " + heltal);
        Console.WriteLine("Temperatur: " + temp);
        Console.WriteLine("Har körkort? " + hasLicense);
        Console.WriteLine();

        // Operatorer
        int num1 = 5;
        int num2 = 3;
        int sum = num1 + num2;
        int product = num1 * num2;

        Console.WriteLine("num1 + num2 = " + sum);
        Console.WriteLine("num1 * num2 = " + product);
        Console.WriteLine();

        // Typkonvertering (string → int)
        Console.WriteLine("Mata in ett heltal:");
        string input = Console.ReadLine() ?? "0";

        // Försök konvertera
        int convertedNumber = int.Parse(input);
        Console.WriteLine("Du skrev: " + convertedNumber);
        Console.WriteLine("Tal + 10 blir: " + (convertedNumber + 10));
        Console.WriteLine();

        // Konstant
        const int daysPerWeek = 7;
        Console.WriteLine("Antal dagar på en vecka: " + daysPerWeek);

        // Demonstrera ++ operator
        int counter = 0;
        counter++;
        Console.WriteLine("Räknare efter ++: " + counter);
    }
}
