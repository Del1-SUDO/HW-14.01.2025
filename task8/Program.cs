using System;
class Program {
    static void Main() {
        System.Console.Write("Array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        System.Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < n; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }

        EvenNumbers(arr, n);
    }

    static void EvenNumbers(int[] arr, int n) {
        for(int i=0; i<n-1; i+=2){
            int temp = arr[i];
            arr[i]=arr[i+1];
            arr[i+1]=temp;
        }

        System.Console.WriteLine();
        for(int i=0; i<n; i++){
            System.Console.Write(arr[i] + " ");
        }
    }
}
