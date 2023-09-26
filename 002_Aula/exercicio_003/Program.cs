/*
3. Escreva um programa em C# que receba dois números inteiros (v1 e v2), e inverta os valores sem uma variável auxiliar. Portanto, ao final, v1 deve ter o valor de v2 e v2 o valor de v1.
*/

namespace exercicio_003;
class Program
{
    static void Main(string[] args)
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        int v1,v2;

        int.TryParse(num1, out v1);
        int.TryParse(num2, out v2);

        Console.WriteLine($"{v1}, {v2}");

        v1 = v1 ^ v2;
        v2 = v1 ^ v2;
        v1 = v1 ^ v2;

        Console.WriteLine($"{v1}, {v2}");
    }
}
