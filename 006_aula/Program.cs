namespace _006_aula;
class Program
{

    static void AdivinhaNumero(int numAleatorio, Random rand, int numLimiteInt)
    {
        int tentativa = 0;
        int numeroInt;
        int randomNumber = numAleatorio;

         Console.WriteLine("ATENÇÃO: Caso você ultrapasse o número de 5 tentativas o valor irá mudar");

        do
        {

            if (tentativa >= 5)
            {
                Console.WriteLine($"O numero correto era: {randomNumber}");
                randomNumber = rand.Next(0, numLimiteInt + 1);
                //Console.WriteLine($"Novo numero gerado: {randomNumber}");

                tentativa = 0;
            }
            ++tentativa;
            Console.WriteLine($"Tentativa de numero {tentativa}: ");
            string numero = Console.ReadLine();

            int.TryParse(numero, out numeroInt);
            if (numeroInt > randomNumber)
            {
                Console.WriteLine($"O numero {numeroInt} ta quente");
            }
            else if (numeroInt < randomNumber)
            {
                Console.WriteLine($"O numero {numeroInt} ta frio");
            }

        } while (numeroInt != randomNumber && tentativa <= 5);

        Console.WriteLine($"Parabéns você acertou. O número é {randomNumber}");
    }
    static void Main(string[] args)
    {

        Random rand = new Random();

        while (true)
        {
            Console.WriteLine("Informe o numero limite");
            string numLimite = Console.ReadLine();
            try
            {
                int numLimiteInt;
                int numAleatorio;

                if (int.TryParse(numLimite, out numLimiteInt))
                {

                    if (numLimiteInt < 0)
                    {
                        Console.WriteLine("Informe apenas números positivos");
                    }
                    else
                    {
                        numAleatorio = rand.Next(0, numLimiteInt + 1);

                        //Console.WriteLine(numAleatorio);
                        AdivinhaNumero(numAleatorio, rand, numLimiteInt);

                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Apenas números inteiros meu chapa");
                }

                Console.Write("Deseja jogar mais uma vez? (Digite 'S' para sim e 'N' para não): ");
                string repetir = Console.ReadLine().Trim().ToLower();
                if (repetir != "s")
                {
                    break;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Valor inválido. Apenas números inteiros meu chapa - 2");
            }
        }


    }
}

