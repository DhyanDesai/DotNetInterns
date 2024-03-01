namespace DotNetInterns
{
    class Prime
    {
        public void prime(){
            int inputCheckPrime,counter = 0;   
            Console.WriteLine("Enter the Number: ");    
            inputCheckPrime = Convert.ToInt32(Console.ReadLine());      
            for(int i = 2; i <= inputCheckPrime/2 ; i++)    
            {    
            if(inputCheckPrime % i == 0)    
                {    
                Console.WriteLine("Number is not Prime.");    
                counter=1;    
                break;    
                }    
            }    
            if (counter==0){    
            Console.WriteLine("Number is Prime.");
            }
        }
    }
}