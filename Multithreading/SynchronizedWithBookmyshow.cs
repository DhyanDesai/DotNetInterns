namespace mutlithreading{
    class SynchronizedWithBookmyshow{

            object objectlock  = new object();
        public static void mainmethod(){
            SynchronizedWithBookmyshow synchronizedWithBookmyshow = new SynchronizedWithBookmyshow();

            Thread  thread1 = new Thread(synchronizedWithBookmyshow.ticketconfimed){
                Name = "Thread1"
            };
            Thread  thread2 = new Thread(synchronizedWithBookmyshow.ticketconfimed){
                Name = "Thread2"
            };
            Thread  thread3 = new Thread(synchronizedWithBookmyshow.ticketconfimed){
                Name = "Thread3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();


        }
        static int a = 1 , b = 2 , c = 3;
        int availableticket = 3;

        public void booktickets(String str, int a){
            lock(objectlock){
                if(a <= availableticket){
                Console.WriteLine(str + " booked ticket" + a);
                availableticket -= a;
            }
            else{
                 Console.WriteLine("No Ticket available");
            }
            }
            

        }
        public void ticketconfimed(){

            string name = Thread.CurrentThread.Name;
            if(name.Equals("Thread1")){

                booktickets(name , a);

            }
            else if(name.Equals("Thread2")){
                booktickets(name , b);
            }
            else{
                booktickets(name , c);
            }

        }
         
    }
}