using System.Windows.Forms;

namespace _6._7
{
    public class Exercicio8
    {
        //8. Qual a saída do código a seguir:
        //Conta mauricio = new Conta();
        //mauricio.saldo = 2000.0;
        //Conta guilherme = new Conta();
        //guilherme.saldo = 5000.0;
        //mauricio.saldo -= 200.0;
        //guilherme.saldo += 200.0;
        //MessageBox.Show("mauricio = " + mauricio.saldo);
        //MessageBox.Show("guilherme = " + guilherme.saldo);
        //mauricio = 2200.0 e guilherme = 4800.0
        //mauricio = 2200.0 e guilherme = 5200.0
        //mauricio = 1800.0 e guilherme = 5000.0
        //** mauricio = 1800.0 e guilherme = 5200.0 **

        public static void Executar() => ExecutaTrechoDeCodigo();
        static string tituloJanela = "Capítulo 6 - Exercicio 8 - Teste de Saída";

        private static void ExecutaTrechoDeCodigo()
        {
            Conta mauricio = new Conta();
            mauricio.Saldo = 2000.0;
            Conta guilherme = new Conta();
            guilherme.Saldo = 5000.0;
            mauricio.Saldo -= 200.0;
            guilherme.Saldo += 200.0;
            MessageBox.Show("mauricio = " + mauricio.Saldo);
            MessageBox.Show("guilherme = " + guilherme.Saldo);

            VerificaRespostaCorreta();
        }

        private static void VerificaRespostaCorreta()
        {
            var mensagem = @"
                Qual a saída do código a seguir:
                Conta mauricio = new Conta();
                mauricio.saldo = 2000.0;
                Conta guilherme = new Conta();
                guilherme.saldo = 5000.0;
                mauricio.saldo -= 200.0;
                guilherme.saldo += 200.0;
                MessageBox.Show('mauricio = ' + mauricio.saldo);
                MessageBox.Show('guilherme = ' + guilherme.saldo);
                mauricio = 2200.0 e guilherme = 4800.0
                mauricio = 2200.0 e guilherme = 5200.0
                mauricio = 1800.0 e guilherme = 5000.0
                ** mauricio = 1800.0 e guilherme = 5200.0 **";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }

    }
}