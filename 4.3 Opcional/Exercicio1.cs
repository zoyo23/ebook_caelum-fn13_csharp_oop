namespace _4._3_Opcional
{
    public class Exercicio1
    {
        //1. Qual é a mensagem e o valor da variável saldo após a execução do seguinte código?
        //double saldo = 100.0;
        //double valorSaque = 10.0;
        //if (saldo >= valorSaque)
        //{
        //saldo -= valorSaque;
        //MessageBox.Show("Saque realizado com sucesso");
        //}
        //else
        //{
        //MessageBox.Show("Saldo Insuficiente");
        //}
        //* mensagem: Saque realizado com sucesso; saldo: 90.0 *
        //mensagem: Saldo Insuficiente; saldo 90.0
        //mensagem: Saque realizado com sucesso; saldo: 100.0
        //mensagem: Saldo Insuficiente; saldo 100.0
        //mensagem: Saque realizado com sucesso; saldo: 10.0

        public static void Executar() => TentativaDeSaque();

        static string tituloJanela = "Capítulo 4 - Exercicio Opcional 1 - Verifica Possibilidade de Saque";
        private static void TentativaDeSaque()
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                Util.MessageBoxUtil.ExibirMessageBox("Saque realizado com sucesso", tituloJanela);
            }
            else
            {
                Util.MessageBoxUtil.ExibirMessageBox("Saldo Insuficiente", tituloJanela);
            }
        }
    }
}

