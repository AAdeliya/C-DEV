interface IFlyable
{
    void Fly();
    int MaxAltitude { get; } //abstract property

    //Defaut implementation in C# 8.0+
    string GetFlightInfo()
    {
        return "Flight information not available";
    }
}

interface ISwimmable
{
    void Swim();
}

class Bird : IFlyable
{
    public int MaxAltitude { get; } = 1000; //Implementing interface property
    public void Fly()
    {
        Console.WriteLine("bird is flying");
    }
}

class Fish : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Fish is swimming");
    }
}

class Airplane : IFlyable
{
    public int MaxAltitude { get; } = 40000;
    public void Fly()
    {
        Console.WriteLine("Airplane is flying");
    }

    //Overriding default implementation (optional)
    public string GetFlightInfo()
    {
        return $"Airplane max altitude: {MaxAltitude} feet";

    }

}

public class ExampleInterface
{
    public static Run()
    {
        Bird bird = new Bird();
        Airplane airplane = new Airplane();
        Fish fish = new Fish();

        List<IFlyable> flyingObjects = new List<IFlyable>();
        flyingObjects.Add(bird);
        flyingObjects.Add(airplane);

        foreach (var flyer in flyingObjects)
        {
            flyer.Fly();
            Console.WriteLine(flyer.GetFlightInfo());
        }

        fish.Swim();
    }
}