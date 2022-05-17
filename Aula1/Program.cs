using static System.Console;

class Program
{
    static void Main()
    {
        int valor1;
        int valor2;
        int total;

        WriteLine("Digite o primeiro valor.");
        valor1 = int.Parse(ReadLine());
        WriteLine("Digite o segundo valor.");
        valor2 = int.Parse(ReadLine());

        total = valor1 + valor2;
        WriteLine($@"O primeiro valor é {valor1}, o segundo valor é {valor2}.
A soma dos dois valores é: {total}");

    }
}

