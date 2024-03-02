using System;
namespace DelegateDemo
{
    public class Delegates{
        public delegate double Num1(int no1, float no2, double no3);
        public delegate void Num2(int no1, float no2, double no3);
        public delegate bool CheckLength(string name);

        static void Main(string[] args){
            Num1 obj1 = new Num1(Number1);
            double result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(result);

            Num2 obj2 = new Num2(Number2);
            obj2.Invoke(50, 255.45f, 123.456);

            CheckLength obj3 = new CheckLength(CheckLen);
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
