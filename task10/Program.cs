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
        int max = arr[0];
        for(int i=0; i<n; i++){
            if(arr[i]>max){
                max=arr[i];
            }
        }
        System.Console.WriteLine();
        System.Console.Write($"The largest number in array is: {max}");
    }
}
