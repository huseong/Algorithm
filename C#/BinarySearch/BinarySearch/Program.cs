using System;

namespace BinarySearch {
    class Program {
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputs = new int[input.Length];
            for(int i=0; i<input.Length; i++) {
                inputs[i] = int.Parse(input[i]);
            }
            binarySearch(inputs, int.Parse(Console.ReadLine()));
        }

        static void binarySearch(int[] inputs, int value) {
            int left = 0;
            int right = inputs.Length - 1;
            while(true) {
                if(left > right) {
                    Console.WriteLine("No No No~ Value~ Not Valve");
                    break;
                }
                int mid = (left + right) / 2;
                if(value == inputs[mid]) {
                    Console.WriteLine("YES!");
                    break;
                } else if (value <inputs[mid]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
        }
    }
}
