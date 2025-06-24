public class Program
{
    private static void Main(string[] args)
    {
        DesenharCabecalho();
        Console.Write("Informe seu peso em kg: ");
        double peso = double.Parse(Console.ReadLine()); 

        Console.Write("Informe sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine()); 

        double imc = CalcularImc(peso, altura);

        DesenharCabecalho(); 
        Console.WriteLine($"\nSeu IMC é: {imc:F2}");
        Console.WriteLine($"Classificação: {ClassificarImc(imc)}");
    }

    public static void DesenharCabecalho()
    {
        Console.Clear();
        Console.WriteLine("Calculadora de IMC");
        Console.WriteLine("----------------------\n");
    }

    public static double CalcularImc(double peso, double altura)
    {
        altura = altura / 100;
        return peso / (altura * altura);
    }

    public static string ClassificarImc(double imc)
    {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 25)
            return "Peso normal";
        else if (imc < 30)
            return "Sobrepeso";
        else
            return "Obesidade";
    }
}