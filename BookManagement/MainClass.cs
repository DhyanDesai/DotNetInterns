using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            IBook c1 = new Client();
            c1.AddBook();
            c1.FindBook();
            Console.WriteLine("Interface called...");
        }
    }
}