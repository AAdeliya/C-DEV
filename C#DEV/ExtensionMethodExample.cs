namespace ExtensionMethodExample
{
    // Static class to hold the extension method
    public static class StringExtensions
    {
        // Extension method for the string class
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            return str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class Program
    {
        static void Main()
        {
            string sentence = "Hello, this is an extension method example!";
            int count = sentence.WordCount();  // Calling the extension method

            Console.WriteLine($"Word count: {count}");  // Output: Word count: 7
        }
    }
}