using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Task_4
 Создайте приложение, которое производит операции 
над матрицами:
■ Умножение матрицы на число;
■ Сложение матриц;
■ Произведение матриц
 */

namespace DZ_C_Sharp_Structures._Classes._Features
{
    class Task_4
    {
        public void MultiplyingMatrix(int[,] matrix, int num)
        {           
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(0);          
            for (int i = 0; i < rows; ++i)
            {
                for(int j = 0; j < columns; ++j)
                {                     
                    Console.Write((matrix[i, j] * num) + " ");
                }
                Console.WriteLine("\n");
            }           
        }
    }
}
