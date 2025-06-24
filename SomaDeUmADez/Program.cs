using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        int soma = CalcularSoma();

        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine($"\nA soma dos números de 1 a 10 é: {soma}");
    }

    public static int CalcularSoma()
    {
        int soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            soma += i;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Adicionando {i}, soma parcial: {soma}");
        }

        return soma;
    }
}