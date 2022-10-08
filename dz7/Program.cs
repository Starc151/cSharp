using static System.Console;
Clear();

//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
double[,] GetMatrixArr(int rows, int colums)
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
void PrintMatrixArray(double[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            Write($"{inArr[i, j]} ");
        }
        WriteLine();
    }
}
Write("Введите количество строк: ");
int rowsInArray = Convert.ToInt32(ReadLine());
Write("Введите количество стлбцов: ");
int columsInArray = Convert.ToInt32(ReadLine());
PrintMatrixArray(GetMatrixArr(rowsInArray, columsInArray));
