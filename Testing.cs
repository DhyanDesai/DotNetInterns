namespace DotNetInterns;

class Testing{

//   This Code Is For Check The Largest Number From The User Input
    public void Largestst_Num(){

        int A,B,C; 
        try{ 
            Console.WriteLine("Enter First Number :");
            A=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Second Number :");
            B=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Third Number :");
            C=Convert.ToInt32(Console.ReadLine());
    
            int Largest_No;
    
    
            if(A>B && A>C){
            
                Largest_No=A;
            
            } else if (B>A && B>C) {
                
                Largest_No=B;
            
            } else {
            
                Largest_No=C;
            }
    
             Console.WriteLine($"Largest Number Is {Largest_No}");
    
        }catch(Exception Ex){
    
            Console.WriteLine("String Input Can't Be Except");
        }
    }
}