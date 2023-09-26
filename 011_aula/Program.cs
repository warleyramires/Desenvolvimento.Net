namespace _011_aula;
class Program
{
    static void Main(string[] args)
    {

    
        ListaOrdenada estudantes = new ListaOrdenada();
        estudantes.Adicionar("Neila");
        estudantes.Adicionar("Valdomiro");
        estudantes.Adicionar("Sebastiao");
        estudantes.Adicionar("Fátima");
        estudantes.Adicionar("Lucio");
        estudantes.Adicionar("Tatiane");
        estudantes.Adicionar("Danilo");
        estudantes.Adicionar("Tadeu");
        estudantes.Adicionar("Luciana");
        estudantes.Adicionar("Alberto");
        estudantes.Adicionar("Caribe");
        estudantes.Adicionar("Guisso");

        Console.WriteLine("Ordenado pelo QuickSort");
        estudantes.SetEstrategia(new QuickSort());
        estudantes.Sort();
        Console.WriteLine();
        
        Console.WriteLine("Ordenado pelo MergeSort");
        estudantes.SetEstrategia(new MergeSort());
        estudantes.Sort();
        Console.WriteLine();
        

    }
}
