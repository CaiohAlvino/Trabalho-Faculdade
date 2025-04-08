using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class AgeResultWindow : Window
    {
        public AgeResultWindow(string mensagem)
        {
            InitializeComponent();
            txtResultado.Text = mensagem;
        }
    }
}
