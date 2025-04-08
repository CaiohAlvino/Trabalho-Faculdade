using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class TempResultWindow : Window
    {
        public TempResultWindow(double fahrenheit)
        {
            InitializeComponent();
            txtResultado.Text = $"Temperatura em Fahrenheit: {fahrenheit:F2}";
        }
    }
}
