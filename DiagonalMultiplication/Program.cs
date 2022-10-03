using static System.Console;
Clear();

int[] DiagonalMultiplication(){
    int[] arr={1, 2, 3, 4, 5};
    // определяем длину получаемого массива
    int len = arr.Length;
    int[] result=new int[len/2+len%2];
    for(int i=0; i<len/2; i++){
        result[i]=arr[i]*arr[len-i-1];
        if(arr[i]==arr[len-1-i]){break;}
        if(result[i]==arr[len-i-1]){
            result[arr[result.Length/2]]=arr[len/2];
        }
    }
    return result;
}
Write(String.Join(", ", DiagonalMultiplication()));

