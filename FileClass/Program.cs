using System;
using System.IO;
namespace FileClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the Source and Destination File Paths
            string SourceFilePath =@".\source_file.txt";
            string DestinationFilePath = @".\destination_file.txt";

            //Check if the SourceFilePath Exists using the Exists Method of the File Class
            if (File.Exists(SourceFilePath))
            {
                //If the SourceFilePath Exists, then copy the File content to a new File using the Copy Method 
                //We are coping the SourceFilePath to DestinationFilePath
                File.Copy(SourceFilePath, DestinationFilePath);

                //Read the Text from DestinationFilePath using ReadAllText Method
                string lines = File.ReadAllText(DestinationFilePath);

                //Print the Data of the DestinationFilePath
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("MyFile.txt File Does Not Exist in D Directory");
            }
            Console.ReadKey();
        }
    }
}
