using static System.Console;
Clear();

//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
double[,] GetMatrix(int rows, int colums)
{
    double[,] inArr = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            inArr[i, j] = rnd.Next(-100, 101) / 10d;
        }
    }
    return inArr;
}
void PrintMatrix(double[,] inArr)
{
    WriteLine($"Случайная матрица {inArr.GetLength(0)} на {inArr.GetLength(1)}:");
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            Write($"{inArr[i, j]} ");
        }
        WriteLine();
    }
    WriteLine();
}
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void GetValueInMatrix(double[,] inArr, int positionRow, int positionColum)
{
    if (positionRow-1<inArr.GetLength(0) && positionColum-1<inArr.GetLength(1)){
        WriteLine($"Искомый элемент по заданным значениям: {inArr[positionRow-1, positionColum-1]}");
    } else{
        WriteLine("Такого элемента нет");
    }
}
Write("ВВедите количество строк и столбцов матрицы: ");
int[] paramMatrix = Array.ConvertAll(ReadLine().Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
Write("Введите искомую позицию в матрице: ");
int[] position = Array.ConvertAll(ReadLine().Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries), int.Parse);

double[,] arrForDz7=GetMatrix(paramMatrix[0], paramMatrix[1]);
PrintMatrix(arrForDz7);
GetValueInMatrix(arrForDz7, position[0], position[1]);
