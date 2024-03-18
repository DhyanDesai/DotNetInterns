/*Definition:

Interface: An interface defines a contract for a class by specifying a set of method signatures that the class must implement. It only contains method declarations without implementations.
Abstract Class: An abstract class is a class that cannot be instantiated and may contain abstract methods (methods without implementations) as well as concrete methods (methods with implementations). It can also contain fields, properties, constructors, and other members like a regular class.
Multiple Inheritance:

Interface: In C#, a class can implement multiple interfaces. This allows for a class to inherit behavior from multiple sources.
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

using System;

namespace AbstractDemo
{
    public abstract class AbstractDemo
    {
        public int a=20, b=10;
        public abstract void sub();
        public abstract void div();
        public void add()
        {
            int sum = a+b;
            System.Console.WriteLine(sum);
        }
        public void mul()
        {
            int mul = a*b;
            System.Console.WriteLine(mul);
        }
        
    }

    public class AbstractDemo1 : AbstractDemo
    {
        public override void sub()
        {
            int sub = a-b;
            System.Console.WriteLine(sub);
        }

        public override void div()
        {
            int div = a/b;
            System.Console.WriteLine(div);
        }
    }

    public class AbstractDemo2
    {
        public static void Main(string [] args)
        {
            AbstractDemo1 ab = new AbstractDemo1();
            ab.add();
            ab.mul();
            ab.div();
            ab.sub();
        }
    }
}

