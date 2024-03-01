namespace DotNetInterns
{
    class Factorial
    {
        public void factorial(){
            int factorial(int factValue){
                if(factValue == 0){
                    return 1;
                }
                else{
                    return (factValue * factorial(factValue - 1));
                }
            }

            int numberFact,ansFactorial;
            Console.WriteLine("Enter a number");
            numberFact = Convert.ToInt32(Console.ReadLine());
            ansFactorial = factorial(numberFact);
            Console.WriteLine("Factorial of {0} is {1}",numberFact,ansFactorial);
        }
    }
}