namespace _4._3_Opcional
{
    public class Exercicio6
    {
        //6. (Desafio) Dado o seguinte código:
        //int valor = 15;
        //string mensagem = "";
        //if(valor > 10)
        //{
        //mensagem = "Maior que dez";
        //}
        //else
        //{
        //mensagem = "Menor que dez;
        //}
        //MessageBox.Show(mensagem);
        //Existe uma forma de fazer o if desse código uma linha só, sem usar a palavra if e else. Pesquise sobre
        //isso e tente fazer.

        public static void Executar() => VerificaSeEMaiorQueDez();
        static string tituloJanela = "Capítulo 4 - Exercicio Opcional 6 - Verifica Número maior que Dez";
        private static void VerificaSeEMaiorQueDez()
        {
            int valor = 9;
            string mensagem = (valor > 10) ? "Maior que dez" : "Menor que dez";
            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}
