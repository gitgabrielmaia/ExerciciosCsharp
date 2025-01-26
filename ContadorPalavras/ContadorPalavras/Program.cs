using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"A frase contém {palavras.Length} palavras.");
    }
}
