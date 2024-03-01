namespace DotNetInterns
{
    class Fibonacci
    {
        public void fibonacci(){
            
            int initial1 = 0,initial2 = 1,series;
            Console.WriteLine("Enter required length of the series");  
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write(initial1+" "+initial2+" ");
            for (int i = 2;i < length;i++){
                series = initial1 + initial2;
                Console.Write(series +" ");
                initial1 = initial2;
                initial2 = series;
            }
        }
    }
}