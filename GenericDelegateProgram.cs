namespace PracticePrograms
{
    class GenericDelegateProgram{

        //Methods for the generic delegates 

//===========================  Func   ==================================

    public static double addnum(int a, double b){
        
        return a+b;
    }

//===========================  Action   ==================================
    public static void modulonumber(int a , int b , int c){
        Console.WriteLine((a%b) + c);
    }

    //===========================  Predicate   ==================================

    public static bool name(string name){

        if(name.Length % 2 == 0){
            return true;
        }
        return false;

    }

    }
}