namespace Encapsulation{
    public class Shape{
        private double height;
        private double width;
        public double _heigth{get{
            return height;
        }set{
            height = value;
        }}
        public double _width{get{
            return width;

        }set{
            width = value;
        }}
        // public (double heigth,double width) GetDetails(){
        //     System.Console.WriteLine($"heigth:{height},Width:{width}");
        //     return (height,width);
        // }
        //   public void SetDetails(double height,double width){
        //     this.height = height;
        //     this.width = width;
        // }
        public double CalculateArea(){
            double area = height * width;
            Console.WriteLine($"Area of the shape is: {area}");
            return area;
        }
    }
}