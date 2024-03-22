namespace Encapsulation;

class Program
{
    static void Main(string[] args)
    {
     Shape shape = new Shape();
    //  shape.SetDetails(5,10);
    //  shape.CalculateArea();
    //  shape.GetDetails();
    System.Console.Write("Enter the Height: ");
    shape._heigth=Convert.ToDouble(Console.ReadLine());
     System.Console.Write("Enter the Width: ");
    shape._width=Convert.ToDouble(Console.ReadLine());
    shape.CalculateArea();
    
    }
}
