using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _3._5
{
    public class Exercicio1
    {
        //1. Crie 3 variáveis com as idades dos seus melhores amigos e/ou familiares.Algo como:
        //int idadeJoao = 10;
        //int idadeMaria = 25;
        //Em seguida, pegue essas 3 idades e calcule a média delas.Exiba o resultado em um MessageBox.

        public static void Executar(IEnumerable<int> idades) => CalcularMediaDeIdades(idades);

        private static void CalcularMediaDeIdades(IEnumerable<int> idades)
        {
            MessageBox.Show($"Média das idades: {idades.Average(idade => idade)}", "Capítulo 3 - Exercicio 1 - Calculo das médias");
        }


    }
}
