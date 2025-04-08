using System;
using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class SorteioWindow : Window
    {
        public SorteioWindow()
        {
            InitializeComponent();
        }

        private void ButtonSortear_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int numero = rnd.Next(1, 7); // Gera número de 1 a 6
            string mensagem = numero == 6 ? "Você ganhou!" : "Tente novamente!";
            this.Close();
            SorteioResultWindow resultWindow = new SorteioResultWindow(numero, mensagem);
            resultWindow.ShowDialog();
        }
    }
}
