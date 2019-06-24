namespace _4._3_Opcional
{
    public class Exercicio2
    {
        //2. Qual é a mensagem e o valor da variável saldo após a execução do seguinte código?
        //double saldo = 5.0;
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
        //mensagem: Saque realizado com sucesso; saldo: -5.0
        //mensagem: Saldo Insuficiente; saldo -5.0
        //mensagem: Saque realizado com sucesso; saldo: 5.0
        //* mensagem: Saldo Insuficiente; saldo 5.0 *
        //mensagem: Saque realizado com sucesso; saldo: 10.0


        public static void Executar() => TentativaDeSaque();
        static string tituloJanela = "Capítulo 4 - Exercicio Opcional 2 - Verifica Possibilidade de Saque";
        private static void TentativaDeSaque()
        {
            double saldo = 5.0;
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
            informarRespostaCorreta();
        }

        private static void informarRespostaCorreta()
        {
            var mensagem = @"Qual é a mensagem e o valor da variável saldo após a execução do seguinte código?
            double saldo = 5.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show('Saque realizado com sucesso');
            }
            else
            {
                MessageBox.Show('Saldo Insuficiente');
            }

            mensagem: Saque realizado com sucesso; saldo: -5.0
            mensagem: Saldo Insuficiente; saldo -5.0
            mensagem: Saque realizado com sucesso; saldo: 5.0
            ** mensagem: Saldo Insuficiente; saldo 5.0 **
            mensagem: Saque realizado com sucesso; saldo: 10.0";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }

    }
}
