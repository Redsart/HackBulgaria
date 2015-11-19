//Problem 2: Word Game
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
            char[] word = new char[] { 'i', 'v', 'a', 'n' };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == word[0]) //searching if char == first char of word
                    {
                        //searching for a word horizontaly
                        if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == word[1]) //check if coordinates exists and search a next letter
                        {
                            if (col + 2 < matrix.GetLength(1) && matrix[row, col + 2] == word[2]) //check if coordinates exists and search a next letter
                            {
                                if (col + 3 < matrix.GetLength(1) && matrix[row, col + 3] == word[3]) //check if coordinates exists and search a next letter
                                {
                                    counter++;
                                }
                            }
                        }

                        //searching for a word verticaly from up to down
                        if (row+1<matrix.GetLength(0) && matrix[row+1,col]==word[1]) //check if coordinates exists and search a next letter
                        {
                            if (row + 2 < matrix.GetLength(0) && matrix[row + 2, col] == word[2]) //check if coordinates exists and search a next letter
                            {
                                if (row + 3 < matrix.GetLength(0) && matrix[row + 3, col] == word[3]) //check if coordinates exists and search a next letter
                                {
                                    counter++;
                                }
                            }
                        }

                        //searching for a word verticaly from down to up
                        if (row - 1 > 0 && matrix[row - 1, col] == word[1]) //check if coordinates exists and search a next letter
                        {
                            if (row - 2 > 0 && matrix[row - 2, col] == word[2]) //check if coordinates exists and search a next letter
                            {
                                if (row - 3 > 0 && matrix[row - 3, col] == word[3]) //check if coordinates exists and search a next letter
                                {
                                    counter++;
                                }
                            }
                        }

                        //searching from left to right diagonal
                        if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row + 1, col + 1] == word[1]) //check if coordinates exists and search a next letter
                        {
                            if (row + 2 < matrix.GetLength(0) && col + 2 < matrix.GetLength(1) && matrix[row + 2, col + 2] == word[2]) //check if coordinates exists and search a next letter
                            {
                                if (row + 3 < matrix.GetLength(0) && col + 3 < matrix.GetLength(1) && matrix[row + 3, col + 3] == word[3]) //check if coordinates exists and search a next letter
                                {
                                    counter++;
                                }
                            }
                        }

                        //searching from right to left diagonal
                        if (row - 1 > 0 && col - 1 > 0 && matrix[row - 1, col - 1] == word[1]) //check if coordinates exists and search a next letter
                        {
                            if (row - 2 > 0 && col - 2 > 0 && matrix[row - 2, col - 2] == word[2]) //check if coordinates exists and search a next letter
                            {
                                if (row - 3 > 0 && col - 3 > 0 && matrix[row - 3, col - 3] == word[3]) //check if coordinates exists and search a next letter
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }

            }
            

            Console.WriteLine("Result: {0}",counter);
        }
    }
}
