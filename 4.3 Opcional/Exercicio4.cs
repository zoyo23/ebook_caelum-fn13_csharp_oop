namespace _4._3_Opcional
{
    public class Exercicio4
    {
        //4. Uma pessoa só pode votar em eleições brasileiras se ela for maior que 16 anos e for cidadã brasileira.
        //Crie um programa com duas variáveis, int idade, bool brasileira, e faça com que o programa
        //diga se a pessoa está apta a votar ou não, de acordo com os dados nas variáveis.

        public static void Executar() => PodeVotar();
        static string tituloJanela = "Capítulo 4 - Exercicio Opcional 4 - Verifica Possibilidade de Voto";

        private static void PodeVotar()
        {
            int idade = 21;
            bool brasileira = true;

            if (VerificaPossibilidadeDeVoto(idade, brasileira))
            {
                Util.MessageBoxUtil.ExibirMessageBox("Pode Votar!", tituloJanela);
            }
            else
            {
                Util.MessageBoxUtil.ExibirMessageBox("Não Pode Votar!", tituloJanela);
            }
        }

        private static bool VerificaPossibilidadeDeVoto(int idade, bool brasileira)
        {
            return idade > 16 && brasileira;
        }
    }
}
