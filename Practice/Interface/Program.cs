namespace Interface;

class Program
{
    static void Main(string[] args)
    {
       
        Info info = new Info();
        Iinfo iinfo = new Info();
        info._name = "Kirtan";
        info._address="valsad";

        info.Name();

    //     info.Name(iinfo);
    //    System.Console.WriteLine();
    }
}
