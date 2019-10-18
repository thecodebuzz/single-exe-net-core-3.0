using ExternalApp1;
using System;
using System.Reflection;

namespace LoadMultipleDLL
{
    class Program
    {

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Run();
        }

        static void Run()
        {
            Employee emp = new Employee();
            emp.Name = "TheCodeBuzz";
            Console.WriteLine(emp.Name);
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("LoadMultipleDLL.Resources.ExternalApp1.dll"))
            {
                var assemblyData = new Byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }

    }


}
