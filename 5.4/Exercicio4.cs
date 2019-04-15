namespace _5._4
{
    public class Exercicio4
    {
        //4. (Opcional) Escreva um programa em C# que some todos os números de 1 a 100, pulando os
        //múltiplos de 3. O programa deve imprimir o resultado final em um MessageBox.
        //Qual o resultado?

        public static void Executar() => CalculaSomaNumerosNaoMultiplosDe3();
        static string tituloJanela = "Capítulo 5 - Exercicio 4 - Calcular Soma dos Não Multiplos de 3";

        private static void CalculaSomaNumerosNaoMultiplosDe3()
        {
            var resultadoSomaNaoMultiplos = 0;
            for (var contador = 1; contador <= 100; contador++)
            {
                if (contador % 3 != 0)
                {
                    resultadoSomaNaoMultiplos = +contador;
                }
            }
            Util.MessageBoxUtil.ExibirMessageBox($"Resultado: {resultadoSomaNaoMultiplos}", tituloJanela);
        }
    }
}
