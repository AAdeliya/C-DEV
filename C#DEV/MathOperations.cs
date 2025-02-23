class MathOperations
{
    // Method with two int parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method with three int parameters
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method with double parameters
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class ProgramClass
{
    static void Main()
    {
        MathOperations math = new MathOperations();

        Console.WriteLine(math.Add(5, 10));         // Output: 15
        Console.WriteLine(math.Add(5, 10, 20));     // Output: 35
        Console.WriteLine(math.Add(5.5, 2.3));      // Output: 7.8
    }

}