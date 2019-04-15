namespace _5._4
{
    public class Exercicio8
    {
        //8. (Opcional) Faça um programa que imprima a seguinte tabela, usando for s encadeados:
        //1
        //2 4
        //3 6 9
        //4 8 12 16
        //n n*2 n*3 .... n* n

        public static void Executar() => ImprimeComForEncadeado();
        static string tituloJanela = "Capítulo 5 - Exercicio 8 - For Encadeado";


        private static void ImprimeComForEncadeado()
        {
            var tamanhoDaTabela = 10;
            var mensagem = string.Empty;

            for (int contadorLinhas = 1; contadorLinhas <= tamanhoDaTabela; contadorLinhas++)
            {
                mensagem = string.Concat(mensagem, $"{contadorLinhas}   ");
                for (int contadorColunas = 1; contadorColunas < contadorLinhas; contadorColunas++)
                {
                    mensagem = string.Concat(mensagem, $"{contadorLinhas + (contadorLinhas * contadorColunas)}   ");
                }

                mensagem = string.Concat(mensagem, $"\n");
            }

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}
