// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Hi " + name);


static void Main()
{
    BaseClass obj = new DerivedClass();
    obj.ShowMessage();
}
//Use the sealed keyword to prevent further overriding in subclasses.