namespace DotNetInterns;
public delegate void Workingtype(int Hours, Worktype Type);
class Delegets_P{
    public static void Workingtype(int Hours,Worktype Type){

      Console.WriteLine("Handle By Event Handler");
      Console.WriteLine($"Work Hour is {Hours},WorkType : {Type}");
    }
}
    public enum Worktype{
        Student,Player,Teacher
    }