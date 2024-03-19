using System;
namespace InterfaceProgram
{
    public interface IShape
    {
        public void CalculateArea(double l, double w);
        public void CalculateArea(double r);
    }

    public class AreaRect : IShape
    {
        public void CalculateArea(double l, double w)
        {
            // Console.WriteLine("Enter length:");
            // double l = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter width:");
            // double w = Convert.ToDouble(Console.ReadLine());
            double area = l * w;
            Console.WriteLine($"Area of rectangle: {area}");
        }
        public void CalculateArea(double r)
        {
            // Console.WriteLine("Enter radius:");
            // double r = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * r * r;
            Console.WriteLine($"Area of Circle: {area}");
        }
        

    }
   
    public class Area
    {
        public static void Main(String[] args)
        {
            IShape ar = new AreaRect();
            ar.CalculateArea(20.0, 40.0);
            ar.CalculateArea(20.0);
        }
    }
}
