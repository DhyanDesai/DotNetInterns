namespace Practice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    try{
using (var context = new RepoEmployee())
{

    var std1 = new DepartmentModel(){
        Name = "IT"
    };

    context.Department.Add(std1);


    var std = new EmployeeModel()
    {
        First_name = "Kirtan",
        Last_name = "Patel",
        Address = "146,ABC",
        City = "Valsad",
         State = "Gujarat",
        Email = "Loki1731@gmail.com" 
    };
    context.Employee.Add(std);

    
    // or
    // context.Add<Student>(std);

    context.SaveChanges();
    }
        
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
        Console.WriteLine(e.InnerException);
    }
    }
}
