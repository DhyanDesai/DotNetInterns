using System;
namespace ConstructorDemo
{
    class Constructor1
    {
        public int sum;
        public Constructor1(int i, int j)
        {
            sum = i + j;
             
        }
        public Constructor1(Constructor1 cons, int k)
        {

            sum = cons.sum + k;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Constructor1 cons = new Constructor1(10, 20);
            Constructor1 cons2 = new Constructor1(cons,30);
            System.Console.WriteLine($"sum :{cons.sum}");   
            System.Console.WriteLine($"sum :{cons2.sum}"); 
            System.Console.WriteLine("Constructor done...");
        }
    }
    
}

