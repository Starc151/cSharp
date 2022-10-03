using static System.Console;
Clear();
// масив для всех задач
int[] arr=new int[10];
Random rnd=new Random();
for(int i=0; i<10; i++){
    arr[i]=rnd.Next(99, 1000);
}
