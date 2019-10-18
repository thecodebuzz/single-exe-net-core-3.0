using Newtonsoft.Json;
using System;

namespace SelfContainedSingleExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string result = JsonConvert.SerializeObject("Hello JSON");
        }
    }
}
