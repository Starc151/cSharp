using static System.Console;
Clear();

int[] DiagonalMultiplication(int[]arr){
    int len = arr.Length;
    int[] result=new int[len/2+len%2];
    for (int i=0; i<result.Length; i++){
        if(i!=len-i-1){
            result[i]=arr[i]*arr[len-i-1];
        }else{
            result[i]=arr[len/2];
        }
    }
    return result;
}
