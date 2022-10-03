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
    Write(result);
}
PrintEven(arr);