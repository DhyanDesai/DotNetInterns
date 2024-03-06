using System;
using System.IO;

namespace fileHandle
{
    class FileStream1
    {
        public static void Main(string[] args)
        {
            try
            {
            string FilePath = "./Demo.txt";
            int a = 10;
            int b = 10;
            int c = a + b;
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine($"Sum : {c}");
                sw.Close();
            }
            Console.WriteLine("Data has been added");

            using (StreamReader sr = new StreamReader(FilePath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            //FileStream fs = new FileStream(FilePath , FileMode.Create);
            //fs.Close();
            //Console.WriteLine("File has been created...");

            /*Console.WriteLine("Enter you want to print...");
            string input = Console.ReadLine();
            sw.Write(input);
            Console.WriteLine("Data has been added to the file...");*/
        
            //sw.Flush();
           
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error {e.Message}");
            }
           
            Console.ReadLine();
        }
    }
}
