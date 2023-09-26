/*
1 - Escrever par ou ímpar na tela:
    a. com switch
    b. com if sem else
    c. sem nenhuma estrutura de controle
    d. com operador ternário
*/


namespace exercicio_01;
class Program
{
    static void Main(string[] args)
    {

        var numeral = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A) Com Switch");
        switch (numeral % 2 == 0)
        {
            case true:
                Console.WriteLine("PAR");
                break;
            case false:
                Console.WriteLine("IMPAR");
                break;

        }
        Console.WriteLine("--------------");

        Console.WriteLine("B) Com if sem else");
        string mensagem = "impar";
        if (numeral % 2 == 0)
        {
            mensagem = "par";
        }
        Console.WriteLine($"{numeral} é um numero: {mensagem}");
        Console.WriteLine("--------------");

        Console.WriteLine("C) Sem nenhuma estrutura de controle");
        string[] msg = { "par", "impar" };
        Console.WriteLine($"O {numeral} é {msg[numeral % 2]}");
        Console.WriteLine("--------------");


        Console.WriteLine("D) Com operador ternário");
        Console.WriteLine((numeral % 2 == 0 ? "Par" : "Impar"));
        Console.WriteLine("--------------");
    }
}
