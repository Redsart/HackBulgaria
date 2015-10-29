using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    class WordGame
    {

        static void Main(string[] args)
        {
            char[,] matrix = new char[,]{
            {'i','v','a','n'}, 
            {'e','v','n','h'},
            {'i','n','a','v'},
            {'m','v','v','n'},
            {'q','r','i','t'}};
            int counter = 0;

            //check rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row, col] == 'i' && matrix[row, col + 1] == 'v' && matrix[row, col + 2] == 'a' && matrix[row, col + 3] == 'n')
                    {
                        counter++;
                    }
                }
            }

            //check colls
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == 'i' && matrix[row + 1, col] == 'v' && matrix[row + 2, col] == 'a' && matrix[row + 3, col] == 'n')
                    {

                        counter++;
                    }
                    else if (row >= 3 && matrix[row,col]=='i' && matrix[row - 1, col] == 'v' && matrix[row - 2, col] == 'a' && matrix[row - 3, col] == 'n')
                    {
                        counter++;
                    }
                }
            }

            //check from left to right
            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if (matrix[row, col] == 'i' && matrix[row + 1, col + 1] == 'v' && matrix[row + 2, col + 2] == 'a' && matrix[row + 3, col + 3] == 'n')
                {
                    counter++;
                }
            }

            //check from right to left
            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
            {
                if (matrix[row, col] == 'i' && matrix[row + 1, col + 1] == 'v' && matrix[row + 2, col + 2] == 'a' && matrix[row + 3, col + 3] == 'n')
                {
                    counter++;
                }  
            }

            Console.WriteLine("Result: {0}",counter);
        }
    }
}
