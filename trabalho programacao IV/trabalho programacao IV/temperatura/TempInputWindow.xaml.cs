using System;
using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class TempInputWindow : Window
    {
        public TempInputWindow()
        {
            InitializeComponent();
        }

        private void ButtonConverter_Click(object sender, RoutedEventArgs e)
        {
            double celsius;
            if (!double.TryParse(txtCelsius.Text, out celsius))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");
                return;
            }
            double fahrenheit = (celsius * 9 / 5) + 32;
            this.Close();
            TempResultWindow resultWindow = new TempResultWindow(fahrenheit);
            resultWindow.ShowDialog();
        }
    }
}
