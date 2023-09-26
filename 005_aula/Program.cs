/*
    Crie um programa que calcule o valor de uma parcela
    de um determinado financiamento. Usuário deve fornecer
    a taxa de juros mensal, o número de parcelas, e o valor do
    bem. O programa deve fornecer o valor da parcela e 
    permitir repetir a operação

*/
using System;

namespace _005_aula;
class Program
{

    static double Calculadoraparcela(double valor, double taxaMensal, int qtdParcelas)
    {
        double taxaJurosDecimal = taxaMensal / 100;
        double parcela = (valor * taxaJurosDecimal) / (1 - Math.Pow(1 + taxaJurosDecimal, -qtdParcelas));
        return parcela;
    }
    static void Main(string[] args)
    {

        while (true)
        {
            try
            {
                //int qtdMeses;
                //double taxaMensal;
                //double valorDoFinanciamento;
/*
                Console.WriteLine("Informe o número de meses");
                string input1 = Console.ReadLine();
                Console.WriteLine("Valor da taxa %: ");
                string taxa = Console.ReadLine();
                Console.WriteLine("Valor financiamento: ");
                string valorFinanciamento = Console.ReadLine(); */

                Console.WriteLine("Digite o número de parcelas:");
                double numeroParcela = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a taxa de juros mensal:");
                double taxaJuros = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor financiado:");
                double valorFinanciado = double.Parse(Console.ReadLine());


                //int.TryParse(input1, out qtdMeses);
                //double.TryParse(taxa, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out taxaMensal);
                //double.TryParse(valorFinanciamento, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out valorDoFinanciamento);
                //Console.WriteLine($"{n1}, {input2}, {input3}");

                double parcela = Calculadoraparcela(valorFinanciamento, taxa, qtdMeses);

                parcela = Math.Round(parcela, 2);
                double valorTotal = parcela * qtdMeses;
                double totalJuros = valorTotal - valorFinanciamento;

                Console.WriteLine($"Parcela: {parcela:F2}");
                Console.WriteLine($"Total a ser pago: R$ {valorTotal:F2}");
                Console.WriteLine($"Total pago em juros: R$ {totalJuros:F2}");

                Console.Write("Continuar calculando? (Digite 'S' para sim e 'N' para não): ");
                string repetir = Console.ReadLine().Trim().ToLower();
                if (repetir != "s")
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida.");
            }
        }


        // Arredondamento:
        // Math.Round(valor, 2, midpointRouding.ToZero);

    }
}
