using System;
namespace DelegateDemo
{
    public class GenericDelegates{
        static void Main(string[] args){
            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(Number1);
            double result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = new Action<int, float, double>(Number2);
            obj2.Invoke(50, 255.45f, 123.456);

            Predicate<string> obj3 = new Predicate<string>(CheckLen);
            bool status = obj3.Invoke("Nivvv");
            Console.WriteLine(status);

            Console.ReadLine();
        }

        public static double Number1(int n1, float n2, double n3){
            return n1 + n2 + n3;
        }
        public static void Number2(int n1, float n2, double n3){
            Console.WriteLine(n1 + n2 + n3);
        }
        public static bool CheckLen(string name){
            if(name.Length > 5){
                return true;
            }else{
                return false;
            }
        }
    }
}
