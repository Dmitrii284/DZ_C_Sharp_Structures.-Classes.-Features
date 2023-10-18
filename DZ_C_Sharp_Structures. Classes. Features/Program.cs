
/*
 Structures. Classes. Features
Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) 
дробных чисел с именем B. Заполнить одномерный массив 
А числами, введенными с клавиатуры пользователем, а 
двумерный массив В случайными числами с помощью 
циклов. Вывести на экран значения массивов: массива 
А в одну строку, массива В — в виде матрицы. Найти в 
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее 
произведение всех элементов, сумму четных элементов 
массива А, сумму нечетных столбцов массива В

 */

using System.Linq.Expressions;
using System.Numerics;
using System.Threading.Tasks;
using System.Xml.Linq;
using DZ_C_Sharp_Structures._Classes._Features;
//int[] A = new int[5];

//Console.WriteLine("Введите 5 целых чисел -> ");

//for (int i = 0; i < A.Length; ++i)
//{
//    A[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine();

//// Вывод значений одномерного массива A в одну строку              
//Console.WriteLine("Вывод значений одномерного массива A в одну строку");
//for (int i = 0; i < A.Length; ++i)
//{
//    Console.Write(A[i] + " ");
//}
//Console.WriteLine();

//double[,] B = new double[3, 4];
//// Заполнение двумерного массива B случайными числами
//Random random = new();

//for (int i = 0; i < 3; ++i)
//{
//    for (int j = 0; j < 4; ++j)
//    {
//        B[i, j] = random.NextDouble();
//    }
//}

//// Вывод значений двумерного массива в виде матрици
//Console.WriteLine("Вывод значений двумерного массива B в виде матрици: ");

//for (int i = 0; i < 3; ++i)
//{
//    for (int j = 0; j < 4; ++j)
//        Console.Write(B[i, j] + "\t");
//}
//Console.WriteLine();

//// Поиск общего максимального и минимального элементов
//int? maxA = int.MinValue;
//int? minA = int.MaxValue;
//double? maxB = double.MinValue;
//double? minB = double.MaxValue;

//foreach (int elem in A)
//{
//    if (elem > maxA) maxA = elem;
//    if (elem < minA) minA = elem;
//}
//Console.WriteLine($"Max Элемент в массиве А {maxA}");
//Console.WriteLine($"Min Элемент в массиве B {minA}");

//for (int i = 0; i < 3; ++i)
//{
//    for (int j = 0; j < 4; ++j)
//    {
//        if (B[i, j] > maxB) maxB = B[i, j];
//        if (B[i, j] < minB) minB = B[i, j];
//    }
//}
//Console.WriteLine($"Max Элемент в массиве A {maxB}");
//Console.WriteLine($"Min Элемент в массиве B {minB}");


//// Вычисление общей суммы и произведения всех элементов
//int summA = 0;
//double multiplicationA = 1;
//foreach (int elem in A)
//{
//    summA += elem;
//    multiplicationA *= elem;
//}

//double summB = 0;
//double multiplicationB = 1;
//for (int i = 0; i < 3; ++i)
//{
//    for (int j = 0; j < 4; ++j)
//    {
//        summB += B[i, j];
//        multiplicationB *= B[i, j];
//    }
//}
//Console.WriteLine($"Общая сумма всех элементов массива A: {summA}\n");
//Console.WriteLine($"Общая сумма всех элементов массива B: {summB}\n" + summB);
//Console.WriteLine($"Общее произведение всех элементов массива A: {multiplicationA}\n");
//Console.WriteLine($"Общее произведение всех элементов массива B: {multiplicationB}\n");

//// Вычисление суммы четных элементов массива A
//int? summEvenElementsA = 0;
//for (int i = 0; i < A.Length; i++)
//{
//    if (A[i] % 2 == 0)
//        summEvenElementsA += A[i];
//}
//Console.WriteLine($"Cумма четных элементов массива A:{summEvenElementsA}\n");

//// Вычисление суммы нечетных столбцов массива B
//double summNonEvenColumnsB = 0;
//for (int j = 0; j < 4; ++j)
//{
//    if (j % 2 != 0)
//        for (int i = 0; i < 3; ++i)
//        {
//            summNonEvenColumnsB += B[i, j];
//        }
//}
//Console.WriteLine($"Сумма нечетных столбцов массива B: {summNonEvenColumnsB}\n");

class Program
{
    static void Main(string[] args)
    {
       
        ////Task_2
        Console.WriteLine($"Задача 2\n Начальный массив 5Х5 с генерацией элементов от -100 до 100 : ");
        Task_2 task_2 = new();
        Task_4_MyltiplierMatrix task_4_MyltiplierMatrix = new();
        int[,] matrix = task_2.MatrixRandom();
        task_4_MyltiplierMatrix.Print(matrix);

        int minX, minY, maxX, maxY;
        task_2.MinMaxValue(matrix, out minX, out minY, out maxX, out maxY);
        Console.WriteLine($"Нашли MIN элемент массива:{matrix[minX, minY]}\n");
        Console.WriteLine($"Нашли MAX элемент массива:{matrix[maxX, maxY]}\n");

        int sum = task_2.CalcSumBetwenElem(matrix, minX, minY, maxX, maxY);
        Console.WriteLine($"Нашли SUM между MIN и MAX элементами массива:{sum} \n");

        ////Task_4
        //Console.WriteLine($"Задача 4\n ");
        //Task_4 task_4 = new();

        //Console.Write("Хотите умножить массив на целое число? (Y/N)\t");
        //string answer = Console.ReadLine();

        //while (answer.ToLower() == "y")
        //{
        //    Console.Write("Введите число на которое нужно умножить матрицу -> \t");
        //    int num = int.Parse(Console.ReadLine());
        //    task_4.MultiplyingMatrix(matrix, num);

        //    Console.Write("Хотите ещё умножить массив на целое число? (Y/N)\t");
        //    answer = Console.ReadLine();
        //}

        //Task_4_MyltiplierMatrix
        Console.Write("Задача 4 - Операции над матрицами.\nУ нас 2 матрици:\n\n");
        Task_4 task_4 = new();
        Task_2 task_41 = new();       
        task_41.MatrixRandom();
        int[,] matrix1 = task_41.MatrixRandom();        
        Console.WriteLine("Мытрица - 1:");
        task_4_MyltiplierMatrix.Print(matrix1);
        Console.WriteLine();

        Task_2 task_42 = new();
        task_42.MatrixRandom();
        int[,] matrix2 = task_42.MatrixRandom();
        Console.WriteLine("Мытрица - 2:");
        task_4_MyltiplierMatrix.Print(matrix2);
                
        string operation;
        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Умножение матрицы на число");
            Console.WriteLine("2. Сложение матриц");
            Console.WriteLine("3. Произведение матриц");
            Console.WriteLine("n. Выход");
            operation = Console.ReadLine();

            switch(operation)
            {
                case "1":                    
                    Console.Write("Введите число на которое нужно умножить матрицу Под номером - 1 -> \t");
                    int num = int.Parse(Console.ReadLine());
                    task_4.MultiplyingMatrix(matrix1, num);
                    break;
                case "2":                     
                    task_4_MyltiplierMatrix.MatrixSum(matrix1, matrix2);                    
                    break;
                case "3":
                    task_4_MyltiplierMatrix.MultiplierByMatrix(matrix1, matrix2);
                    break;                
                default:
                    Console.WriteLine("Ошибка: некорректная операция.");
                    break;                    
            }
            Console.WriteLine();
        } while (operation != "n") ;
        //{
        //    Console.Write("Хотите перемножить матрици? НАЖМИТЕ - 1\t");
        //    switch ()
        //    {
        //        case 1:
        //    }
        //    Console.WriteLine("");
        //}
        //Console.Write("Хотите ещё умножить массив на целое число? (Y/N)\t");
        //answer = Console.ReadLine();

        //Console.Write("Хотите сложить матрици? (Y/N)\t");

    }
}