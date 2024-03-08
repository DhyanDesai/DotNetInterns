


namespace PracticePrograms;

//  DELEGATES DECALRE:
public delegate void delegateHandler(string abc);
public delegate double doubleDelegate(double num1, double num2);

public delegate string nameDelegates(string name);






//MAIN CLASS

public class Program
{
    static void Main(string[] args)
    {

        // ===============================  Single and multiple delegate ================================



        // delegateHandler obj = new delegateHandler(SingleMultiDelegates.PrintName);
        //     obj.Invoke("kirtan");

        // MulticastDelegate

        // doubleDelegate d1 = new doubleDelegate(SingleMultiDelegates.addition);

        // d1 += SingleMultiDelegates.subtrac;
        // d1 += SingleMultiDelegates.multi;
        // d1 += SingleMultiDelegates.division;

        // d1.Invoke(45, 9);




        //GERERIC FUNCTION WITH  ========> FUNC, ACTION, PREDICATE




        // Func<int, double, double> r1 = new Func<int, double, double>(GenericDelegateProgram.addnum);
        // Console.WriteLine(r1.Invoke(45, 454.154));

        // Action<int, int, int> r2 = new Action<int, int, int>(GenericDelegateProgram.modulonumber);
        // r2.Invoke(15, 10, 85);

        // Predicate<string> r3 = new Predicate<string>(GenericDelegateProgram.name);
        // Console.WriteLine("Even number name: " + r3.Invoke("kirtan"));


        // AnonymousProgram  ===> METHOD WITHPOUT NAME

        // nameDelegates a1 = delegate (string names) {

        //     Console.WriteLine($"happy birthday {names}" );
        //    return "hey, enjoy";
            

        // };

        // Console.WriteLine( a1.Invoke("kirtan patel"));


        // Lambda Expression using anonymous method

        //  nameDelegates a1 = (names) => {

        //     Console.WriteLine($"happy birthday {names}" );
        //    return "hey, enjoy";
            

        // };

        // Console.WriteLine( a1.Invoke("kirtan patel"));




            // EVENT


        // EventRaising e1 = new EventRaising();
        // e1.Dowork(5,"work compalete yet?");

        // Listprogram.CURDOperation();
        ArrayListProgram.arraylistoperation();
        

        // FileStreamProgram.filestreamreadwrite();

        // StreamReaderAndWriter.streamreadandwrite();

        StringReaderWriter.stringreadandwrite();



    }

}
