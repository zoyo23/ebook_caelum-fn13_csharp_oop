using System.Windows.Forms;

namespace _2._7
{
    public class Exercicio1
    {
        //1. Qual a mensagem que será exibida na caixa de texto criada pelo seguinte código?
        //MessageBox.Show("Curso de C# da Caelum");
        //Hello World
        //Curso de C# da Caelum
        //Olá Mundo
        //Caelum
        //Nenhuma das opções
        public static void Executar() => ShowMessageBox();

        private static void ShowMessageBox()
        {
            MessageBox.Show("Curso de c# da Caelum", "Capítulo 2 - Exercicio 1 - Primeiro Exercício");
        }

    }
}
