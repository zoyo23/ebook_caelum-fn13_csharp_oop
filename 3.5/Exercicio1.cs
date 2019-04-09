using System.Collections.Generic;
using System.Linq;

namespace _3._5
{
    public class Exercicio1
    {
        //1. Crie 3 variáveis com as idades dos seus melhores amigos e/ou familiares.Algo como:
        //int idadeJoao = 10;
        //int idadeMaria = 25;
        //Em seguida, pegue essas 3 idades e calcule a média delas.Exiba o resultado em um MessageBox.

        public static void Executar(IEnumerable<int> idades) => CalcularMediaDeIdades(idades);
        static string tituloJanela = "Capítulo 3 - Exercicio 1 - Calculo das médias";
        private static void CalcularMediaDeIdades(IEnumerable<int> idades)
        {
            Util.MessageBoxUtil.ExibirMessageBox($"Média das idades: {idades.Average(idade => idade)}", tituloJanela);
        }
    }
}
