namespace _007_aula;
class Program
{
    static void Main(string[] args)
    {

        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3;
        int n1, n2, nextNum = 0, qtdNum = 2;

        int.TryParse(input1, out n1);
        int.TryParse(input2, out n2);
        string repetir;

        Calculadora calc = new();

        calc.SetNum1(n1);
        calc.SetNum2(n2);

        string resultado;

        do
        {
            Console.Write("Deseja adicionar mais um número ao cálculo? (Digite 'S' para sim e 'N' para não): ");
            repetir = Console.ReadLine().Trim().ToLower();

            if (repetir == "s")
            {
                Console.Write("Digite o próximo número que deseja adicionar ao cálculo: ");
                input3 = Console.ReadLine();
                int.TryParse(input3, out nextNum);
                calc.SetProxNum(nextNum);
                ++qtdNum;
                calc.SetqtdNumeros(qtdNum);
            }
            resultado = calc.ToString();
            //calc.CalcularMedia();
            Console.WriteLine(resultado);
        } while (repetir == "s");


    }
}
