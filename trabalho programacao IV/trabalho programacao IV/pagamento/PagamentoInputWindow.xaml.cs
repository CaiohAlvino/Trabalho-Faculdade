using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace trabalho.programacao.IV
{
    public partial class PagamentoInputWindow : Window
    {
        public PagamentoInputWindow()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Click(object sender, RoutedEventArgs e)
        {
            double valorTotal;
            if (!double.TryParse(txtValorTotal.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valorTotal))
            {
                MessageBox.Show("Insira um valor numérico válido.");
                return;
            }
            if (cbParcelas.SelectedItem == null)
            {
                MessageBox.Show("Selecione o número de parcelas.");
                return;
            }
            int parcelas = int.Parse(((ComboBoxItem)cbParcelas.SelectedItem).Content.ToString());
            double valorParcela = valorTotal / parcelas;
            this.Close();
            PagamentoResultWindow resultWindow = new PagamentoResultWindow(valorParcela);
            resultWindow.ShowDialog();
        }
    }
}
