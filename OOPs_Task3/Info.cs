using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPs_Task3
{
    public class Info : IInfo
    {
        public void Name()
        {
            Console.WriteLine("My Name is Tina");
        }
        public void Address()
        {
            
            Console.WriteLine("I live in Valsad");
        }
    }
}