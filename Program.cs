using System.Drawing;
using static DotNetInterns.Delegets_P2;

namespace DotNetInterns;

class Program
{
    static void Main(string[] args)
    {
       //  Task1_2202.Sum_Of_Digit();
       // Task2_2202.Fibonacci();
       //  Task4_2202.Palindrome();
        //  Task5_2202.Factorial();

        // Workingtype Del1=new Workingtype(Delegets_P.Workingtype);
        // Del1.Invoke(10,Worktype.Student);


        RectengleDelegete rect=new RectengleDelegete(Delegets_P2.Area);
        rect=rect+Delegets_P2.Perimeter;

        rect(40.4,44.5);

        rect=rect-Delegets_P2.Perimeter;
        Console.WriteLine("After Removing ");
        rect(343.45,234.5);
        

       
}



}