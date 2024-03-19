using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement
{
    public class Client : IBook
    {
        public void AddBook()
        {
            Console.WriteLine("Book Added");
        }
         public void FindBook()
        {
            Console.WriteLine("Book Found");
        }
    }
    
}