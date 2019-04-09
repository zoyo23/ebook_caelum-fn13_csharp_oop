namespace _3._5
{
    public class Exercicio3
    {
        //3. Execute o trecho de código a seguir.O que acontece com ele?
        //double pi = 3.14;
        //int piQuebrado = (int)pi;
        //MessageBox.Show("piQuebrado = " + piQuebrado);
        //Repare o(int) . Estamos "forçando" a conversão do double para um inteiro.
        //Qual o valor de piQuebrado nesse caso?
        //3.14
        //0
        //** 3 **

        public static void Executar() => ConvertePiEmNumeroInteiro();
        static string tituloJanela = "Capítulo 3 - Exercicio 3 - Valor de pi Inteiro";
        private static void ConvertePiEmNumeroInteiro()
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            Util.MessageBoxUtil.ExibirMessageBox($"piQuebrado = {piQuebrado}", tituloJanela);
        }
    }
}
