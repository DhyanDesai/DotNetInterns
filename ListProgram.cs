using System.Collections.Generic;
namespace PracticePrograms{
    class Listprogram{
        public static void CURDOperation(){
            List<int> l1 = new List<int>();
            l1.Add(5);
            l1.Add(10);
            l1.Add(15);
            l1.Add(20);
            l1.Add(25);

            Console.WriteLine("Total Capacity are: "+l1.Capacity);
            Console.WriteLine("Total element are: "+l1.Count);
            Console.WriteLine("Total element are: "+ l1[4]);

            
        }
    }
}