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
            string path = @"..\..\dependencies.json";
            string first = File.ReadAllText(path); // parsing JSON to String
            //Console.WriteLine(first);

            string secondPath = @"..\..\all_packages.json";
            string second = File.ReadAllText(secondPath);
            //Console.WriteLine(second);

            var firstDict = first.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(v => v.Split('='))
                        .ToDictionary(v => v.First(), v => v.Last());

            var secondDict = second.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(v => v.Split('='))
            .ToDictionary(v => v.First(), v => v.Last());

            Console.WriteLine(firstDict);
            Console.WriteLine(secondDict);
        }
    }
}
