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
        System.Console.WriteLine();
        System.Console.Write(arr[n-1] + " ");
        for(int i=0; i<n-1; i++){
            System.Console.Write(arr[i] + " ");
        }
    }
}
