using System;
namespace Calculadora
{
    public class Calculadora
    {

        public Operacoes Calcular(Operacoes operacao)
        {
            switch (operacao.operador)
            {
                case '+': operacao.resultado = Soma(operacao); break;
                case '-': operacao.resultado = Subtracao(operacao); break;
                case '*': operacao.resultado = Multiplicacao(operacao); break;
                case '/': operacao.resultado = Divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public long Soma(Operacoes operacao)
        {
            return (long)Convert.ToDouble(operacao.valorA) + (long)Convert.ToDouble(operacao.valorB);
        }
        public int Subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public int Multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public int Divisao(Operacoes operacao)
        {
            if (operacao.valorB == 0)
            {
                throw new Exception("Erro: Divisão por zero não é permitida. Resultado: Indefinido");
            }
            else
            {
                return operacao.valorA / operacao.valorB;
            }
        }
    }
}
