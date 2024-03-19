using System;

namespace OOPs_Task4
{
    public abstract class Fly
    {
        public abstract void Bird_fly();
    }

    public class Flamingo : Fly
    {
        public override void Bird_fly()
        {
            Console.WriteLine("Flamingo can fly");
        }
    }

    public class Penguin : Fly
    {
        public override void Bird_fly()
        {
            Console.WriteLine("Penguin cannot fly");
        }
    }
}
