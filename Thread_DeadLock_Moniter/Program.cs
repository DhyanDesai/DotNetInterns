using System;
using System.Threading;

class MonitorTryEnterExample
{
    static object lockObject = new object();

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
        // Attempt to acquire the lock
        if (Monitor.TryEnter(lockObject))
        {
            try
            {
                Console.WriteLine("Method1 acquired the lock");

                // Perform some work while holding the lock
                Thread.Sleep(1000);
            }
            finally
            {
                Monitor.Exit(lockObject);
                Console.WriteLine("Method1 released the lock");
            }
        }
        else
        {
            Console.WriteLine("Method1 couldn't acquire the lock immediately");
        }
    }

    static void Method2()
    {
        // Attempt to acquire the lock
        if (Monitor.TryEnter(lockObject))
        {
            try
            {
                Console.WriteLine("Method2 acquired the lock");

                // Perform some work while holding the lock
                Thread.Sleep(1000);
            }
            finally
            {
                Monitor.Exit(lockObject);
                Console.WriteLine("Method2 released the lock");
            }
        }
        else
        {
            Console.WriteLine("Method2 couldn't acquire the lock immediately");
        }
    }
}

