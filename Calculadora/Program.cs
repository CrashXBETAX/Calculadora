using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();
            Imprime imprimePendentes = new Imprime(filaOperacoes);
            // Optei por usar foreach em vez de while porque acredito que programar um código mais claro e legível é importante, seguindo o princípio Clean Code da "Clareza". Além disso, o foreach raramente causa loops infinitos, ao contrário do while, que é mais propenso a erros.
            foreach (Operacoes operacao in filaOperacoes)
            {
                imprimePendentes.ImprimePendentes();
                calculadora.Calcular(operacao);
                Imprime.ImprimeResultado(operacao);
            }
            Imprime.RetireStack();
        }
    }
}
