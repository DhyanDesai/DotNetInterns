
namespace Thread_Programs;

class Program
{
    static void Main(string[] args)
    {
        bookMyShow BS=new bookMyShow();
        Thread T1=new Thread(BS.TicketBooking){
            Name="Thread1"
        };
        Thread T2=new Thread(BS.TicketBooking){
            Name="Thread2"
        };
        Thread T3=new Thread(BS.TicketBooking){
            Name="Thread3"
        };
        T1.Start();
        T2.Start();
        T3.Start();

        Console.WriteLine("Main Thread Ended");
        
        
    }
}
class bookMyShow{
 public static object Obj=new object();
    int Ava_Tickets=3;
    int P1=1,P2=2,P3=3;

    public void BookTickets(string Name,int Wanted_Ticket){
        lock(Obj){
             if(Wanted_Ticket<=Ava_Tickets){
            Console.WriteLine($"{Name} Booked {Wanted_Ticket} Tickets");
            Ava_Tickets-=Wanted_Ticket;
        }else{
            Console.WriteLine("Tickets Are Soldout");
        }
        }
       
    }
    public void TicketBooking(){
        string Name=Thread.CurrentThread.Name;
        if(Name.Equals("Thread1")){
            BookTickets(Name,P1);
        }
         else if(Name.Equals("Thread2")){
            BookTickets(Name,P2);
        }
         else{
            BookTickets(Name,P3);
        }
    }
}