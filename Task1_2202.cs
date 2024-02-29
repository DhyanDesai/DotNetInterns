namespace DotNetInterns;

class Task1_2202{
    public static void Sum_Of_Digit(){
        try{
            Console.Write("Enter Number :");
            int A=Convert.ToInt32(Console.ReadLine());

            int r,Sum=0;

            while(A>0){
                r=A%10;
                Sum+=r;
                A=A/10;
            }

            Console.WriteLine($"Result {Sum}");
            
        }catch(FormatException FE){
            Console.WriteLine("Input Number Only ");

        }
    }
}