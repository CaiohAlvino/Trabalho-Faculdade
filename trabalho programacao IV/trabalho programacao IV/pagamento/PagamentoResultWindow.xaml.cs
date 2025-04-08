using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class PagamentoResultWindow : Window
    {
        public PagamentoResultWindow(double valorParcela)
        {
            InitializeComponent();
            txtResultado.Text = $"Valor de cada parcela: {valorParcela:F2}";
        }
    }
}
