//Problem 1: Points

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    class Points
    {
        static void Main(string[] args)
        {
            string input = ">>><<<~>>>~^^^";
            int coordX=0;
            int coordY=0;
            char[] arr = input.ToCharArray();

            for (int i = input.Length-1; i >=0; i--)
            {
                if (arr[i] == '~')
                {
                    if (arr[i+1] == '>' || arr[i + 1] == '<')
                    {
                        coordX *=-1;
                    }
                    else if (arr[i+1] == '^' || arr[i + 1] == 'v')
                    {
                        coordY*=-1;
                    }
                }
                else if (arr[i] == '>')
                {
                    coordX++;
                }
                else if (arr[i] == '<')
                {
                    coordX--;
                }
                else if (arr[i] == '^')
                {
                    coordY++;
                }
                else if (arr[i] == 'v')
                {
                    coordY--;
                }
            }

            Console.WriteLine("{0} {1}",coordX,coordY);
        }
    }
}
