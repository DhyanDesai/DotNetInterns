using System;
namespace InterfaceProgram
{
    public interface IShape
    {
        public void CalculateArea(double l, double w);
        public void CalculateArea(double l);
    }

    public class AreaRect : IShape
    {
        public void CalculateArea(double l, double w)
        {
          
            double area = l * w;
            Console.WriteLine($"Area of rectangle: {area}");
        }
        public void CalculateArea(double l)
        {
            
            double area = l * l;
            Console.WriteLine($"Area of square : {area}");
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
