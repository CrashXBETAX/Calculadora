using System;
using System.Collections.Generic;

namespace Calculadora
{
    internal class Imprime
    {
        private Queue<Operacoes> filaOperacao;
        private static Stack<long> stackResultados = new Stack<long>();
        public Imprime(Queue<Operacoes> fila)
        {
            filaOperacao = new Queue<Operacoes>(fila);
        }
        public void ImprimePendentes() {
            Console.WriteLine(Environment.NewLine +"Operações Pendentes:");
            foreach (Operacoes operacao in filaOperacao)
            {
                Console.WriteLine(" # {0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
            }
            filaOperacao.Dequeue();
        }
        public static void ImprimeResultado(Operacoes operacao){
            Console.WriteLine(Environment.NewLine + "Calculando...");
            Console.WriteLine("  {0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
            Console.WriteLine("Empurrando um elemento {0} na Stack", operacao.resultado);
            EmpurreStack(operacao.resultado);
        }
        public static void EmpurreStack(long resultado)
        {
            stackResultados.Push(resultado);
        }
        public static void RetireStack() {
            foreach (var resultado in stackResultados)
            {
                Console.WriteLine(Environment.NewLine + "Retirando um elemento da Stack:");
                Console.WriteLine(resultado);
            }
        }

    }
}
