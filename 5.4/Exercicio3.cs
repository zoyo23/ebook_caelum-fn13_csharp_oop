using System.Collections.Generic;

namespace _5._4
{
    public class Exercicio3
    {
        //3. Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
        //Para saber se um número é múltiplo de 3, você pode fazer if(numero % 3 == 0) .

        public static void Executar() => ImprimirMultiplosDe3();
        static string tituloJanela = "Capítulo 5 - Exercicio 3 - Múltiplos de 3 de 1 a 100";

        private static void ImprimirMultiplosDe3()
        {
            var listaMultiplosDe3 = new List<int>();
            for (var contador = 1; contador <= 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    listaMultiplosDe3.Add(contador);
                }
            }
            Util.MessageBoxUtil.ExibirMessageBox($"{string.Join(", ", listaMultiplosDe3)}", tituloJanela);
        }
    }
}


