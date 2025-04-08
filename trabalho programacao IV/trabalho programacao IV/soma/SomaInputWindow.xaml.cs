using System;
using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class SomaInputWindow : Window
    {
        public SomaInputWindow()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2;
            if (!int.TryParse(txtNumero1.Text, out num1) || !int.TryParse(txtNumero2.Text, out num2))
            {
                MessageBox.Show("Por favor, insira números inteiros válidos.");
                return;
            }
            int soma = num1 + num2;
            this.Close();
            // Abre a janela de resultado
            SomaResultWindow resultWindow = new SomaResultWindow(soma);
            resultWindow.ShowDialog();
        }
    }
}
