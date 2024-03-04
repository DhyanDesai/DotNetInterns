using System.Collections;
namespace DotNetInterns
{
    class Arraylist
    {
        public void arraylistex(){
            ArrayList al1 = new ArrayList();
            al1.Add(45);
            al1.Add("Rohit");
            al1.Add("Virat");
            al1.Add(" ");
            al1.Add(true);
            al1.Add(7.3);
            al1.Add(null);

            al1.Remove("Virat");
            
            foreach (var item in al1)
            {
                System.Console.WriteLine(item);
            }

            var al2 = new ArrayList(){
                18,"Rohit","Virat",true,66.88
            };

            al2.Insert(1,"Manually Entered");

            var al3 = new ArrayList(){
                "Dhoni","Yuvraj","Sachin"
            };

            al2.InsertRange(4,al3);

            foreach (var item in al2)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}