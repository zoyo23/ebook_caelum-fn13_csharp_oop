namespace _6._7
{
    public class Exercicio6
    {
        //6. Agora vamos implementar métodos na classe Conta.Começaremos pelo método Deposita, esse
        //método não devolve nada e deve receber um argumento do tipo double que é o valor que será
        //depositado na Conta.A sua classe deve ficar parecida com a que segue:
        //// dentro do arquivo Conta.cs
        //class Conta
        //{
        //    // declaração dos atributos
        //    public void Deposita(double valor)
        //    {
        //        // o que colocar aqui na implementação?
        //    }
        //}
        //Depois de implementar o método Deposita, implemente também o método Saca.Ele também
        //não devolve valor algum e recebe um double que é o valor que será sacado da conta.

        public static void Executar() => VerificaExecucao();
        static string tituloJanela = "Capítulo 6 - Exercicio 6 - Testes de Impementação da classe";

        private static void VerificaExecucao()
        {
            var mensagem = @"Nada para implementar até aqui.";
            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
    public partial class Conta
    {
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}


