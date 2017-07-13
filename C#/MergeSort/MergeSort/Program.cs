using System;

namespace MergeSort {
    class Program {
        static void Main (string[] args) {
            int[] arr = { 10, 30, 25, 29, 48, 90, 45 };
            double[] arr1 = { 12.5, 13.7, 11.5, 18.9, 14.2, 5.8 };
            Console.Write("int Array : ");
            printArr(arr);
            Console.Write("double Array : ");
            printArr(arr1);
            Console.Write("Sorted int Array : ");
            printArr(mergeSort(arr));
            Console.Write("Sorted double Array : ");
            printArr(mergeSort(arr1));
        }

        static void printArr<T>(T[] arr) {
            for(int i=0; i<arr.Length; i++) {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine();
        }

        static T[] merge<T>(T[] a, T[] b) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable {
            int i = 0;
            int j = 0;
            T[] returnArray = new T[a.Length + b.Length];
            int count = 0;
            while (true) {
                if (i == a.Length) {
                    int len = b.Length - j;
                    for (int k = 0; k < len; k++) {
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
                if (a[i].CompareTo(b[j]) < 0) {
                    returnArray[count++] = a[i++];
                } else {
                    returnArray[count++] = b[j++];
                }
            }
            return returnArray;
        }
        static T[] copy<T>(T[] arr, int startIndex, int size) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable {
            T[] returnArray = new T[size];
            for(int i=0; i<size; i++) {
                returnArray[i] = arr[startIndex + i];
            }
            return returnArray;
        }

        static T[] mergeSort<T>(T[] arr) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable {
            if(arr.Length > 1) {
                int mid = arr.Length / 2;
                return merge(mergeSort(copy(arr, 0, mid)), mergeSort(copy(arr, mid, arr.Length - mid)));
            }
            return arr;
        }
    }
}
