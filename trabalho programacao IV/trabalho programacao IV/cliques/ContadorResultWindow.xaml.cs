using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class ContadorResultWindow : Window
    {
        public ContadorResultWindow(int total)
        {
            InitializeComponent();
            txtResultado.Text = $"Total de cliques: {total}";
        }
    }
}
