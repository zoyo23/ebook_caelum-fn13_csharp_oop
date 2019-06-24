using System;

namespace _6._7
{
    public class Exercicio4
    {
        //4. Levando em consideração o código:
        //Conta c = new Conta();
        //c.saldo = 1000.0;
        //Qual das linhas a seguir adiciona 200 reais nesse saldo?
        //saldo += 200;
        //c.saldo += 200;
        //Conta c.saldo += 200;
        //Conta.saldo += 200;

        public static void Executar() => VerificaRespostaCorreta();
        static string tituloJanela = "Capítulo 6 - Exercicio 4 - Como adicionar Saldo?";
        private static void VerificaRespostaCorreta()
        {
            var mensagem = @"
            Levando em consideração o código:
            Conta c = new Conta();
            c.saldo = 1000.0;
            Qual das linhas a seguir adiciona 200 reais nesse saldo?

            saldo += 200;
            ** c.saldo += 200; **
            Conta c.saldo += 200;
            Conta.saldo += 200;";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}