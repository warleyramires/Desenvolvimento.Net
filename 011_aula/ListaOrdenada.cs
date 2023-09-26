public class ListaOrdenada
{
    private List<string> lista;
    private IOrdenacao estrategiaOrdenacao;

    public ListaOrdenada()
    {

        lista = new List<string>();
    }

    public ListaOrdenada(IOrdenacao estrategia)
    {
        lista = new List<string>();
        estrategiaOrdenacao = estrategia;
    }

    public void Adicionar(string item)
    {
        lista.Add(item);
    }

    public void SetEstrategia(IOrdenacao estrategia)
    {
        estrategiaOrdenacao = estrategia;
    }

    public void Sort()
    {
        if (estrategiaOrdenacao != null)
        {
            estrategiaOrdenacao.Sort(lista);
            Console.WriteLine("Lista ordenada:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Nenhuma estratégia de ordenação definida.");
        }
    }
}