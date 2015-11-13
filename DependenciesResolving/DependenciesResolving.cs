using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace DependenciesResolving
{
    class DependenciesResolving
    {
        static void Main(string[] args)
        {
            string path = @"..\..\dependencies.json";
            string first = File.ReadAllText(path); // parsing JSON to String
            //Console.WriteLine(first);

            string secondPath = @"..\..\all_packages.json";
            string second = File.ReadAllText(secondPath);
            //Console.WriteLine(second);

            var serializer = new JavaScriptSerializer(); //using System.Web.Script.Serialization;

            Dictionary<string, string> values = serializer.Deserialize<Dictionary<string, string>>(second);
            Console.WriteLine(values);
        }
    }
}
