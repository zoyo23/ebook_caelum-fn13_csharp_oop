using System.Windows.Forms;

namespace _6._7
{
    public class Exercicio9
    {
        //9. Qual a saída do código a seguir?
        //Conta mauricio = new Conta();
        //mauricio.numero = 1;
        //mauricio.titular = "Mauricio";
        //mauricio.saldo = 100.0;
        //Conta mauricio2 = new Conta();
        //mauricio2.numero = 1;
        //mauricio2.titular = "Mauricio";
        //mauricio2.saldo = 100.0;
        //if (mauricio == mauricio2)
        //{
        //MessageBox.Show("As contas são iguais");
        //}
        //else
        //{
        //MessageBox.Show("As contas são diferentes");
        //}
        //As contas são iguais
        //** As contas são diferentes **
        //Não é mostrado nenhuma mensagem
        public static void Executar() => ExecutaTrechoDeCodigo();
        static string tituloJanela = "Capítulo 6 - Exercicio 9 - Teste de Saída";

        private static void ExecutaTrechoDeCodigo()
        {
            Conta mauricio = new Conta();
            mauricio.Numero = 1;
            mauricio.Titular = "Mauricio";
            mauricio.Saldo = 100.0;
            Conta mauricio2 = new Conta();
            mauricio2.Numero = 1;
            mauricio2.Titular = "Mauricio";
            mauricio2.Saldo = 100.0;
            if (mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }

            VerificaRespostaCorreta();
        }

        private static void VerificaRespostaCorreta()
        {
            var mensagem = @"Qual a saída do código a seguir?

            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = 'Mauricio';
            mauricio.saldo = 100.0;
            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular = 'Mauricio';
            mauricio2.saldo = 100.0;
            if (mauricio == mauricio2)
            {
                MessageBox.Show('As contas são iguais');
            }
            else
            {
                MessageBox.Show('As contas são diferentes');
            }

            As contas são iguais
            ** As contas são diferentes **
            Não é mostrado nenhuma mensagem";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }

    }
}


