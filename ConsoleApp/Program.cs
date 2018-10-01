using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tool = Factory.GetExportHandler(ExportType.CSV);

            Console.WriteLine(tool.ToString());

            Console.Read();
        }


        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/reflection
        static void WorkingWithReflexion()
        {
            // System.Reflection.Assembly info = typeof(ExportManager).Assembly;  
            System.Reflection.Assembly info = typeof(System.Int32).Assembly;  
            System.Console.WriteLine(info);  

        }
    }
}
