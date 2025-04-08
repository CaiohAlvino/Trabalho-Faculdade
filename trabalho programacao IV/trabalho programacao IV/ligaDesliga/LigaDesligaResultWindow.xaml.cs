using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class LigaDesligaResultWindow : Window
    {
        public LigaDesligaResultWindow(bool estado)
        {
            InitializeComponent();
            txtResultado.Text = $"O sistema está {(estado ? "Ligado" : "Desligado")}.";
        }
    }
}
