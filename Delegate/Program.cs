using Delegate.PhoneStore;

namespace MyApp
{
    public partial class Program
    {
        delegate void PrintText(string t);
        public delegate int Operation(int x, int y);

        delegate int OperationGeneric<T>(T x, T y);

        static void Main(string[] args)
        {
            TaskEvent();
            TaskDelegate();
        }

        private static void TaskDelegate()
        {
            string date = "16/5/2023";

            Action message = delegate ()
            {
                Console.WriteLine("Hello world from anon method " + date);
            };

            message = () =>
            {
                Console.WriteLine("Hello world from anon method ");
                Console.WriteLine(date);
            };


            message();


            Operation operation;
            OperationGeneric<int> operationGeneric;

            Calculator.Add(1, 2);

            operation = (x, y) => x + y;
            operation += Calculator.Add;
            operation += Calculator.Myltiply;
            operation += Calculator.Subtract;
            operation += (x, y) => x - y;
            operation -= (x, y) => x - y;

            operationGeneric = Calculator.Add;

            Console.WriteLine(DoOperation(2, 6,
                delegate (int x, int y)
                {
                    return x + y;
                }));

            Console.WriteLine(DoOperation(2, 6, (x, y) => x + y));



            Console.WriteLine(DoOperation(2, 6, Calculator.Add));

            operation = SelectOperation(OperationType.Add);
            Console.WriteLine(DoOperation(2, 6, operation));
        }

        private static void TaskEvent()
        {
            var appleStore = new AppleStore();
            var shopVladimir = new VladimirShop();
            var shopIvan = new IvanShop();

            appleStore.notify += shopVladimir.SellNotification;
            appleStore.notify += shopIvan.SellNotification;

            List<Phone> phones = new List<Phone>()
            {
                new Phone("Iphone 13",800),
                new Phone("Iphone 13 max",900),
                new Phone("Iphone 14",1000),
                new Phone("Iphone 14 max",1100),
            };

            var result = phones.Select(x => x.name.Contains("max"));
            var resultPhones = phones.Where(x => x.name.Contains("max"));

            phones.Reverse();

            //4
            var count = phones.Where(x => x.name.Contains("max")).OrderBy(x => x).Count();

            phones.Add(new Phone("Iphone 14", 1000));

            //4
            Console.WriteLine(count);

            appleStore.PutNewPhones(phones);
        }

        public static int DoOperation(int x, int y, Operation operation)
        {
            return operation(x, y);
        }

        public static Operation SelectOperation(OperationType operation)
        {
            switch (operation)
            {
                case OperationType.Add: return (x, y) => x + y;
                case OperationType.Myltiply: return Calculator.Myltiply;
                default: return Calculator.Subtract;
            }

        }

        public static void test1()
        {
            PrintText printTextOne;
            PrintText printTextSecond;

            printTextOne = PrintTextMessage;
            printTextSecond = TextSender.PrintTextForSent;
            PrintText finalText = printTextOne + printTextSecond;
            finalText("text");
            finalText?.Invoke("Text for delegate");
        }


        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        public static void PrintTextMessage(string message)
        {
            Console.WriteLine($"//{message}\\\\");
        }
    }
}