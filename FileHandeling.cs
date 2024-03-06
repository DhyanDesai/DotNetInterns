using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;

namespace DotNetInterns;
class FileHandeling{

    //Creating New File From User Input Using FileStream Class
    public  static void Create_File(){
        Console.Write("Enter File Name :");
        string File=Console.ReadLine();
        string File_Path=@$"C:\Users\nachiketa.patel\Desktop\Nachiketa Git\FileHandeling\{File}.txt";
        using(FileStream F=new FileStream(File_Path,FileMode.Create)){
           Console.WriteLine("File Craeted Sucsessfully"); 
        }
    }

    //Writng In Existing File using FileStream
    public static void Write_file(){
        string File_Path2=@"C:\Users\nachiketa.patel\Desktop\Nachiketa Git\FileHandeling\File1.txt";
        using (FileStream FS=new FileStream(File_Path2,FileMode.Open)){
            String F_Name="Patel Nachiketa Rohitbhai ";
            string Number="9998617012";
            byte[] Name=Encoding.Default.GetBytes(F_Name); //Converting String Into Byte
            byte[] Num=Encoding.Default.GetBytes(Number);
            FS.Write(Name);
            FS.Write(Num);
            Console.WriteLine("Write Into File Sucsessfully");
        }
    }

    //Writing Data in Existing File Using Stream Writer

    public static void Write_File2(){
        string File_Path=@"C:\Users\nachiketa.patel\Desktop\Nachiketa Git\FileHandeling\Sum_Of_Digit.txt";
        using(StreamWriter SW=new StreamWriter(File_Path,true)){
            Console.Write("Enter Number :");
            int A=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number :");
            int B=Convert.ToInt32(Console.ReadLine());
            int C=A+B;
            long D=A*B;
            double E=A/B;

            SW.WriteLine();
            SW.Write($"First Number :{A}\n");
            SW.Write($"Second Number :{B}\n");
            SW.Write($"Sum Of Digits :{C}\n");
            SW.Write($"Multi Of Digits :{D}\n");
            SW.Write($"Divi Of Digits :{E}\n");            
        }
    }

    //Read From Existing File Using Stream Reader Class.
    public static void Read_File(){
        string File_Path2=@"C:\Users\nachiketa.patel\Desktop\Nachiketa Git\FileHandeling\Sum_Of_Digit.txt";
        FileStream FS=new FileStream(File_Path2,FileMode.Open,FileAccess.Read);
        using(StreamReader SR=new StreamReader(FS) ){
            String info=SR.ReadToEnd();
            Console.WriteLine(info);
        }
        FS.Close();
    }

    //Coping File From Existing File.

    public static void Copy_File(){
        string Path=@"C:\Users\nachiketa.patel\Desktop\Nachiketa Git\FileHandeling\Sum_Of_Digit.txt";
        string New_Path=@"C:\Users\nachiketa.patel\Desktop\Nachiketa Git\FileHandeling\Backup_File\backup.txt";
        File.Copy(Path,New_Path,true);
        string Data=File.ReadAllText(New_Path);
        Console.WriteLine(Data);
    }

    


}