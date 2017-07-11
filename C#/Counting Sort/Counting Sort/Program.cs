using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort {
    class Program {
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputs = new int[input.Length];
            for(int i=0; i<inputs.Length; i++) {
                inputs[i] = int.Parse(input[i]);
            }
            int maxValue = inputs[0];
            for(int i=1; i<inputs.Length; i++) {
                if(maxValue < inputs[i]) {
                    maxValue = inputs[i];
                }
            }
            int[] count = new int[maxValue+1];
            for(int i=0; i<inputs.Length; i++) {
                count[inputs[i]]++;
            }
            for(int i=1; i<count.Length; i++) {
                count[i] += count[i - 1];
            }
            int[] array = new int[count[maxValue]];
            for (int i=0; i<inputs.Length; i++) {
                array[(count[inputs[i]]--) - 1] = inputs[i];
            }
            for(int i=0; i<array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }
    }
}
