class Program
{
    public static void Main(string[] args)
    {
        Bird b = new Bird();
        Cat c = new Cat();
        Dog d = new Dog();

        b.Chirp();
        c.Meow();
        d.Bark();

        Console.WriteLine(args[0]);
        Console.WriteLine(args[1]);
        Console.WriteLine(args[2]);
    }
}