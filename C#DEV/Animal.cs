class Animal
{
    // Virtual method to allow overriding
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // Overriding base class method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    // Overriding base class method
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class ProgramClass2
{
    static void Main()
    {
        Animal myAnimal;

        myAnimal = new Dog();
        myAnimal.MakeSound();  // Output: Dog barks

        myAnimal = new Cat();
        myAnimal.MakeSound();  // Output: Cat meows
    }

}