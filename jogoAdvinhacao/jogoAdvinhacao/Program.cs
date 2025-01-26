using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101);
        int palpite = 0;
        int tentativas = 0;

        Console.WriteLine("Adivinhe o número secreto (entre 1 e 100):");

        while (palpite != numeroSecreto)
        {
            string entrada = Console.ReadLine();
            bool isNumero = int.TryParse(entrada, out palpite);  // Verifica se a entrada pode ser convertida para um número

            if (!isNumero)
            {
                Console.WriteLine("Por favor, digite um número válido.");
                continue; // Continua o loop sem incrementar as tentativas
            }

            tentativas++;

            if (palpite > numeroSecreto)
                Console.WriteLine("O número é menor. Tente novamente.");
            else if (palpite < numeroSecreto)
                Console.WriteLine("O número é maior. Tente novamente.");
        }

        Console.WriteLine($"Você acertou! O número era {numeroSecreto}. Tentativas: {tentativas}");
    }
}

