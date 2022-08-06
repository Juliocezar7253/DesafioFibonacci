using System;

namespace Fibonacci { 
    public class Fibonacci {

        public static void Main(string[] args) => verifyNumber();

        static int[] generateSequence() {
        int n = 0, n1 = 1;
            var aux = 0;
            List<int> listOfNumbers = new List<int>();

            for (int i = 0; i < 60; i++) {
                aux = n;
                n = n1;
                n1 = n + aux;
                listOfNumbers.Add(n1); 
            }

            int[] sequence = listOfNumbers.ToArray();
            return sequence;
        }

        static void verifyNumber() {
            var seq = generateSequence();

            Console.WriteLine("Digite o número que deseja encontrar: ");
            var number = int.Parse(global::System.Console.ReadLine());

            var numberInSequence = Array.Exists(seq, num => num == number);

            if (numberInSequence) {
                Console.WriteLine("O número {0} está contido na sequência de fibonacci", number);
            } else {
                Console.WriteLine("O número {0} não está contido na sequência de fibonacci", number);
            }
        }
    }
}