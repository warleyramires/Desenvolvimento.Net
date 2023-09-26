using System.ComponentModel;

namespace _009_Aula;

public static class ListNumbers
{
    public static double CalcMedia(this List<double> list)
    {

        double soma = 0;
        double media = 0;

        if (list == null)
        {
            Console.WriteLine("Lista vazia");
        }
        else
        {
            soma = list.Sum();
            media = soma / list.Count;
        }

        return media;

    }
}

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double> { 3.2, 5.5, 12.8, 9.3 };
        /*
        Fique a vontade para adicionar mais números, Lu!
        numbers.Add(14);
        */
        double media = numbers.CalcMedia();

        Console.WriteLine($"Média: {media:F2}");

    }
}
