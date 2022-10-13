using static System.Console;
Clear();
int[] GetParamMatrix(string comment){
    Write($"Введите размерность матрицы {comment}, через пробел: ");
    int[] paramMatrix = Array.ConvertAll(ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
    return paramMatrix;
}

int[,] GetMatrix(int[] paramMatrix){
    int[,] inArr=new int [paramMatrix[0], paramMatrix[1]];
    Random rnd=new Random();
    for(int i=0; i<inArr.GetLength(0); i++){
        for(int j=0; j<inArr.GetLength(1); j++){
            inArr[i, j]=rnd.Next(0, 10);
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
int[,] GetMatrixDescending(int[,] inArr){
    int temp=0;
    for(int i=0; i<inArr.GetLength(0); i++){
        for (int k=0; k<inArr.GetLength(1)-1; k++){
            for (int j=k+1; j<inArr.GetLength(1); j++){
                if (inArr[i, k]<inArr[i, j]){
                    temp = inArr[i, k];
                    inArr[i, k] = inArr[i, j];
                    inArr[i, j] = temp;
                }
            }
        }
    }
    return inArr;
}
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
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void GetMatrix3(int x, int y, int z){
    if((x*y*z)>90){
        WriteLine("Невозможно заполнить неповторяющимися двузначными числами");
        return;
    }
    Random rnd=new Random();
    int[,,] matrix3 = new int[z, y, y];
    int reservLen=90;
    int[] reserv=new int[reservLen];
    
    for(int i=0; i<reservLen; i++){
        reserv[i]=i+10;
    }
    for (int i=0, j=0, tmp=0; i<reservLen; i++){
        j=rnd.Next(reservLen);
        tmp=reserv[j];
        reserv[j] = reserv[i];
        reserv[i] = tmp;
    }
    for(int i=0, r=0; i<matrix3.GetLength(0); i++){
        for(int j=0; j<matrix3.GetLength(1); j++){
            for(int k=0; k<matrix3.GetLength(2); k++, r++){
                matrix3[i, j, k]=reserv[r];
            }
        }
    }
    WriteLine($"Трёхмерный массив {x}х{y}х{z}х");
    for(int i=0; i<matrix3.GetLength(0); i++){
        for(int j=0; j<matrix3.GetLength(1); j++){
            for(int k=0; k<matrix3.GetLength(2); k++){
                Write($"{matrix3[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
    WriteLine();
}
//Задача 62. Напишите программу, которая заполнит спирально массив
int[,] SnailArr(int[] paramMatrix){
    int sizeY=paramMatrix[0];
    int sizeX=paramMatrix[1];
    int[,] inArr=new int[sizeY, sizeX];
    int offsetY=0;
    int offsetX=0;
    int count=1;
    while(sizeY>0){
        for(int y=0; y<4; y++){
            for(int x=0; x<((sizeX<sizeY) ? sizeY :sizeX); x++){
                if(y==0 && x<sizeX-offsetX){
                    inArr[y+offsetY, x+offsetX]=count++;
                }
                if(y==1 && x<sizeY-offsetY && x!=0){
                    inArr[x+offsetY, sizeX-1] = count++;
                }
                if (y==2 && x<sizeX-offsetX && x!=0){
                    inArr[sizeY-1, sizeX-(x+1)]=count++;
                }
                if (y==3 && x<sizeY-(offsetY+1) && x!=0){
                    inArr[sizeY-(x+1), offsetY]=count++;
                }
            }
        }
        sizeY--;
        sizeX--;
        offsetY ++;
        offsetX ++;
    }
    return inArr;
}
int[,] arrDz8_1=GetMatrix(GetParamMatrix("№1"));
int[,] arrDz8_2=GetMatrix(GetParamMatrix("№2"));
PrintMatrix(arrDz8_1);
PrintMatrix(arrDz8_2);

WriteLine("Массив №1 с отсортированными строками:");
PrintMatrix(GetMatrixDescending(arrDz8_1));

WriteLine($"Номер строки с наименьшей суммой чисел в массиве №1: {GetRowMinimumSumm(arrDz8_1)}");
WriteLine();

if(arrDz8_1.GetLength(1)!=arrDz8_2.GetLength(0)){
    Write("Произведение этих двух матриц невозможно!");
}else{
    WriteLine("Произведение матириц:");
    PrintMatrix(GetMultiMatrices(arrDz8_1, arrDz8_2));
}

int[] paramMatrix3=GetParamMatrix("3х3");
GetMatrix3(paramMatrix3[0], paramMatrix3[1], paramMatrix3[2]);

WriteLine("Массив Улитка:");
PrintMatrix(SnailArr(GetParamMatrix("для закручивания улиткой")));
