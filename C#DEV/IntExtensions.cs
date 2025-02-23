public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}

class Program3
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine(num.IsEven());  // Output: True
    }
}