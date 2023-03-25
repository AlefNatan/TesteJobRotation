using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite uma palavra ou frase: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        int length = charArray.Length;
        for (int i = 0; i < length / 2; i++) {
            char temp = charArray[i];
            charArray[i] = charArray[length - i - 1];
            charArray[length - i - 1] = temp;
        }

        string reversed = new string(charArray);
        Console.WriteLine($"A string invertida é: {reversed}");
    }
}
