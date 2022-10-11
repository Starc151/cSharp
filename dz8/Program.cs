using static System.Console;
Clear();
int[] GetParamMatrix(int num){
    Write($"Введите количество строк и столбцов матрицы №{num} через пробел: ");
    int[] paramMatrix = Array.ConvertAll(ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
    return paramMatrix;
}

int[,] GetMatrix(int[] paramMatrix){
    int[,] inArr=new int [paramMatrix[0], paramMatrix[1]];
    Random rnd=new Random();
    for(int i=0; i<inArr.GetLength(0); i++){
        for(int j=0; j<inArr.GetLength(1); j++){
            inArr[i, j]=rnd.Next(1, 6);
        }
    }
    return inArr;
}
 void PrintMatrix(int[,] inArr){
    for(int i=0; i<inArr.GetLength(0); i++){
        for(int j=0; j<inArr.GetLength(1); j++){
            Write($"{inArr[i, j]} ");
        }
        WriteLine();
    }
    WriteLine();
 }
//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] GetMatrixDescending(int[,] inArr){
//     for(int i=0; i<inArr.GetLength(0); i++){
//         int[] arrDescending=new int[inArr.GetLength(1)];
//         for(int j=0; j<inArr.GetLength(1); j++){
//             // arrDescending[i]=inArr[i,j];
//         }
//         // Array.Sort(arrDescending[i]);
//     }
//     return inArr;
// }
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//с наименьшей суммой элементов.
int GetRowMinimumSumm(int[,] inArr){
    int summ=0;
    int temp=0;
    int numRow=1;
    for(int i=0; i<inArr.GetLength(1); i++){
        summ+=inArr[0,i];
    }
    for(int i=1; i<inArr.GetLength(0); i++){
        for(int j=0; j<inArr.GetLength(1); j++){
            temp+=inArr[i,j];
        }
        if(summ>temp){
            summ=temp;
            numRow=i+1;    
        }
        temp=0;
    }
    return numRow;
}
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] GetMultiMatrices(int[,] matrixA, int[,] matrixB){
    int[,] multiMatrix=new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i=0; i<matrixA.GetLength(0); i++){
        for (int j=0; j<matrixB.GetLength(1); j++){
            for (int k=0; k<matrixB.GetLength(0); k++){
                multiMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return multiMatrix;
}

int[,] arrDz8_1=GetMatrix(GetParamMatrix(1));
int[,] arrDz8_2=GetMatrix(GetParamMatrix(2));
PrintMatrix(arrDz8_1);
PrintMatrix(arrDz8_2);

WriteLine($"Номер строки с наименьшей суммой чисел в массиве №1: {GetRowMinimumSumm(arrDz8_1)}");
WriteLine();
if(arrDz8_1.GetLength(1)!=arrDz8_2.GetLength(0)){
    Write("Произведение этих двух матриц невозможно!");
}else{
    WriteLine("Произведение матириц:");
    PrintMatrix(GetMultiMatrices(arrDz8_1, arrDz8_2));
}

