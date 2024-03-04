namespace DotNetInterns;
class Delegets_P2{
public delegate void RectengleDelegete(double Height,double Width);
public static void Area(double Height,double Width){

  Console.WriteLine($"Area Is {Height * Width}");
}
public static void Perimeter(double Height,double Width){
    Console.WriteLine($"Perimeter Is{2*(Height*Width)}");
}
}