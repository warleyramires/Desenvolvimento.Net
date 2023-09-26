/*
1. Pesquise e apresente uma forma de exibir todos os elementos da variável List “nomes” do slide da aula, sem usar uma estrutura de repetição, nos moldes tradicionais.
*/
namespace exercicio_001;
class Program
{
    static void Main(string[] args)
    {
        List<string> nomes = new List<string>();

        nomes. AddRange(new[]{".net", "2023", "ifnmg"});

       Console.WriteLine(String.Join(" | ", nomes));


    }
}
