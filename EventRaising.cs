namespace PracticePrograms{
    public delegate void WorkFormehandler(int a, string workType);
    class EventRaising{

        public event WorkFormehandler WorkPerformed;
        public event EventHandler WorkComplete;

        public void Dowork(int hours ,  string workType){
             for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i+1, workType);
                Thread.Sleep(3000);
            }
            //Notify the consumer that work has been completed
            OnWorkComplete();
            
        }

        public void OnWorkPerformed(int a , string b){

        if(WorkPerformed != null){
            WorkPerformed(8,"work start");
        }
        Console.WriteLine(a + "working hpurs" + b);



        }

        public void OnWorkComplete(){
            
            if(WorkComplete is EventHandler del){
                del(this , EventArgs.Empty);
                
            }
            System.Console.WriteLine("successfully complete");

        }
  
        
    }
}