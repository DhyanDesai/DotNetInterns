using System;

namespace AnimalSound_program
{
    public class AnimalSound
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c =new Cat();
            d.Sound();
            c.Sound();
        }
    }
}
