namespace DotNetInterns
{   
    enum Weeks{
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    class EnumEx{
        public void EnumExampele(){
            System.Console.WriteLine("Enter a number between 1 and 7");
            int weekday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Weeks)weekday);
        }
    }
}