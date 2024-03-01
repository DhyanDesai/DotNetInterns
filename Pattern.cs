namespace DotNetInterns
{
    class Pattern{
        public void printPattern(){
            /*that takes a number and a width also a number then displays a triangle of that width using that number*/


            int numberInput,widthInput;
            Console.WriteLine("Enter a number to print");
            numberInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a width");
            widthInput = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<= widthInput;i++){

                for(int j = widthInput-i;j > 0;j--){
                    Console.Write(numberInput);
                }
                
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }
}