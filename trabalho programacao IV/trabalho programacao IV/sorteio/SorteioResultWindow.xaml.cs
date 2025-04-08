using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class SorteioResultWindow : Window
    {
        public SorteioResultWindow(int numero, string mensagem)
        {
            InitializeComponent();
            txtResultado.Text = $"Número sorteado: {numero}\n{mensagem}";
        }
    }
}
