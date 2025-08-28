class Program
{
    static void Main()
    {
        // if + logical operators
        int temperature = 9;
        string season = "winter";
        string headwear;

        if (temperature <= 8 && season == "winter" || temperature >= 8 && season == "summer")
        {
            headwear = "Beanie";
        }
        else
        {
            headwear = "Cap";
        }

        Console.WriteLine("It is " + temperature + "°C and " + season + ", wear: " + headwear);

        // if - else if - else
        int busDelay = 0;
        if (busDelay > 5)
        {
            Console.WriteLine("The bus is late, take the subway!");
        }
        else if (busDelay > 0)
        {
            Console.WriteLine("The bus is a little late, wait for it.");
        }
        else
        {
            Console.WriteLine("The bus is on time - hooray!");
        }

        // switch
        int number = 2;
        switch (number)
        {
            case 0:
                Console.WriteLine("The number is: " + number);
                break;
            case 1:
                Console.WriteLine("The number is: " + number);
                break;
            case 2:
                Console.WriteLine("The number is: " + number);
                break;
            default:
                Console.WriteLine("The number is something else!");
                break;
        }

        // ternary operator
        int choice = -1;
        string message = choice != 1 ? "not equal to 1" : "equal to 1";
        Console.WriteLine($"Value is {message}");

        // scope
        int testNumberOne = 10;
        if (testNumberOne > 5)
        {
            int testNumberTwo = 20;
            Console.WriteLine($"Inside if: testNumber = {testNumberOne}, testNumberTwo = {testNumberTwo}");
        }
    }
}