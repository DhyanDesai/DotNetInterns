using System.IO;
using System.Text;
namespace filehandling{
class FileStreamProgram
{

    public static void filestreamreadwrite()
    {

        //New-Item -ItemType File -Name kirtan.txt =======> create new file in vs terminal

        //  ====================         READ        =====================

        string path1 = @"C:\Users\kirtan.patel\Desktop\consoleapplication\2. Advanced C# programs\File Handling\kirtan.txt";


        // ============== 1. Just read without using StreamReader====================


        using (FileStream file1 = new FileStream(path1, FileMode.Open, FileAccess.Read))
        {

            byte[] buffer = new byte[1024];
            int binarydata = file1.Read(buffer, 0, buffer.Length);

            string data1 = System.Text.Encoding.UTF8.GetString(buffer, 0, binarydata);
            Console.WriteLine(data1);
            file1.Close();
        }



        // ============== 1. Just read  using StreamReader====================

        string path = @"C:\Users\kirtan.patel\Desktop\consoleapplication\2. Advanced C# programs\File Handling\filestream.txt";
        FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
        string data;
        using (StreamReader streamReader = new StreamReader(file))
        {

            data = streamReader.ReadToEnd();


        }
        file.Close();
        Console.WriteLine(data);


        // Write in tothe file

        FileStream fileStream = new FileStream(path, FileMode.Append);

        Byte[] bytes = Encoding.Default.GetBytes("i'm going to add in the file.txt file");
        fileStream.Write(bytes, 0 , bytes.Length);
        fileStream.Close();

    }

}
}