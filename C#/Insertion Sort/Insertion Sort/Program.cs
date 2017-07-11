using System;

namespace Insertion_Sort {
    class Program {
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputs = new int[input.Length];
            for(int i=0; i<input.Length; i++) {
                inputs[i] = int.Parse(input[i]);
            }
            for(int i=0; i<inputs.Length; i++) {
                insertionSort(inputs, i);
            }
            for (int j = 0; j < inputs.Length; j++) {
                Console.Write(inputs[j] + " ");
            }
        }

        static void insertionSort(int[] arr, int index) { // inputs, 4, 2
            int value = arr[index]; // we have to assign index value in int.
            for(int i=0; i<index; i++) { // start compare index 1.
                if(arr[index] < arr[i]) { // if the value of array index i is bigger than our value, we have to put our value in that index and push all other indexs. 
                    int tam = arr[i];
                    for(int j=i+1; j<=index; j++) {
                        int temp = arr[j];
                        arr[j] = tam;
                        tam = temp;
                    }
                    arr[i] = value;
                    break;
                }
            }
        }
    }
}
