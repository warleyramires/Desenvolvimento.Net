using System;

namespace _007_aula
{
    class Calculadora
    {

        private int num1;
        private int num2;
        private int proxNum;
        private int qtdNumeros = 2;

        public Calculadora()
        {

        }

        public int GetNum1()
        {
            return num1;
        }

        public void SetNum1(int value)
        {
            num1 = value;
        }

        public int GetNum2()
        {
            return num2;
        }

        public void SetNum2(int value)
        {
            num2 = value;
        }

        public int GetProxNum()
        {
            return proxNum;
        }

        public void SetProxNum(int value)
        {
            proxNum = value;
        }

        public int GetqtdNumeros()
        {
            return qtdNumeros;
        }
        public void SetqtdNumeros(int value)
        {
            qtdNumeros = value;
        }

        public double CalcularMedia()
        {
            int soma = GetNum1() + GetNum2() + GetProxNum();

            double media = (double)soma / GetqtdNumeros();


            //Console.WriteLine($"{soma}");
            //Console.WriteLine($"{media:F2}");
            return media;
        }


        public double CalcularDesvioPadrao()
        {
            int n1 = GetNum1();
            int n2 = GetNum2();
            int proxNum = GetProxNum();
            int qtdNumeros = GetqtdNumeros();

            double media = (double)(n1 + n2 + proxNum) / qtdNumeros;
            double somaDesviosQuadrados = Math.Pow(n1 - media, 2) + Math.Pow(n2 - media, 2) + Math.Pow(proxNum - media, 2);
            double desvioPadrao = Math.Sqrt(somaDesviosQuadrados / qtdNumeros);

            return desvioPadrao;
        }

        public override string ToString()
        {
            return $"Média: {CalcularMedia():F2}\nDesvio: {CalcularDesvioPadrao():F2}";
        }

    }
}