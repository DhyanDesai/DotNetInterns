using System.Collections;
namespace PracticePrograms{
    class ArrayListProgram{
        public static void arraylistoperation(){



            //simple adding into the arraylist
            
            ArrayList al1 = new ArrayList();
            al1.Add("kirtan patel");
            al1.Add(5);
            al1.Add(45.254);
            al1.Add(null);
            al1.Add(true);

           foreach (var item in al1)
           {
            Console.WriteLine(item);
           }


            // when  we add any data can store as an object but we access into specific casting than it gives error so do it manually or use "var"
            int a =(int) al1[1];
            System.Console.WriteLine(a);

            var a1 = al1[1];
            var s1 = al1[0];
            Console.WriteLine($"value of integer is {a1} and string is {s1}");



            // insert in perticilar index

            al1.Insert(0,1);
            Console.WriteLine("ID number : " + al1[0]);
            Console.WriteLine("usernmae : " + al1[1]);
            

            //indert a range of item in purticular index

            ArrayList al2 =new ArrayList(){
                "IND",
                "US",
                "NZ"
            };
             ArrayList al3 =new ArrayList(){
                "LA",
                "SA",
                "AUS"
            };

            al2.InsertRange(1,al3);
            foreach (var item in al2)
            {
                Console.Write($"{item} ");
            }

            //for remove element from it

            // al2.RemoveAt(index number);
            al2

        }
    }
}