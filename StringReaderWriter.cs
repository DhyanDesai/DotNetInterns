using System.IO;
using System.Text;
namespace filehandling
{
    class StringReaderWriter
    {

        public static void stringreadandwrite()
        {

        //    StringWriter

        string text = "kirtan patel";
        StringBuilder stringBuilder = new StringBuilder();
        StringWriter stringWriter = new StringWriter(stringBuilder);

        stringWriter.WriteLine(text);
        stringWriter.Flush();
            stringWriter.Close();

            StringReader stringReader = new StringReader(stringBuilder.ToString());

           
            Console.WriteLine( stringReader.ReadToEnd());


        }

    }
}