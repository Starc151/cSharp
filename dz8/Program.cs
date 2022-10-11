using static System.Console;
Clear();

int[,] GetMatrix(){
    int[,] inArr=new int [4, 4];
    Random rnd=new Random();
    for(int i=0; i<4; i++){
        for(int j=0; j<4; j++){
            inArr[i, j]=rnd.Next(0, 9);
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
void GetRowMinimumSumm(int[,] inArr){
    int summ=0;
    int temp=0;
    int count=1;
    for(int i=0; i<inArr.GetLength(1); i++){
        summ+=inArr[0,i];
    }
    for(int i=1; i<inArr.GetLength(0); i++){
        for(int j=0; j<inArr.GetLength(1); j++){
            temp+=inArr[i,j];
        }
        if(summ>temp){
            summ=temp;
            count=i+1;    
        }
        temp=0;
    }
    Write($"Номер строки с наименьшей суммой чисел{count}");
}




int[,] arrDz8=GetMatrix();
PrintMatrix(arrDz8);
GetRowMinimumSumm(arrDz8);
