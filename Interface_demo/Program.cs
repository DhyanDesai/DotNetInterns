/*Definition:

Interface: An interface defines a contract for a class by specifying a set of method signatures that the class must implement. It only contains method declarations without implementations.
Abstract Class: An abstract class is a class that cannot be instantiated and may contain abstract methods (methods without implementations) as well as concrete methods (methods with implementations). It can also contain fields, properties, constructors, and other members like a regular class.
Multiple Inheritance:

Interface: In C#, a class can IMPLEMENT MULTIPLE INHERITANCE. This allows for a class to inherit behavior from multiple sources.
Abstract Class: C# does not support multiple inheritance for classes. A class can inherit from only one abstract class, limiting its ability to inherit behavior from multiple sources.
Implementation:

Interface: All methods declared in an interface must be implemented by any class that implements that interface. Interfaces provide a way to achieve polymorphism and enable loosely coupled designs.
Abstract Class: Abstract classes can have both abstract methods (which must be implemented by derived classes) and concrete methods (which can be inherited as-is or overridden by derived classes). Abstract classes can also contain state (fields) and implementation details.
Access Modifiers:

Interface: Interface members are implicitly public and cannot have access modifiers (except for explicit interface implementation).
Abstract Class: Abstract class members can have different access modifiers, allowing for more fine-grained control over visibility and accessibility.
Usage:

Interface: Use interfaces when you want to define a contract for a set of classes to implement common behavior, especially when you have different classes that need to share common functionality but do not share a common ancestor.
Abstract Class: Use abstract classes when you want to provide a default implementation for certain methods or when you want to define a common base for a group of related classes. Abstract classes are useful when you want to provide a partial implementation that derived classes can extend or customize.
*/


//multiple inheritance 

using System;

namespace Interface{

    public interface IA{
        public int method1();
        public string method2();
    }

    public interface IB{
        public int method3();
        public string method4();
    }

    /*public class A : IA{
        public int method1()
        {
            int i = 10, j=20;
            int c = i+j;
            return c;
        }
        public string method2()
        {
            string s = "Tina";
            return s;
        }
    }

    public class B : IB{
        public int method3()
        {
            int i = 50, j=60;
            int c = i+j;
            return c;
        }
        public string method4()
        {
            string s = "princy";
            return s;
        }
    }*/

    public class C : IA,IB{
        public int method1()
        {
            int i = 10, j=20;
            int c = i+j;
            return c;
        }
        public string method2()
        {
            string s = "Tina";
            return s;
        }
        public int method3()
        {
            int i = 50, j=60;
            int c = i+j;
            return c;
        }
        public string method4()
        {
            string s = "princy";
            return s;
        }
    }
    public class D{
        public static void Main(string[] args)
        {
            //A a = new A();
           // B b = new B();
            C c = new C();
            
            // Console.WriteLine(a.method1());
            // Console.WriteLine(a.method2());
            // Console.WriteLine(b.method3());
            // Console.WriteLine(b.method4());
            Console.WriteLine(c.method1());
            Console.WriteLine(c.method2());
            Console.WriteLine(c.method3());
            Console.WriteLine(c.method4());
            
            
        }
    }
    
}

