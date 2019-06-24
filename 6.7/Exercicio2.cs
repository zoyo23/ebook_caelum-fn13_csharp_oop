namespace _6._7
{
    public class Exercicio2
    {
        //2. Vamos criar a classe Conta dentro do projeto inicial utilizando o Visual Studio.
        //No Visual Studio clique com o botão direito no nome do projeto e selecione a opção Add >
        //Class...
        //Dentro da janela aberta pelo Visual Studio, precisamos definir qual é o nome da classe que queremos
        //criar.Escolha o nome Conta :
        //Depois de colocar o nome da classe, clique no botão Add.Com isso, o Visual Studio criará um novo
        //arquivo dentro do Projeto, o Conta.cs.Todo o código da classe Conta ficará dentro desse
        //arquivo:
        //class Conta
        //{
        //    // O código da classe fica aqui dentro!
        //}
        //Agora declare os seguintes atributos dentro da Conta : saldo(double), titular(string) e
        //numero(int).

        public static void Executar() => ExibeEstruturaDaClasse();
        static string tituloJanela = "Capítulo 6 - Exercicio 2 - Criação de classe e atributo";

        private static void ExibeEstruturaDaClasse()
        {
            var mensagem = @"
            class Conta
            {
                public double Saldo { get; set; }
                public string Titular { get; set; }
            }";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}