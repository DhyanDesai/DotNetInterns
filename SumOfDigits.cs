namespace DotNetInterns
{
    class SumOfDigits
    {
        public void sumofdigits(){
            int number;
            int total = 0, reminder;
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                 while (number > 0)
                {   
                    reminder = number % 10;
                    total = total + reminder;
                    number /= 10;
                }
                Console.WriteLine($"The Sum of Digits is : {total}");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number");
            }
        }
    }
}