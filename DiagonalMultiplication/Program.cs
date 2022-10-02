using static System.Console;
Clear();

int[] DiagonalMultiplication(){
    int[] arr={1, 2, 3, 4, 5};
    // определяеи длину получаемого массива
    int[] result=new int[arr.Length/2+arr.Length%2];
    
    for(int i=0; i<arr.Length/2; i++){
        result[i]=arr[i]*arr[arr.Length-i-1];
        if(arr[i]==arr[arr.Length-1-i]){break;}
        if(result[i]==arr[arr.Length-i-1]){
            result[arr[result.Length/2]]=arr[arr.Length/2];
        }
    }
    // result[arr[result.Length/2]]=arr[arr.Length/2];
    return result;
}
Write(String.Join(", ", DiagonalMultiplication()));

