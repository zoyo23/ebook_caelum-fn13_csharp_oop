using System.Windows.Forms;

namespace _4._3
{
    public class Exercicio1
    {
        //1. Qual é o valor exibido no seguinte código:
        //int total = 2;
        //for (int i = 0; i< 5; i += 1)
        //{
        //total = total* 2;
        //}
        //MessageBox.Show("O total é: " + total);
        //256
        //** 64 **
        //128
        //512

        public static void Executar() => VerificaLacoRepeticao();

        private static void VerificaLacoRepeticao()
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show($"O total é: {total}", "Capítulo 4 - Exercicio 1 - Resultado Multiplicação Laço For");
        }
    }
}


