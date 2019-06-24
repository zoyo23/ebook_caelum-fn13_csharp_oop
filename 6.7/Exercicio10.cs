using System.Windows.Forms;

namespace _6._7
{
    public class Exercicio10
    {
        //10. Qual a saída do código a seguir:
        //Conta mauricio = new Conta();
        //mauricio.saldo = 2000.0;
        //Conta copia = mauricio;
        //copia.saldo = 3000.0;
        //MessageBox.show("mauricio = " + mauricio.saldo);
        //MessageBox.show("copia = " + copia.saldo);
        //mauricio = 2000.0 e copia = 3000.0
        //mauricio = 3000.0 e copia = 2000.0
        //mauricio = 2000.0 e copia = 2000.0
        //** mauricio = 3000.0 e copia = 3000.0 **

        public static void Executar() => ExecutaTrechoDeCodigo();
        static string tituloJanela = "Capítulo 6 - Exercicio 10 - Copia de Conta";

        private static void ExecutaTrechoDeCodigo()
        {
            Conta mauricio = new Conta();
            mauricio.Saldo = 2000.0;
            Conta copia = mauricio;
            copia.Saldo = 3000.0;
            MessageBox.Show("mauricio = " + mauricio.Saldo);
            MessageBox.Show("copia = " + copia.Saldo);

            VerificaRespostaCorreta();
        }

        private static void VerificaRespostaCorreta()
        {
            var mensagem = @"
                Qual a saída do código a seguir:
                Conta mauricio = new Conta();
                mauricio.saldo = 2000.0;
                Conta copia = mauricio;
                copia.saldo = 3000.0;
                MessageBox.show('mauricio = ' + mauricio.saldo);
                MessageBox.show('copia = ' + copia.saldo);

                mauricio = 2000.0 e copia = 3000.0
                mauricio = 3000.0 e copia = 2000.0
                mauricio = 2000.0 e copia = 2000.0
                ** mauricio = 3000.0 e copia = 3000.0 **";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}


