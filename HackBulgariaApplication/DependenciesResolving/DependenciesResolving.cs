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

            var serializeFirst = new JavaScriptSerializer();
            Package dependencies = serializeFirst.Deserialize<Package>(first);

            var serializeSecond = new JavaScriptSerializer();

            Dictionary<string, string[]> packages = serializeSecond.Deserialize<Dictionary<string, string[]>>(second);
            List<string> instaledPackages = new List<string>();
            for (int i = 0; i < dependencies.dependencies.Length; i++)
            {
                Instaling(dependencies.dependencies[i], packages, ref instaledPackages);
            }
        }

        private static void Instaling(string packageName, Dictionary<string, string[]> dependencies, ref List<string> instaledPackages)
        {
            string[] value;
            if (instaledPackages.Contains(packageName))
            {
                return;
            }

            if (dependencies.TryGetValue(packageName, out value) && value.Length > 0)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    Instaling(value[i], dependencies, ref instaledPackages);
                }
            }

            instaledPackages.Add(packageName);
            Console.WriteLine("Instal package {0}", packageName);
        }
    }
}
