using System.Collections;
using System.Net;

namespace DotNetInterns;
class List{



   public static void arraylist(){
    ArrayList A1=new ArrayList();

    Console.Write("Enter Name :");
    string Name=Console.ReadLine();

    Console.Write("Enter City :");
    string City=Console.ReadLine();
    
    A1.Add(Name);
    A1.Add(City);

    foreach(var A in A1){
        Console.WriteLine($"{A}");
    }
   }



    //List 
    public static void List_Ex(){
        //Using Int Type
        List<int> L1=new List<int>();
        L1.Add(1);
        L1.Add(2);
        L1.Add(3);
        foreach(int N in L1){
            Console.Write($"Numbers : {N}");
        }
        Console.WriteLine();
        
        List<string> L2=new List<string>();
        L2.Add("Name");
        L2.Add("Number");
        L2.Add("Email");
    }

}