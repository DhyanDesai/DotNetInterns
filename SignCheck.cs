namespace DotNetInterns
{
    class SignCheck
    {
        public void sign(){
            int numberCheck;
            Console.WriteLine("Enter a Number");
            numberCheck = Convert.ToInt32(Console.ReadLine());

            if(numberCheck == 0){
                Console.WriteLine("{0} is 0.", numberCheck);
            }
            else if(numberCheck > 0){
                Console.WriteLine("{0} is a positive number.",numberCheck);
            }else{
                Console.WriteLine("{0} is a negative number.",numberCheck);
            }
        }
    }
}