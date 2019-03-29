﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace _4._3
{
    public class Exercicio5
    {
        //5. (Opcional) Escreva um programa em C# que imprime todos os números que são divisíveis por 3 ou
        //por 4 entre 0 e 30.

        public static void Executar() => ImprimeDivisiveisPor3();

        private static void ImprimeDivisiveisPor3()
        {
            var listaDivisiveis = new List<int>();
            for (var contador = 0; contador <= 30; contador++)
            {
                if (contador % 3 == 0 || contador % 4 == 0)
                {
                    listaDivisiveis.Add(contador);
                }
            }
            MessageBox.Show($"{string.Join(", ", listaDivisiveis)}", "Capítulo 4 - Exercicio 5 - Lista Números Divisíveis por 3 e 4");
        }
    }
}