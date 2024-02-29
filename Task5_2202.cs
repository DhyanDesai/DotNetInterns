namespace DotNetInterns;
class Task5_2202{
    // Find The Factorial Of Input Number
    public static void Factorial(){
        try{
            Console.Write("Enter Number :");
            int n=Convert.ToInt32(Console.ReadLine());
            int Result=1;
            for(int i=2;i<=n;i++){
                Result=Result*i;
            }
            Console.WriteLine("Result"+Result);

        }catch(FormatException FE){
            Console.WriteLine("Input Digits Only");
        }
    }
}