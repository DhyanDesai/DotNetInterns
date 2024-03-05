using System;
using System.IO;

namespace FileHandlingDemo
{
    class FileHandling_1
    {
        public static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Twinkle Rana\OneDrive\Desktop\file handling\FileHandlingDemo.txt";

            try
            {
                //CODE FOR FILE STREAM

                /*int i=3;
                // Using statement ensures that the FileStream is properly disposed of
                using (FileStream fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("File is created at the given path.");
                */

                //CODE OF STREAM WRITER AND STREAM READER 

                StreamWriter streamWriter = new StreamWriter(FilePath);
                Console.WriteLine("Enter the Text that you want to write on File");
                // To read the input from the user
                string inputData = Console.ReadLine();
                // To write the data into the stream use the Write Method of the StreamWriter Object
                streamWriter.Write(inputData);
                Console.WriteLine("Data Has Been Written to the File");
                // Clears all the buffers for the current writer by calling the Flush Method of the StreamWriter Object
                streamWriter.Flush();
                // Close the current StreamWriter object and the underlying stream by calling the Flush Method of the StreamWriter Object
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
