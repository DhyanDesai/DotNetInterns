namespace DotNetInterns
{
    class WorkData:EventArgs{
        public int Hour{get;set;}
        public string? WorkType{get;set;}
    }
    class Worker{
        public event EventHandler<WorkData>? WorkPerformed;
        public event EventHandler? WorkComplete;

        public void DoWork(int Hours,string WorkType){
            for(int i=0;i<Hours;i++){
                OnWorkPerformed(i+1,WorkType);
                //Thread.Sleep(3000);
            }
            OnComplete();
        }

        protected virtual void OnWorkPerformed(int Hour,string WorkType){
            if(WorkPerformed!=null){
                WorkData obj=new WorkData(){
                    Hour=Hour,
                    WorkType=WorkType
                };
                WorkPerformed(this,obj);
            }
            
        }
        protected virtual void OnComplete(){
            WorkComplete?.Invoke(this,EventArgs.Empty);

        }

    }
}