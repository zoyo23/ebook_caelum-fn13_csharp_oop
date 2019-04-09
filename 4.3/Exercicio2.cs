namespace _4._3
{
    public class Exercicio2
    {
        //2. Faça um programa em C# que imprima a soma dos números de 1 até 1000.

        public static void Executar() => ImprimirSomaAteMil();
        static string tituloJanela = "Capítulo 4 - Exercicio 2 - Números até 1000";


        private static void ImprimirSomaAteMil()
        {
            var resutadoSoma = 0;
            for (var contador = 1; contador <= 1000; contador++)
            {
                resutadoSoma += contador;
            }
            Util.MessageBoxUtil.ExibirMessageBox($"Resultado: {resutadoSoma}", tituloJanela);
        }
    }
}
