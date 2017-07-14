using System;

namespace Counting_Sort {
    class Program {
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int len = input.Length;
            int[] inputs = new int[len];
            inputs[0] = int.Parse(input[0]);
            int maxValue = inputs[0];
            for (int i=1; i<len; i++) {
                inputs[i] = int.Parse(input[i]);
                if (maxValue < inputs[i]) {
                    maxValue = inputs[i];
                }
            }
            int[] count = new int[maxValue+1];
            for(int i=0; i<len; i++) {
                count[inputs[i]]++;
            }
            for(int i=1; i<count.Length; i++) {
                count[i] += count[i - 1];
            }
            int[] array = new int[count[maxValue]];
            for (int i=0; i<len; i++) {
                array[(count[inputs[i]]--) - 1] = inputs[i];
            }
            for(int i=0; i<array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }
    }
}
