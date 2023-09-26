/*
   2. Escreva um programa em C# que receba dois números inteiros do usuário
    e exiba o resultado das seguintes operações: adição, subtração, multiplicação
    divisão inteia e resto da divisão entre os números;
*/

namespace exercicio_002;
class Program
{
    static void Main(string[] args)
    {
        
     string input1 = Console.ReadLine();
     string input2 = Console.ReadLine();
     int n1,n2;

     int.TryParse(input1, out n1);
     int.TryParse(input2, out n2);

    Console.WriteLine(n1 + n2);
    Console.WriteLine(n1 - n2);
    Console.WriteLine(n1 * n2);
    Console.WriteLine(n1 / n2);
    Console.WriteLine(n1 % n2);
    }

}
