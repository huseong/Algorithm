using System;

namespace Selection_Sort {
    class Program {
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputs = new int[input.Length];
            for(int i=0; i<inputs.Length; i++) {
                inputs[i] = int.Parse(input[i]);
            }
            for(int i=0; i<inputs.Length; i++) {
                int minIndex = i;
                for(int j=i; j<inputs.Length; j++) {
                    if(inputs[minIndex] > inputs[j]) {
                        minIndex = j;
                    }
                }
                swap(ref inputs[i], ref inputs[minIndex]);
            }
            for(int i=0; i<inputs.Length; i++) {
                Console.Write(inputs[i] + " ");
            }
        }

        static void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
