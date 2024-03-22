namespace Interface{
    public class Info : Iinfo{


        public string name;
        public string address;
        public string _name{
            get{return name;} 
        set{
            name= value;
        }}
        public string _address{
            get{return address;} 
        set{
            address= value;
        }}


        
        public void Name(){
            Console.WriteLine($"Name is: {name}");
        }
        public void Address(){
              Console.WriteLine($"Address is: {address}");
        }
        public void display(){
            Console.WriteLine($"Name is: {name} , Address is: {address} ");
        }
    }
}