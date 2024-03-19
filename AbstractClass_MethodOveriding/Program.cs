using System;
namespace AbstractClass_MethodOverloading
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            Method_Calculate calc = new Method_Calculate();
            calc.Add(10, 20, 30);
            calc.Subtract(50, 20);
            calc.Multiply(40);
            calc.Divide(30, 2);
        }
    }
}

