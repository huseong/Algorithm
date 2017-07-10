using System;

namespace MergeSort {
    class Program {
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputs = new int[input.Length];
            for(int i=0; i<input.Length; i++) {
                inputs[i] = int.Parse(input[i]);
            }
            printArr(mergeSort(inputs));
        }

        static void printArr(int[] arr) {
            for(int i=0; i<arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }

        static int[] merge(int[] a, int[] b) {
            int i = 0;
            int j = 0;
            int[] returnArray = new int[a.Length + b.Length];
            int count = 0;
            while(true) {
                if(i == a.Length) {
                    int len = b.Length - j;
                    for(int k=0; k<len; k++) {
                        returnArray[count++] = b[j + k];
                    }
                    break;
                }
                if (j == b.Length) {
                    int len = a.Length - i;
                    for (int k = 0; k < len; k++) {
                        returnArray[count++] = a[i + k];
                    }
                    break;
                }
                if (a[i] < b[j]) {
                    returnArray[count++] = a[i++];
                } else {
                    returnArray[count++] = b[j++];
                }
            }
            return returnArray;
        }
        static int[] copy(int[] arr, int startIndex, int size) {
            int[] returnArray = new int[size];
            for(int i=0; i<size; i++) {
                returnArray[i] = arr[startIndex + i];
            }
            return returnArray;
        }

        static int[] mergeSort(int[] arr) {
            if(arr.Length > 1) {
                int mid = arr.Length / 2;
                return merge(mergeSort(copy(arr, 0, mid)), mergeSort(copy(arr, mid, arr.Length - mid)));
            }
            return arr;
        }
    }
}
