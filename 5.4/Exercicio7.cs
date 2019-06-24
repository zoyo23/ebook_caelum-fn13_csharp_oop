namespace _5._4
{
    public class Exercicio7
    {
        //7. (Opcional) Faça um programa em C# que imprima os primeiros números da série de Fibonacci até
        //passar de 100. A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3, 5, 8, 13, 21 etc...Para calculá-la, o
        //primeiro elemento vale 0, o segundo vale 1, daí por diante, o n-ésimo elemento vale o(n-1)-ésimo
        //elemento somado ao(n-2)-ésimo elemento(ex: 8 = 5 + 3).

        //TODO: Efetuar a implementação do exercício 7 do Capítulo 5
        public static void Executar() => ImprimeSequenciaFibonacci();
        static string tituloJanela = "Capítulo 5 - Exercicio 7 - Série de Fibonacci";

        private static void ImprimeSequenciaFibonacci()
        {
            var mensagem = string.Empty;
            var numeroAnterior = 0;
            var numeroSeguinte = 1;
            var auxiliar = 0;

            mensagem = string.Concat(mensagem, $"{numeroAnterior} ");
            mensagem = string.Concat(mensagem, $"{numeroSeguinte} ");

            do
            {
                auxiliar = numeroSeguinte + numeroAnterior;
                numeroAnterior = numeroSeguinte;
                numeroSeguinte = auxiliar;
                mensagem = string.Concat(mensagem, $"{auxiliar} ");
            } while (auxiliar < 100);

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}
