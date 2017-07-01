using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort {
    class Program {
        static int heapSize;
        // 최소 힙 정렬 기준이다.
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            heapSize = input.Length;
            int[] arr = new int[heapSize + 1];
            int len = heapSize + 1;
            for(int i=1; i<len; i++) {
                pushToHeap(arr, i, int.Parse(input[i - 1]));
            }
            for (int i = 1; i < len; i++) {
                Console.Write(popFromHeap(arr) + " ");
            }
        }

        static void printHeap(int[] arr) {
            Console.Write("[ ");
            int len = heapSize - 1;
            for(int i=1; i<len; i++) {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[heapSize - 1] + "]");
        }

        static void pushToHeap(int[] arr, int key, int value) {
            arr[key] = value;
            while(key > 1) {
                if(arr[key] < arr[key/2]) {
                    swap(ref arr[key], ref arr[key / 2]);
                    key /= 2;
                } else {
                    break;
                }
            }
        }

        static int popFromHeap(int[] arr) {
            int key = 1;
            int returnValue = arr[key];
            arr[key] = arr[heapSize];
            heapSize--;
            while (key*2 <= heapSize) {
                if(arr[key] > arr[key * 2]) {
                    if(arr[key] > arr[key * 2 + 1]) {
                        if(arr[key*2] > arr[key*2 +1]) {
                            swap(ref arr[key], ref arr[key * 2 + 1]);
                            key = key * 2 + 1;
                        }
                        else {
                            swap(ref arr[key], ref arr[key * 2]);
                            key = key * 2;
                        }
                    } else {
                        swap(ref arr[key], ref arr[key * 2]);
                        key = key * 2;
                    }
                } else if(arr[key] > arr[key * 2 + 1]) {
                    swap(ref arr[key], ref arr[key * 2 + 1]);
                    key = key * 2 + 1;
                } else {
                    break;
                }
            }
            return returnValue;
        }

        static void swap(ref int a, ref int b) {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
