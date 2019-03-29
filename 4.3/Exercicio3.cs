using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _4._3
{
    public class Exercicio3
    {
        //3. Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
        //Para saber se um número é múltiplo de 3, você pode fazer if(numero % 3 == 0) .

        public static void Executar() => ImprimirMultiplosDe3();

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
            MessageBox.Show($"{string.Join(", ",listaMultiplosDe3)}", "Capítulo 4 - Exercicio 3 - Múltiplos de 3 de 1 a 100");
        }
    }
}


