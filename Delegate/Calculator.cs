namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Calculator
    {
        public static int Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }

        public static int Myltiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
            return x * y;
        }
    }
}