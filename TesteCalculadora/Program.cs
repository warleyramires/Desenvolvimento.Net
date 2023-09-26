namespace TesteCalculadora;
class Program
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();
        int n1, n2;

        int.TryParse(input1, out n1);
        int.TryParse(input2, out n2);


       

        Calculadora calc = new();
 
        calc.SetNum1(n1);
        calc.SetNum2(n2);
        calc.SetOperacao(input3);

        string msg = calc.Calcular();

        Console.WriteLine($"{msg}");
        
    }
}
