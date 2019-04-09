namespace _4._3_Opcional
{
    public class Exercicio5
    {
        //5. Crie um programa que tenha uma variável double valorDaNotaFiscal e, de acordo com esse
        //valor, o imposto deve ser calculado.As regras de cálculo são:
        //Se o valor for menor ou igual a 999, o imposto deve ser de 2%
        //Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5%
        //Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8%
        //Se for maior ou igual a 7000, o imposto deve ser de 3%
        //Imprima o imposto em um MessageBox.

        public static void Executar() => VerificaValorNotaFiscal();
        static string tituloJanela = "Capítulo 4 - Exercicio Opcional 5 - Verifica Possibilidade de Voto";

        private static void VerificaValorNotaFiscal()
        {
            double valorDaNotaFiscal = 50000.0;
            Util.MessageBoxUtil.ExibirMessageBox($"Valor do Imposto: {RetornaValorImposto(valorDaNotaFiscal)}%", tituloJanela);
        }

        private static double RetornaValorImposto(double valorNotaFiscal)
        {
            double valorImposto = 0;

            if (valorNotaFiscal <= 999)
            {
                valorImposto = 2;
            }
            else if (valorNotaFiscal >= 1000 && valorNotaFiscal <= 2999)
            {
                valorImposto = 2.5;
            }
            else if (valorNotaFiscal >= 3000 && valorNotaFiscal <= 6999)
            {
                valorImposto = 2.8;
            }
            else if (valorNotaFiscal >= 7000)
            {
                valorImposto = 3;
            }

            return valorImposto;
        }
    }
}
