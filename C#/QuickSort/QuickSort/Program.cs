using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[10];
            string[] abs = new string[10];
            randomIntArr(arr);
            IComparable[] input = new IComparable[arr.Length];
            arr.CopyTo(input, 0);
            printArr(input);
            quickSort(input, 0, arr.Length - 1);
            printArr(input);
        }

        static void randomIntArr(int[] arr) {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(100);
            }
        }

        static void printArr(IComparable[] arr) {
            Console.Write("Arr : ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(string.Format("{0} ", arr[i]));
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void quickSort(IComparable[] element, int left, int right) {
            int i = left;
            int j = right;
            IComparable pivot = element[(left + right) / 2];
            while (i <= j) {
                while (element[i].CompareTo(pivot) < 0) {
                    i++;
                } // 여기서 좌측에 있고 피봇보다 큰 값이면 element[i]가 그 값이다.
                while (element[j].CompareTo(pivot) > 0) {
                    j--;
                } // 여기서 우측에 있고 피봇보다 작은 값이면 element[j] 가 그 값이다.
                if (i <= j) { // 피봇을 기준으로 값을 교체한다. 이를 수행할 경우 
                    Console.WriteLine("값 교체 (피봇 : " + pivot + " 좌측값 : " +element[left] + " 우측값 : " + element[right] + ") " + element[i] + "과 " + element[j]);
                    IComparable tmp = element[i];
                    element[i] = element[j];
                    element[j] = tmp;
                    printArr(element);
                    i++;
                    j--;
                }
            }
            if (left < j) { // 만약 
                quickSort(element, left, j);
            }
            if (i < right) {
                quickSort(element, i, right);
            }
        }
    }
}
