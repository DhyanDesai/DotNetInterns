namespace DotNetInterns
{   
    struct Data{
        public int rollno;
        public string name;
                
    };
    class test1{
        public void test(){
            Data Stud1;
            Data Stud2;
            Stud1.rollno = 45;
            Stud1.name = "Rohit";
            Stud2.rollno = 18;
            Stud2.name = "Virat";
            Console.WriteLine("Student name is {0} and Roll No is {1}.",Stud1.name,Stud1.rollno);
            Console.WriteLine("Student name is {0} and Roll No is {1}.",Stud2.name,Stud2.rollno);
        }
    }
}