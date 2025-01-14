using System;
class Program{
    static void Main(){
        System.Console.Write("Array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        System.Console.WriteLine("Enter array elements: ");
        for(int i=0; i<n; i++){
            arr[i]=int.Parse(Console.ReadLine());
        }

        EvenNumbers(arr,n);
    }

    static void EvenNumbers(int[] arr, int n){
        int cnt = 0;
        for(int i=0; i<n-1; i++){
            if(arr[i]>=0 && arr[i+1]>=0 || arr[i]<0 && arr[i+1]<0){
                cnt++;
            }
        }

        System.Console.WriteLine();
        if(cnt>=1){
            System.Console.WriteLine("Yes");
        }
        else{
            System.Console.WriteLine("No");
        }
    }

}