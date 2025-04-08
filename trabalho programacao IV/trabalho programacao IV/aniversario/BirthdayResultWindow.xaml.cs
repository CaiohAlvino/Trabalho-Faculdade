using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class BirthdayResultWindow : Window
    {
        public BirthdayResultWindow(int days)
        {
            InitializeComponent();
            txtResultado.Text = $"Faltam {days} dias para o próximo aniversário.";
        }
    }
}
