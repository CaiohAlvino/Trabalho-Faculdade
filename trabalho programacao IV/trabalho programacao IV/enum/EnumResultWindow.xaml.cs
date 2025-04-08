using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class EnumResultWindow : Window
    {
        public EnumResultWindow(string descricao)
        {
            InitializeComponent();
            txtResultado.Text = descricao;
        }
    }
}
