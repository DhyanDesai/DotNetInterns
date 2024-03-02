using System;

namespace DelegatesDemoFile{
     
     public delegate void Square(double length);  //creating delegate
     class  Area{
        public static void Main(string[] args){
            try{
                Square sq;
                Square asq = new Square(CalculateArea);   //delegate instance
                Square psq = new Square(CalculatePerimeter);    //delegate instance
                //Square asq = len => Console.WriteLine($"Area of Square: {len * len}");    //lamda expression
                //Square psq = len => Console.WriteLine($"Perimeter of Square: {4 * len}");  //lamda expression
                Console.WriteLine("Enter length: ");
                double len = Convert.ToDouble(Console.ReadLine());
                sq = asq;
                sq += psq; //compose or merge delegate     
                //sq -= psq; //for removing delegate
                sq(len);
                
            }
            catch(Exception e){
                Console.WriteLine($"Enter valid input: {e.Message}");

            }
        }
        public static void CalculateArea(double len){
            double area = len * len;
            Console.WriteLine($"Area of square: {area}");
        }

        public static void CalculatePerimeter(double len){
            double peri = 4 * len;
            Console.WriteLine($"Perimeter of square: {peri}");
        }
    }
}