//deadlock situation occur
//A deadlock in C# occurs when two or more threads are blocked forever, each waiting for the other to release a lock. 
//Here's a simple example of a deadlock and a potential solution using the Monitor class to avoid deadlocks:


using System;
using System.Threading;

class DeadlockExample
{
    static object lock1 = new object();
    static object lock2 = new object();

    static void Main()
    {
        Thread thread1 = new Thread(Method1);
        Thread thread2 = new Thread(Method2);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Execution completed.");
    }

    static void Method1()
    {
        lock (lock1)
        {
            Console.WriteLine("Method1 acquired lock1");

            // Introducing a delay to make the deadlock more likely
            Thread.Sleep(100);

            lock (lock2)
            {
                Console.WriteLine("Method1 acquired lock2");
            }
        }
    }

    static void Method2()
    {
        lock (lock2)
        {
            Console.WriteLine("Method2 acquired lock2");

            // Introducing a delay to make the deadlock more likely
            Thread.Sleep(100);

            lock (lock1)
            {
                Console.WriteLine("Method2 acquired lock1");
            }
        }
    }
}


