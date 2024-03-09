using System;
using System.Threading;

namespace Treading_lock
{
    class Thread_Lock
    {
        static object lockObject =new object();
        public static void Main(string[]args)
        {
            Thread t1 = new Thread(SomeMethod)
            {
                Name="Thread1"
            };
            Thread t2 = new Thread(SomeMethod)
            {
                Name="Thread2"
            };
            Thread t3 = new Thread(SomeMethod)
            {
                Name="Thread3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            
        }
        public static void SomeMethod()
        {
            lock(lockObject)
            {
                Console.Write("[Welcome To The ");
                Thread.Sleep(1000);
                Console.WriteLine("World of Dotnet!]");
            }
        }
    }
}
