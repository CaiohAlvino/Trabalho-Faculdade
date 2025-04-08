using System;
using System.Windows;

namespace trabalho.programacao.IV
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Atividade 1: Soma de Dois Números
        private void ButtonSoma_Click(object sender, RoutedEventArgs e)
        {
            SomaInputWindow somaWindow = new SomaInputWindow();
            somaWindow.ShowDialog();
        }

        // Atividade 2: Conversor de Temperatura
        private void ButtonTemperatura_Click(object sender, RoutedEventArgs e)
        {
            TempInputWindow tempWindow = new TempInputWindow();
            tempWindow.ShowDialog();
        }

        // Atividade 3: Dias Até o Próximo Aniversário
        private void ButtonAniversario_Click(object sender, RoutedEventArgs e)
        {
            BirthdayInputWindow birthdayWindow = new BirthdayInputWindow();
            birthdayWindow.ShowDialog();
        }

        // Atividade 4: Verificador de Maioridade
        private void ButtonMaioridade_Click(object sender, RoutedEventArgs e)
        {
            AgeInputWindow ageWindow = new AgeInputWindow();
            ageWindow.ShowDialog();
        }

        // Atividade 5: Exibir Descrição de um Enum
        private void ButtonEnum_Click(object sender, RoutedEventArgs e)
        {
            EnumInputWindow enumWindow = new EnumInputWindow();
            enumWindow.ShowDialog();
        }

        // Atividade 6: Contador de Cliques
        private void ButtonCliques_Click(object sender, RoutedEventArgs e)
        {
            ContadorWindow contadorWindow = new ContadorWindow();
            contadorWindow.ShowDialog();
        }

        // Atividade 7: Simulador de Pagamento Parcelado
        private void ButtonPagamentoParcelado_Click(object sender, RoutedEventArgs e)
        {
            PagamentoInputWindow pagamentoWindow = new PagamentoInputWindow();
            pagamentoWindow.ShowDialog();
        }

        // Atividade 8: Verificar Dia da Semana
        private void ButtonDiaSemana_Click(object sender, RoutedEventArgs e)
        {
            DiaSemanaInputWindow diaSemanaWindow = new DiaSemanaInputWindow();
            diaSemanaWindow.ShowDialog();
        }

        // Atividade 9: Liga/Desliga
        private void ButtonLigaDesliga_Click(object sender, RoutedEventArgs e)
        {
            LigaDesligaWindow ligaDesligaWindow = new LigaDesligaWindow();
            ligaDesligaWindow.ShowDialog();
        }

        // Atividade 10: Simulador de Sorteio
        private void ButtonSorteio_Click(object sender, RoutedEventArgs e)
        {
            SorteioWindow sorteioWindow = new SorteioWindow();
            sorteioWindow.ShowDialog();
        }
    }
}
