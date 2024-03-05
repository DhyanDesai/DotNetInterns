using System.Collections;
namespace DotNetInterns;
class ArrayList_Ex{
    public static void GetList(){
        List<int> ArrList=new List<int>();
        ArrList.Add(1);
        ArrayList al1 = new ArrayList();
        al1.Add("Nachiketa");
        al1.Add("Subham");
        al1.Add("Kirtan");
        foreach(string A in al1){
            Console.WriteLine($"Student Name : {A}");
        }
        al1.Remove("Subham");

        Console.WriteLine("Removing Subham From arrayList ");
        
        foreach(string A in al1){
            Console.WriteLine($"Student Name : {A}");
        }
    }
}