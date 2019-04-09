using System.Windows.Forms;

namespace Util
{
    public class MessageBoxUtil
    {
        public static void ExibirMessageBox(string mensagem, string tituloJanela)
        {
            MessageBox.Show(mensagem, tituloJanela);
        }
    }
}
