namespace _6._7
{
    public class Exercicio3
    {
        //3. Qual dos comandos a seguir instancia uma nova Conta?
        //Conta conta = Conta();
        //Conta conta = new Conta();
        //Conta conta = Conta.new();

        public static void Executar() => VerificaRespostaCorreta();
        static string tituloJanela = "Capítulo 6 - Exercicio 3 - Criação de classe";
        private static void VerificaRespostaCorreta()
        {
            var mensagem = @"Qual dos comandos a seguir instancia uma nova Conta?
        
        Conta conta = Conta();
        ** Conta conta = new Conta(); **
        Conta conta = Conta.new();";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}