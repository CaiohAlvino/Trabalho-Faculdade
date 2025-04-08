using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class DiaSemanaResultWindow : Window
    {
        public DiaSemanaResultWindow(string diaSemana)
        {
            InitializeComponent();
            txtResultado.Text = $"Dia da semana: {diaSemana}";
        }
    }
}
