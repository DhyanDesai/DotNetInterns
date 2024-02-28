using System;
namespace DotNetInterns
{
    class RevOrder{
        public static void revchar(){
            /* that takes three letters and displays them in reverse order.*/


            string inputStr = "";
            for (int i = 0;i<3;i++){
                Console.WriteLine("Enter a character");
                inputStr += Convert.ToChar(Console.ReadLine());
            }
            for(int i=inputStr.Length-1;i >=0;i--){
                Console.Write(inputStr[i]+" ");
            } 
        }
    }
}