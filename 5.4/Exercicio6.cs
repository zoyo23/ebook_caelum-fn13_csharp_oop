namespace _5._4
{
    public class Exercicio6
    {
        //6. (Opcional) Faça um programa em C# que imprima os fatoriais de 1 a 10.
        //O fatorial de um número n é n n-1 n-2 ... até n = 1.
        //O fatorial de 0 é 1
        //O fatorial de 1 é(0!) * 1 = 1
        //O fatorial de 2 é(1!) * 2 = 2
        //O fatorial de 3 é(2!) * 3 = 6
        //O fatorial de 4 é(3!) * 4 = 24
        //Faça um for que inicie uma variável n(número) como 1 e fatorial(resultado) como 1 e varia n de 1
        //até 10:
        //int fatorial = 1;
        //for (int n = 1; n <= 10; n++)
        //{
        //}

        public static void Executar() => ExecutaExercicio();
        static string tituloJanela = "Capítulo 5 - Exercicio 6 - Calculo Fatorial";

        private static void ExecutaExercicio()
        {
            var mensagem = string.Empty;
            for (int numeroParaCalculoFatorial = 1; numeroParaCalculoFatorial <= 10; numeroParaCalculoFatorial++)
            {
                var resultadoCalculoFatorial = CalculaFatorial(numeroParaCalculoFatorial);
                mensagem = string.Concat(mensagem, $"O fatorial de {numeroParaCalculoFatorial} é ({numeroParaCalculoFatorial - 1}!)*{numeroParaCalculoFatorial} = {resultadoCalculoFatorial}\n");
            }

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }

        //TODO: Efetuar a implementação de método recursivo
        private static int CalculaFatorial(int numeroParaCalculo)
        {
            var resultadoCalculoFatorial = 1;

            if (numeroParaCalculo == 0)
            {
                resultadoCalculoFatorial = 1;
                return resultadoCalculoFatorial;
            }

            for (var contadorAuxilar = numeroParaCalculo; contadorAuxilar >= 1; contadorAuxilar--)
            {
                resultadoCalculoFatorial *= contadorAuxilar;
            }

            return resultadoCalculoFatorial;
        }
    }
}
