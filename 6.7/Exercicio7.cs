namespace _6._7
{
    public class Exercicio7
    {
        //7. Agora vamos testar os métodos que acabamos de criar.Na ação do botão que utilizamos para testar a
        //conta, vamos manipular o saldo utilizando os métodos Deposita e Saca :
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Conta contaVictor = new Conta();
        //    contaVictor.titular = "victor";
        //    contaVictor.numero = 1;
        //    contaVictor.Deposita(100);
        //    MessageBox.Show("Saldo: " + contaVictor.saldo);
        //    contaVictor.Saca(50.0);
        //    MessageBox.Show("Saldo: " + contaVictor.saldo);
        //}
        //Tente fazer depósitos e saques em várias instâncias diferentes de Conta , repare que dentro dos
        //métodos a variável this possui o valor da referência em que o método foi invocado.

        public static void Executar() => VerificaExecucao();
        static string tituloJanela = "Capítulo 6 - Exercicio 7 - Testes de Impementação da classe";

        private static void VerificaExecucao()
        {
            var mensagem = @"Nada para implementar até aqui.";
            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}


