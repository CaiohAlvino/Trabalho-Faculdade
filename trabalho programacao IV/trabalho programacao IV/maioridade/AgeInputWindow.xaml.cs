using System;
using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class AgeInputWindow : Window
    {
        public AgeInputWindow()
        {
            InitializeComponent();
        }

        private void ButtonVerificar_Click(object sender, RoutedEventArgs e)
        {
            int idade;
            if (!int.TryParse(txtIdade.Text, out idade))
            {
                MessageBox.Show("Por favor, insira uma idade válida.");
                return;
            }
            string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
            this.Close();
            AgeResultWindow resultWindow = new AgeResultWindow(mensagem);
            resultWindow.ShowDialog();
        }
    }
}
