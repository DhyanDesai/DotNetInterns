using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClass_MethodOverloading
{
    public class Method_Calculate : Calculate
    {
        public override void Add(double a, double b, double c)
        {
            double sum = a + b + c;
            Console.WriteLine($"Sum is {sum}");
        }
        public override void Subtract(double a, double b)
        {
            double sub = a - b;
            Console.WriteLine($"Sub is {sub}");
        }
        public override void Multiply(double a)
        {
            double mul = a * a;
            Console.WriteLine($"Mul is {mul}");
        }
        public override void Divide(double a, double b)
        {
            double div = a / b;
            Console.WriteLine($"Div is {div}");
        }
    }
}