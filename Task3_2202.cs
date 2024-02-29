namespace DotNetInterns;
class Task3_2202{

    // Code is For Check Wether Number is Prime Or Not
    public static void prime(){
        try{
            Console.WriteLine("Enter Number :");
            int n=Convert.ToInt32(Console.ReadLine());
            int A=0;
            for(int i=1;i>=A;i++){
                if(A%i==0){
                    A++;
                }
            }
            if(A==2){
                Console.WriteLine($"{n} is Prime Number");
            }else{
                Console.WriteLine($"{n} is Not Prime Number");
            }

        }catch(FormatException FE){
            Console.WriteLine("Input Digit Only");
        }
    }
}