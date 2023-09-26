using System;

namespace _008_aula
{
    class Calculadora
    {

        private int num1;
        private int num2;
        private string operacao;

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

        public string GetOperacao()
        {
            return operacao;
        }
        public void SetOperacao(string op)
        {
            operacao = op;
        }

        public string Calcular()
        {

            int resultado = 0;
            string msg = "";

            try
            {
                if (string.IsNullOrWhiteSpace(operacao))
                {
                    throw new ArgumentException("Operação não pode estar vazia");
                }

                switch (operacao)
                {
                    case "+":
                        resultado = GetNum1() + GetNum2();
                        msg = $"{GetNum1()} + {GetNum2()} = {resultado}";
                        break;

                    case "-":
                        resultado = GetNum1() - GetNum2();
                        msg = $"{GetNum1()} - {GetNum2()} = {resultado}";
                        break;

                    case "*":
                        resultado = GetNum1() * GetNum2();
                        msg = $"{GetNum1()} * {GetNum2()} = {resultado}";
                        break;

                    case "/":
                        if (GetNum2() != 0)
                        {
                            resultado = GetNum1() / GetNum2();
                            msg = $"{GetNum1()} / {GetNum2()} = {resultado}";
                        }
                        else
                        {
                            msg = "Erro: Divisão por zero não permitida.";
                        }
                        break;
                    default:
                        throw new ArgumentException("Operação inválida");

                }

                return msg;

            }
            catch (ArgumentNullException ex)
            {
                return $"Erro: {ex.ParamName} não pode ser nulo.";

            }
            catch (ArgumentException ex)
            {
                return $"Erro: {ex.Message}";

            }
            catch (Exception ex)
            {
                return $"Erro: {ex.Message}";
            }
        }


    }
}