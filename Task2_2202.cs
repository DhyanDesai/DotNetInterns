using System.Runtime.CompilerServices;

namespace DotNetInterns;

class Task2_2202{

// This Code Is Print Fibonacci Series
    
    public static void Fibonacci(){
        try{
            Console.Write("Enter Number :");
            int n=Convert.ToInt32(Console.ReadLine());

            int A=0,B=1,temp=0;
            Console.WriteLine(A);
            Console.WriteLine(B);

            for(int i=0;i<=n;i++){
                temp=A+B; 
                A=B;
                B=temp;
                Console.WriteLine(temp);
            }

        }catch(FormatException e){
            Console.WriteLine("Input Digits Only");

        }
    } 
}
