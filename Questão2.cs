using System;

public class Program {
    public static void Main() {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        bool pertence = false;
        int a = 0, b = 1, c = 1;
        while (c <= num) {
            if (c == num) {
                pertence = true;
                break;
            }
            a = b;
            b = c;
            c = a + b;
        }

        if (pertence) {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci!");
        } else {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
        }
    }
}
