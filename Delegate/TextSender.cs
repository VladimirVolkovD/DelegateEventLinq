namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class TextSender
    {
        public static void PrintTextForSent(string text)
        {
            Console.WriteLine($"Body: {text}");
        }

        public static void PrintHelloRus()
        {
            Console.WriteLine("HelloRus");
        }        
    }
}