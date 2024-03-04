using System;
namespace DelegateDemo
{
    public class AnonymousMethods
    {
        public delegate string GreetingsDelegate(string name, int n);

        static void Main(string[] args)
        {
            string Message = "Welcome to Bangtan World";

            GreetingsDelegate gd = delegate (string name, int n)
            {
                return "Hello @" + name + " " + Message +" " + n;
            };

            string GreetingsMessage = gd.Invoke("tina", 7);
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
    }
}
