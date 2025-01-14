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
        int i = 0;
        for(int j=n-1; j>=0; j--){
            arr[i]=arr[j];
            i++;
            System.Console.Write(arr[j] + " ");
        }
    }

}