/*
    Escreva um progrma em C# que utilize uma única expressão lambda para fazer todas as operações do Exercício 2. Em seguida exiba o resultado na tela
*/
using System.Linq;

namespace _003_aula;
class Program
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        int n1, n2;

        int.TryParse(input1, out n1);
        int.TryParse(input2, out n2);

        Func<int, int, int[]> operador = (num1, num2) => {
            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;
            int divisao = num1 / num2;
            int resto = num1 % num2;

            int[] result = {soma, subtracao, multiplicacao, divisao, resto};
        
            return result;

        };

        int[] result = operador(n1, n2);

        foreach(int n in result){
            Console.Write($"{n} ");
        }
    }
}
