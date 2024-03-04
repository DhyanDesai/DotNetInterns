using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace DotNetInterns
{   
    class Cars 
    {
        public string company{ get; set;}
        public string model{ get; set;}
        public int price{ get; set;}

    }
    class Lambda
    {
        public void lambda(){
            List<Cars> Car= new List<Cars>(){
                new Cars {company="BMW",model="Z5",price=8000000},
                new Cars {company="Honda",model="City",price=1500000},
                new Cars {company="Tata",model="Nano",price=350000}
            };
            var names = Car.FindAll(car=>car.price<500000);
            foreach (var item in names)
            {
                System.Console.WriteLine(item.company +" "+item.model);
            }
        }
    }
}