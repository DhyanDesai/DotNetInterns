using System.IO;
namespace filehandling
{
    class StreamReaderAndWriter
    {

        public static void streamreadandwrite()
        {

            string path = @"C:\Users\kirtan.patel\Desktop\consoleapplication\2. Advanced C# programs\File Handling\patel.txt";
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                Console.WriteLine("Enter the data that you want to add in the file");

                string str = Console.ReadLine();

                streamWriter.WriteLine(str);

                Console.WriteLine("data is entered successfully in the file");
                //Using block automatically calls the Flush and Close Method of StreamWriter Object
                //Passing the boolean true for Append which means it will not overwrite instead it will append the content

            }

            using(StreamReader streamReader = new StreamReader(path)){
                Console.WriteLine("Content of the File");
               
               string str = streamReader.ReadToEnd();
               Console.WriteLine(str);
               
            }



        }

    }
}