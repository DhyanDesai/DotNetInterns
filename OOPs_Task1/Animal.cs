using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalSound_program
{
    public abstract class Animal
    {
        public abstract void Sound();
    }
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog sound : woof");
        }
    }
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("cat sound : meow");
        }
    }
}