using System;

public class Program
{
    // letra A
    public static int MaiorDiferenca(int[] vetor)
    {
        int maiorNumero = int.MinValue;
        int menorNumero = int.MaxValue;

        foreach (int numero in vetor)
        {
            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
            if (numero < menorNumero)
            {
                menorNumero = numero;
            }
        }

        int maiorDif = maiorNumero - menorNumero;
        Console.WriteLine($"A maior diferença entre os números é {maiorDif}");
        return maiorDif;
    }

    // letra B
    public static bool VetorEmOrdem(int[] vetor)
    {
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i - 1] > vetor[i])
            {
                Console.WriteLine("O vetor não está em ordem crescente.");
                return false;
            }
        }

        Console.WriteLine("O vetor está em ordem crescente.");
        return true;
    }

    public static void Main()
    {
        Console.Write("Qual o tamanho do seu vetor? ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o {i + 1}º número para o vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        MaiorDiferenca(vetor);
        VetorEmOrdem(vetor);
    }
}
