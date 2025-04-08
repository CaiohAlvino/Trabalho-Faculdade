using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class ContadorWindow : Window
    {
        private int contador = 0;
        public ContadorWindow()
        {
            InitializeComponent();
        }

        private void ButtonClique_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            txtContador.Text = $"Cliques: {contador}";
        }

        private void ButtonFinalizar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ContadorResultWindow resultWindow = new ContadorResultWindow(contador);
            resultWindow.ShowDialog();
        }
    }
}
