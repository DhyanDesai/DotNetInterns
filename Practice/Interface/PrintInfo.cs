namespace Interface{
    class PrintInfo{
        public void Log(Iinfo iinfo){
            Console.WriteLine($"name is {iinfo.Name}");
        }
    }
}