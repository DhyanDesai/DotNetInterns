using System;

namespace Inheritance_demo
{
    public class A
    {
        public int a = 20, b = 10;
    }

    //single level inheritance
    public class B : A
    {
        public int Sum()
        {
            int sum = a + b;
            return sum;
        }
    }

    // Hierarchical inheritance
    public class C : A
    {
        public int Sub()
        {
            int sub = a - b;
            return sub;
        }
    }

    // Multi-level inheritance
    public class D : B
    {
        public void Sum1()
        {
            int c = 40;
            int sum1 = Sum() + c;
            Console.WriteLine("Sum1: " + sum1);
        }
    }

    public class Main_class
    {
        public static void Main(string[] args)
        {
            B b = new B();
            C c = new C();
            D d = new D(); // Instantiate an object of class D

            Console.WriteLine("Sum from B: " + b.Sum());
            Console.WriteLine("Sub from C: " + c.Sub());
            d.Sum1(); // Call Sum1() method of class D
        }
    }
}
