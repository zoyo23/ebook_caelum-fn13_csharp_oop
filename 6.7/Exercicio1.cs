namespace _6._7
{
    public class Exercicio1
    {
        //1. O que uma classe tem?
        //Só os atributos de uma entidade do sistema;
        //Só atributos ou só métodos de uma entidade do sistema;
        //Só os métodos de uma entidade do sistema;
        //Atributos e métodos de uma entidade do sistema.

        public static void Executar() => VerificaRespostaCorreta();
        static string tituloJanela = "Capítulo 6 - Exercicio 1 - O que uma classe tem?";
        private static void VerificaRespostaCorreta()
        {
            var mensagem = @"
        O que uma classe tem? 

        Só os atributos de uma entidade do sistema; 
        Só atributos ou só métodos de uma entidade do sistema; 
        Só os métodos de uma entidade do sistema; 
        ** Atributos e métodos de uma entidade do sistema. **";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}


