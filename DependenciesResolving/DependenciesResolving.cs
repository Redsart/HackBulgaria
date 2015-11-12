using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DependenciesResolving
{
    class DependenciesResolving
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader(@"..\..\dependencies.json");

            //using (reader)
            //{
            //    string textLine = reader.ReadLine();
            //    while (textLine != null)
            //    {
            //        textLine = reader.ReadLine();
            //    }
            //}
            string path = @"..\..\dependencies.json";
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
    }
}
