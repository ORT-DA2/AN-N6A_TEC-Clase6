using System;
using System.Linq;
using System.Reflection;
using Contracts;

namespace ConsoleNoDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscoverAssembly();
            Console.Read();

            FromInterface();
            Console.Read();

            // activator
            // set property
            // ejecutar funcion
            // private things
        }


        static void FromInterface()
        {
            var type = typeof(IExport);

            Assembly assembly = Assembly.LoadFile(@"C:\Users\folmos\Documents\Visual Studio 2017\Projects\ConsoleApp\CSVExport\bin\Debug\netcoreapp2.1\CSVExport.dll");
            var founded = assembly.GetTypes().FirstOrDefault(p => type.IsAssignableFrom(p));

            object exportInstance = Activator.CreateInstance(founded);
            PropertyInfo prop = founded.GetProperty("Author");
            prop.SetValue(exportInstance, "Manuel", null);
            
            
            
            // O también podemos crearlo pasandole parámetros
            object exportInstance2 = Activator.CreateInstance(founded, new object[] { "Juan" });

            IExport csvExport = exportInstance as IExport;   
            // Lo mostramos
            Console.WriteLine(exportInstance.ToString());
            Console.WriteLine(exportInstance2.ToString());
            
            csvExport.CreateFile("csv_file");
        }

        

        static void DiscoverAssembly()
        {
            // Cargamos el assembly de ejemplo en memoria
            Assembly miAssembly = Assembly.LoadFile(@"C:\Users\folmos\Documents\Visual Studio 2017\Projects\ConsoleApp\CSVExport\bin\Debug\netcoreapp2.1\CSVExport.dll");
            // Podemos ver que Tipos hay dentro del assembly
            foreach (Type tipo in miAssembly.GetTypes())
            {
                Console.WriteLine(string.Format("Clase: {0}", tipo.Name));

                Console.WriteLine("Propiedades");
                foreach (PropertyInfo prop in tipo.GetProperties())
                {
                    Console.WriteLine(string.Format("\t{0} : {1}", prop.Name, prop.PropertyType.Name));
                }
                Console.WriteLine("Constructores");
                foreach (ConstructorInfo con in tipo.GetConstructors())
                {
                    Console.Write("\tConstructor: ");
                    foreach (ParameterInfo param in con.GetParameters())
                    {
                        Console.Write(string.Format("{0} : {1} ", param.Name, param.ParameterType.Name));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Metodos");
                foreach (MethodInfo met in tipo.GetMethods()) // BindingFlags.NonPublic | BindingFlags.Instance
                {
                    Console.Write(string.Format("\t{0} ", met.Name));
                    foreach (ParameterInfo param in met.GetParameters())
                    {
                        Console.Write(string.Format("{0} : {1} ", param.Name, param.ParameterType.Name));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // copyed from https://github.com/Sactos/HomeworksApi/blob/master/Clases/Clase%206%20-%20Reflection.md
        }

    }
}
