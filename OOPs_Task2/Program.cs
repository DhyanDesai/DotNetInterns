using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPs_Task2
{
    public class Calculate_Area
    {
        public static void Main(string [] args)
        {
            Shape s = new Shape();
            s.Height = 10.15;
            s.Width = 12.5;

            double Area = s.Height * s.Width ;
            Console.WriteLine($"Area :{Area}");
        }
    }
}
