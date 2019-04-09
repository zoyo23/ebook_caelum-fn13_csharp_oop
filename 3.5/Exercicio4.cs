using System;

namespace _3._5
{
    public class Exercicio4
    {
        //4. (Opcional) No colegial, aprendemos a resolver equações de segundo grau usando a fórmula de
        //Bhaskara.A fórmula é assim:
        //delta = b * b - 4 * a * c;
        //a1 = (-b + raiz(delta)) / (2 * a);
        //a2 = (-b - raiz(delta)) / (2 * a);
        //Crie um programa com três variáveis inteiras, a, b, c , com quaisquer valores.Depois crie 3
        //variáveis double, delta, a1, a2 , com a fórmula anterior.
        //Imprima a1 e a2 em um MessageBox.
        //Dica: Para calcular raiz quadrada, use Math.Sqrt(variavel) . Não se esqueça que não podemos
        //calcular a raiz quadrada de números negativos.

        public static void Executar(int Valor1, int Valor2, int Valor3) => CalculaBhaskara(Valor1, Valor2, Valor3);
        static string tituloJanela = "Capítulo 3 - Exercicio 4 - Resultado dos calculos";

        private static void CalculaBhaskara(int Valor1, int Valor2, int Valor3)
        {
            double delta, a1, a2;
            delta = CalculaDelta(Valor1, Valor2, Valor3);
            a1 = (-Valor2 + Math.Sqrt(delta)) / (2 * Valor1);
            a2 = (-Valor2 - Math.Sqrt(delta)) / (2 * Valor1);

            Util.MessageBoxUtil.ExibirMessageBox($"Resultado: \n" +
                            $"a1: {a1} \n" +
                            $"a2: {a2}", tituloJanela);
        }

        private static double CalculaDelta(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

    }
}