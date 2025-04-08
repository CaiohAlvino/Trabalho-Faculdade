using System;
using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class BirthdayInputWindow : Window
    {
        private object dpNascimento;

        public BirthdayInputWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void ButtonCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (dpNascimento.SelectedDate == null)
            {
                MessageBox.Show("Por favor, selecione uma data.");
                return;
            }
            DateTime nascimento = dpNascimento.SelectedDate.Value;
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, nascimento.Month, nascimento.Day);
            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);
            int days = (nextBirthday - today).Days;
            this.Close();
            BirthdayResultWindow resultWindow = new BirthdayResultWindow(days);
            resultWindow.ShowDialog();
        }
    }
}
