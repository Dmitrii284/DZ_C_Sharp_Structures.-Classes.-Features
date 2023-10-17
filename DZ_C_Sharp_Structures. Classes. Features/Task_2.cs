using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
    /*
     Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
    Определить сумму элементов массива, расположенных 
    между минимальным и максимальным элементами 
     */
namespace DZ_C_Sharp_Structures._Classes._Features
{
    internal class Task_2
    {
        private  int rows = 5;
        private  int columns = 5;
        public int[,]? matrix;
        public int GetRows() {return this.rows;}
        public int GetColumns() { return this.columns;}

        public int[,] MatrixRandom()
        {
            int[,] matrix = new int[rows, columns];
            Random rand = new();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    
                }               
            }
            return matrix;
        }

        public void MinMaxValue(int[,] matrix, out int minIndexX, out int minIndexY,
                                 out int maxIndexX, out int maxIndexY)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            minIndexX = 0;
            minIndexY = 0;
            maxIndexY = 0;
            maxIndexX = 0;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minIndexX = matrix[i, j];
                        minIndexY = i;
                        minIndexY = j;
                    }

                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                        minIndexX = i;
                        minIndexY = j;
                    }

                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxIndexX = i;
                        maxIndexY = j;    
                    }
                }
            }
        }
        
        public int CalcSumBetwenElem(int[,] arr, int minX, int minY, int maxX, int maxY)
         {
            int sum = 0;

            for(int i = Math.Min(minX, maxX); i <= Math.Max(minY, maxY); i++)
            {
                for(int j = Math.Min(minY, maxY); j <= Math.Max(maxX, maxY); j++)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
         } 
    }    
}
