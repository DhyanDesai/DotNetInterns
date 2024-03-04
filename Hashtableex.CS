using System.Collections;
namespace DotNetInterns
{
    class Hashtableex
    {
        public void htex(){
            Hashtable ht1 = new Hashtable();

            ht1.Add("PId", 45);
            ht1.Add("Name","Rohit");
            ht1.Add("Team","India");
            System.Console.WriteLine("Elements:");
            foreach (DictionaryEntry item in ht1)
            {
                System.Console.WriteLine($"Key: {item.Key},Value:{item.Value}");
            }
        }
    }
}