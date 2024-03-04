namespace PracticePrograms
{
    class SingleMultiDelegates
    {



         public static void PrintName(string name)
    {
        Console.WriteLine($"I'm :{name}");

    }





        public static double addition(double a, double b)
        {
            Console.WriteLine("Addition is: {0}", a + b);
            return a + b;

        }
        public static double subtrac(double a, double b)
        {
            Console.WriteLine("Subtraction is: {0}", a - b);
            return a - b;

        }
        public static double multi(double a, double b)
        {
            Console.WriteLine("Multiplication is: {0}", a * b);
            return a * b;

        }
        public static double division(double a, double b)
        {
            Console.WriteLine("division is: {0}", a / b);
            return a / b;

        }

    }
}