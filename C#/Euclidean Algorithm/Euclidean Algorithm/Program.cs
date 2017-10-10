using System;

namespace Euclidean_Algorithm {
    
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine(greatestCommonDivisor(int.Parse(input[0]), int.Parse(input[1])));
        }

        private static int greatestCommonDivisor(int a, int b) {
            if (a > b) {
                int temp = a;
                a = b;
                b = temp;
            }
            while (true) {
                int r = a % b;
                if (r == 0) {
                    return b;
                }
                a = b;
                b = r;
            }
        }
    }
}
