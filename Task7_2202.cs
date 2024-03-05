namespace DotNetInterns;
class Task7_2202{
    public static void Armstrong(){
        try{
            Console.WriteLine("Enter Number");
            int n=Convert.ToInt32(Console.ReadLine());
            int num=0,A=0,r=0;
            
            while(n>0){
                 r=n%10;
                 
                //  A=(A*10)+r;
                //  Console.Write(A);
                // //num=r*n;
                // int C=A%10;
                //  D=(C*10)+C;
                n=n/10;
                Console.Write("Reminer :"+r);
                
            }
            int[] B=new int[r];
            foreach (int N in B){
                Console.WriteLine("Result :"+N);
            }
            
                 
                 //Console.Write(A);
            
        }catch(FormatException Fe){
            Console.WriteLine("Input Digits Only");


        }
    }
}