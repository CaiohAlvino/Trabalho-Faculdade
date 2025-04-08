using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class LigaDesligaWindow : Window
    {
        private bool ligado = false;
        public LigaDesligaWindow()
        {
            InitializeComponent();
        }

        private void ButtonAlternar_Click(object sender, RoutedEventArgs e)
        {
            ligado = !ligado;
            txtEstado.Text = ligado ? "Ligado" : "Desligado";
        }

        private void ButtonFinalizar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LigaDesligaResultWindow resultWindow = new LigaDesligaResultWindow(ligado);
            resultWindow.ShowDialog();
        }
    }
}
