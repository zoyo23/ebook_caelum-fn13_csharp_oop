using System;
using System.Windows.Forms;

namespace _4._3
{
    public class Exercicio4
    {
        //4. (Opcional) Escreva um programa em C# que some todos os números de 1 a 100, pulando os
        //múltiplos de 3. O programa deve imprimir o resultado final em um MessageBox.
        //Qual o resultado?

        public static void Executar() => CalculaSomaNumerosNaoMultiplosDe3();

        private static void CalculaSomaNumerosNaoMultiplosDe3()
        {
            var resultadoSomaNaoMultiplos = 0;
            for (var contador = 1; contador <= 100; contador ++)
            {
                if(contador % 3 != 0)
                {
                    resultadoSomaNaoMultiplos = +contador;
                }
            }
            MessageBox.Show($"Resultado: {resultadoSomaNaoMultiplos}", "Capítulo 4 - Exercicio 4 - Calcular Soma dos Não Multiplos de 3");
        }
    }
}
