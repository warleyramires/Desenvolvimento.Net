namespace exercicio_02;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());
        switch (numero1 > numero2)
        {
            case true:
                Console.WriteLine($"O numero  {numero1} e o maior que o numero {numero2}");
                break;
            case false:
                Console.WriteLine($"O numero {numero2} e o maior que o numero {numero1}");
                break;
        }
    }
}