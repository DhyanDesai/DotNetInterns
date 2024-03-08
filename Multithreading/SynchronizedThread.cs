namespace mutlithreading{
    class SynchronizedThread{
         static Object objlock = new Object();
        public static void synchronizedThread(){

            Thread thread1  = new Thread(details){

                Name = "Thread 1"
            };
            Thread thread2  = new Thread(details){

                Name = "Thread 2"
            };
            Thread thread3  = new Thread(details){

                Name = "Thread 3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();


        }

        public static void details(){
            lock( objlock){
                  Console.WriteLine(Thread.CurrentThread.Name + " Hello world");
            Thread.Sleep(2000);
            Console.WriteLine("Using C# Language");
            }
          
        }

    }
}