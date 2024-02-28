namespace DotNetInterns;

class Program
{
    static void Main(string[] args)
    {
        int day_task = 0;
        
        while(day_task != 5)
        {
            Console.WriteLine("|------------List of tasks-----------|");
            Console.WriteLine("|1. Feb_20_Task                      |");
            Console.WriteLine("|2. Feb_21_Task                      |");
            Console.WriteLine("|3. Feb_22_Task                      |");
            Console.WriteLine("|4. Feb_26_Task                      |");
            Console.WriteLine("|5. Exit                             |");
            Console.WriteLine("|------------------------------------|");
            Console.Write("Enter task number: ");
            day_task = Convert.ToInt32(Console.ReadLine());

            switch(day_task)
            {
            case 1:
                Feb_20_Task.tasks();
                break;

            case 2:
                Feb_21_Task.tasks();
                break;
            
            case 3:
                Feb_22_Task.tasks();
                break;

            case 4:
                Feb_26_Task.tasks();
                break;
            
            case 5:
                Console.WriteLine("|----Thank you for your patronage----|");
                break;

            default:
                Console.WriteLine("Enter a valid date of task number.");
                break;
            }
        }
    }
}