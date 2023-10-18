using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_C_Sharp_Structures._Classes._Features
{
    class Task_4_MyltiplierMatrix
    {
        public void Print(int[,]matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int  j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MultiplierByMatrix(int[,] matrix, int[,] matrix2)
        {
            for(int i = 0; i<matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(0); ++j)
                {
                    Console.Write((matrix[i, j] * matrix2[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }

        public void MatrixSum(int[,] matrix, int[,] matrix2)
        {            
            for(int i = 0; i < matrix.GetLength(0);i++)
            {
                for(int j = 0; j < matrix.GetLength(0);j++)
                {
                    Console.Write((matrix[i, j] + matrix2[i, j]) + " ");
                }
                Console.WriteLine();
            }            
        }
    }
}
