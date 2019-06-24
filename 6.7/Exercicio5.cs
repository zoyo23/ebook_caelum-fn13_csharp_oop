namespace _6._7
{
    public class Exercicio5
    {
        //5. Agora vamos testar a classe Conta que acabamos de criar.Coloque um novo botão no formulário
        //da aplicação.Dê um duplo clique nesse botão para definirmos qual será o código executado no clique
        //do botão.
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // ação do botão aqui.
        //}
        //Dentro do código desse botão, instancie uma nova Conta e tente fazer alguns testes preenchendo e
        //mostrando seus atributos através do MessageBox.Show.Por exemplo:
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Conta contaVictor = new Conta();
        //    contaVictor.titular = "victor";
        //    contaVictor.numero = 1;
        //    contaVictor.saldo = 100.0;
        //    MessageBox.Show(contaVictor.titular);
        //}
        //Tente fazer testes com diversas contas e veja que cada instância de conta possui seus próprios
        //atributos.

        public static void Executar() => VerificaExecucao();
        static string tituloJanela = "Capítulo 6 - Exercicio 5 - Testes de Impementação da classe";

        private static void VerificaExecucao()
        {
            var mensagem = @"Nada para implementar até aqui.";
            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}