using System;

namespace OOPs_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Flamingo flamingo = new Flamingo();
            Penguin penguin = new Penguin();

            flamingo.Bird_fly();

            penguin.Bird_fly();
        }
    }
}
