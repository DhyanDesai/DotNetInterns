using System.Security.Cryptography.X509Certificates;

namespace DotNetInterns
{
    class ExceptionHandeling{
        int division;

        public void DivisionNumbers(){
            division = 0;
        }
        public void div( int n1, int n2){
            try
            {
                division = n1/n2;
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("Exception caught {0}",e);
            }finally{
                System.Console.WriteLine("Result: {0}",division);
            }
        }
    }
}