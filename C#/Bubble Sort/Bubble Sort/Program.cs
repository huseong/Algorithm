using System;
using System.Threading;
namespace Bubble_Sort {
    class Program {
        static int swapCount = 0;
        static void Main (string[] args) {
            testFunc();
            //string[] input = Console.ReadLine().Split(' ');
            //int[] inputs = new int[input.Length];
            //for(int i=0; i<input.Length; i++) {
            //    inputs[i] = int.Parse(input[i]);
            //}
            //int len = input.Length;
            //for(int i=0; i<len; i++) {
            //    int jlen = len - i - 1;
            //    for(int j=0; j<jlen; j++) {
            //        if(inputs[j] > inputs[j+1]) {
            //            swap(ref inputs[j], ref inputs[j + 1]);
            //        }
            //    }
            //}
            //for(int i=0; i<len; i++) {
            //    Console.Write(inputs[i] + " ");
            //}
        }
        static int answer = 0;
        static void testFunc() {
            while(true) {
                Random ran = new Random();
                int len = ran.Next(100);
                int[] n = new int[len];
                int[] na = new int[len];
                for(int i=0; i<len; i++) {
                    n[i] = ran.Next(100);
                    na[i] = n[i];
                    Console.Write(n[i] + " ");
                }
                Console.WriteLine();
                int count = 0;
                bubbleSort(n, ref count);
                mergeSort(na);
                Console.WriteLine(count == answer);
                answer = 0;
                Thread.Sleep(1000);
            }
        }

        static void bubbleSort(int[] inputs, ref int swapCount) {
            int len = inputs.Length;
            for (int i = 0; i < len; i++) {
                int jlen = len - i - 1;
                for (int j = 0; j < jlen; j++) {
                    if (inputs[j] > inputs[j + 1]) {
                        swap(ref inputs[j], ref inputs[j + 1], ref swapCount);
                    }
                }
            }
        }

        static void swap(ref int a, ref int b, ref int swapCount) {
            swapCount++;
            int temp = a;
            a = b;
            b = temp;
        }

        static int[] copyArray (int[] arr, int startIndex, int size) {
            int[] array = new int[size];
            for (int i = 0; i < size; i++) {
                array[i] = arr[startIndex + i];
            }
            return array;
        }

        // 2 4 1 3 5 // 2 (1 4) (3 5)
        static int[] merge (int[] arr1, int[] arr2) {
            int i = 0;
            int j = 0;
            int[] returnArray = new int[arr1.Length + arr2.Length];
            int count = 0;
            while (true) {
                if (arr2.Length == j) {
                    for (; i < arr1.Length; i++) {
                        returnArray[count++] = arr1[i];
                    }
                    break;
                }
                if (arr1.Length == i) {
                    for (; j < arr2.Length; j++) {
                        returnArray[count++] = arr2[j];
                    }
                    break;
                }
                if (arr1[i] <= arr2[j]) {
                    returnArray[count++] = arr1[i++];
                } else {
                    answer += arr1.Length - i;
                    returnArray[count++] = arr2[j++];
                }
            }
            return returnArray;
        }

        static int[] mergeSort (int[] arr) {
            if (arr.Length > 1) {
                int mid = arr.Length / 2;
                return merge(mergeSort(copyArray(arr, 0, mid)), mergeSort(copyArray(arr, mid, arr.Length - mid)));
            }
            return arr;
        }
    }
}
