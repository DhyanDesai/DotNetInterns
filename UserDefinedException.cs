using System.Security.Cryptography.X509Certificates;

namespace DotNetInterns
{   
    public class TempIsZeroException: Exception{
        public TempIsZeroException(string message): base(message){

        }
    }
    class Tempr{
        int tempreture = 0;
        public void showTemp(){
            if (tempreture == 0)
            {
                throw(new TempIsZeroException("Zero tempreture found"));
            }else
            {
                System.Console.WriteLine("Tempreture: {}",tempreture);
            }
        }
    }
}