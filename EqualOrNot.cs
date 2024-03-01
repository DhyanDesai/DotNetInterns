namespace DotNetInterns
{
    class EqualOrNot
    {
        public void Equal(){
            
            int number1,number2;
            Console.WriteLine("Enter First Number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            number2 = Convert.ToInt32(Console.ReadLine());

            if(number1==number2){
                Console.WriteLine("{0} and {1} are equal.",number1,number2);
            }
            else{
                Console.WriteLine("{0} and {1} are not equal.",number1,number2);
            }
        }
    }
}