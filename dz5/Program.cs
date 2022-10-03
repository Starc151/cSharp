using static System.Console;
Clear();
// масив для всех задач
int[] arr=new int[10];
Random rnd=new Random();
for(int i=0; i<10; i++){
    arr[i]=rnd.Next(99, 1000);
}
Write(String.Join(", ", arr));
WriteLine();
//Задача 34:Напишите программу, которая покажет количество чётных чисел в массиве.
void PrintEven(int[] arr){
    int result=0;
    foreach(int i in arr){
        if(i%2==0){result++;}
    }
    WriteLine($"Количество четных чисел в массиве {result}");
}
/* Задача 36Найдите сумму элементов, стоящих на нечётных позициях массива.*/
int GetOddPositions(int[] arr){
    int sum=0;   
    for(int i=1; i<arr.Length; i+=2){
        sum+=arr[i];
    }
    return sum;
}

PrintEven(arr);
WriteLine($"Сумма элементов, стоящих на нечётных позициях массива равна {GetOddPositions(arr)}");