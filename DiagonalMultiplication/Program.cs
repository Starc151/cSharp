using static System.Console;
Clear();

int[] DiagonalMultiplication(){
    int[] arr={1, 2, 3, 4, 5, 6};
    // определяеи длину получаемого массива
    int resultLengt=0;
    if(arr.Length%2==0){
        resultLengt=arr.Length/2;
    }else{
        resultLengt=arr.Length/2+1;
    }
    int[] result=new int[resultLengt];
    
    for(int i=0; i<arr.Length/2; i++){
        result[i]=arr[i]*arr[arr.Length-i-1];
        // if(result[i]==arr[arr.Length-i-1]){
        //     result[arr[result.Length/2]]=arr[arr.Length/2];
        //     break;
        // }
    }
    // result[arr[result.Length/2]]=arr[arr.Length/2];
    return result;
}
Write(String.Join(", ", DiagonalMultiplication()));

