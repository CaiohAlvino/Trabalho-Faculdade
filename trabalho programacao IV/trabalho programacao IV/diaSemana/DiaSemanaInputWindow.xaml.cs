using System;
using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class DiaSemanaInputWindow : Window
    {
        public DiaSemanaInputWindow()
        {
            InitializeComponent();
        }

        private void ButtonVerificar_Click(object sender, RoutedEventArgs e)
        {
            if (dpData.SelectedDate == null)
            {
                MessageBox.Show("Selecione uma data.");
                return;
            }
            DateTime data = dpData.SelectedDate.Value;
            string diaSemana = data.DayOfWeek.ToString();
            this.Close();
            DiaSemanaResultWindow resultWindow = new DiaSemanaResultWindow(diaSemana);
            resultWindow.ShowDialog();
        }
    }
}
