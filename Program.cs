// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Runtime.CompilerServices;

int valor1;
int valor2;
string resp;
const double imposto = 0.21;
double valorSemImposto = 23.5;
double resultado;
int totalEleitores;
int votosValidos;
int votosBrancos;
int votosNulos;



valor1 = int.Parse(Console.ReadLine());
valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("1 - Adição\n 2- Multiplicação\n3- Divisão\n");
resp = Console.ReadLine();
RealizarOperacao(valor1,valor2, resp);
MatrizQuadrada(4);
TrocarNumero(valor1, valor2);


static void Imposto(double imposto, double valorSemImposto, double resultado) {
    resultado = valorSemImposto - (imposto * valorSemImposto);
    Console.WriteLine("valor Sem Imposto" + resultado);
    Console.ReadLine();
}

static void RealizarOperacao(int valor1, int valor2, string resp)
{
    if (resp.Equals("1"))
    {
        Console.WriteLine("A resposta da adição é: " + (valor1 + valor2));
    }
    else if (resp.Equals("2"))
    {
        Console.WriteLine("A resposta da multiplicação é: " + (valor1 * valor2));
    }
    else if (resp.Equals("3"))
    {
        if (valor2 != 0)
        {
            Console.WriteLine("A resposta da divisão é: " + (valor1 / (double)valor2));
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}
static void MatrizQuadrada(int numero)
{
    Console.WriteLine("\nRaiz quadrada de "+ numero + "é : " + Math.Sqrt(numero));
}
static void TrocarNumero(int valor1, int valor2)
{
    valor1 += valor2;
    valor2 = valor1 - valor2;
    valor1 = valor1 - valor2;

    Console.WriteLine("\nvalor 1 = " + valor1 );
    Console.WriteLine("\nvalor 2 = " + valor2 );
}
static void Votos(int votosValidos, int votosBrancos, int votosNulos, int totalEleitores)
{
    Console.WriteLine("Digite o total de eleitores do município: ");
    totalEleitores = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o total de votos válidos: ");
    votosValidos = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o total de votos em branco: ");
    votosBrancos = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o total de votos nulos: ");
    votosNulos = int.Parse(Console.ReadLine());

    // Cálculo dos percentuais
    double percentualValidos = (votosValidos / (double)totalEleitores) * 100;
    double percentualBrancos = (votosBrancos / (double)totalEleitores) * 100;
    double percentualNulos = (votosNulos / (double)totalEleitores) * 100;

    // Exibição dos resultados
    Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");
    Console.WriteLine($"Percentual de votos em branco: {percentualBrancos:F2}%");
    Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
}