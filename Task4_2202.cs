namespace DotNetInterns;
class Task4_2202{

    //To Check Input Number is Palindrome Or Not
    public static void Palindrome(){
        try{
            Console.Write("Enter Number :");
            int n=Convert.ToInt32(Console.ReadLine());
            int A=0;
            while(n>0){
                int r=n%10;
                A=(A*10)+r;
                n=n/10;
            }
           
            if(A==n){
                Console.WriteLine($"{A} Is Palindrome Number");
            }else{
                Console.WriteLine($"{A} Is Not Palindrome Number");
            }

        }catch(FormatException FE){
            Console.WriteLine("Input Digit Only");

        }
    }
}