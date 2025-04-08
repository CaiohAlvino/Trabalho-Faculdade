using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class SomaResultWindow : Window
    {
        public SomaResultWindow(int resultado)
        {
            InitializeComponent();
            txtResultado.Text = $"A soma é: {resultado}";
        }
    }
}
