namespace _4._3_Opcional
{
    public class Exercicio3
    {
        //3. Em alguns casos, podemos ter mais de duas decisões possíveis.O banco pode, por exemplo, decidir
        //que contas com saldo menor que R$ 1000 pagam 1% de taxa de manutenção, contas com saldo entre
        //R$ 1000 e R$ 5000 pagam 5% e contas com saldo maior que R$ 5000 pagam 10%.
        //Para representar esse tipo de situação, podemos usar o else if do C#, que funciona em conjunto
        //com o if que já conhecemos.Veja como ficaria a situação descrita anteriormente:
        //double taxa;
        //if (saldo< 1000)
        //{
        //taxa = 0.01;
        //}
        //else if (saldo <= 5000)
        //{
        //taxa = 0.05;
        //}
        //else
        //{
        //taxa = 0.1;
        //}
        //O C# vai processar as condições na ordem, até encontrar uma que seja satisfeita. Ou seja, na segunda
        //condição do código, só precisamos verificar que saldo é menor ou igual a R$ 5000, pois se o C#
        //chegar nessa condição é porque ele não entrou no primeiro if , isto é, sabemos que o saldo é
        //maior ou igual a R$ 1000 nesse ponto.
        //Com base nisso, qual vai ser a mensagem exibida pelo código seguinte?
        //double saldo = 500.0;
        //if (saldo< 0.0)
        //{
        //MessageBox.Show("Você está no negativo!");
        //}
        //else if (saldo< 1000000.0)
        //{
        //MessageBox.Show("Você é um bom cliente");
        //}
        //else
        //{
        //MessageBox.Show("Você é milionário!");
        //}
        //"Você está no negativo!"
        //* "Você é um bom cliente" *
        //Nenhuma mensagem
        //"Você é milionário!"
        //"Você é um bom cliente", seguida de "Você é milionário!"

        public static void Executar() => VerificaStatusCliente();
        static string tituloJanela = "Capítulo 4 - Exercicio Opcional 3 - Verifica Status Cliente";

        private static void VerificaStatusCliente()
        {
            double saldo = 500.0;
            if (saldo < 0.0)
            {
                Util.MessageBoxUtil.ExibirMessageBox("Você está no negativo!", tituloJanela);
            }
            else if (saldo < 1000000.0)
            {
                Util.MessageBoxUtil.ExibirMessageBox("Você é um bom cliente", tituloJanela);
            }
            else
            {
                Util.MessageBoxUtil.ExibirMessageBox("Você é milionário!", tituloJanela);
            }
        }
    }
}
