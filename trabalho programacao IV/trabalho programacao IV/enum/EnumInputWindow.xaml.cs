using System;
using System.Windows;
using System.ComponentModel;
using System.Reflection;

namespace trabalho.programacao.IV
{
    public partial class EnumInputWindow : Window
    {
        public EnumInputWindow()
        {
            InitializeComponent();
            cbTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void ButtonExibir_Click(object sender, RoutedEventArgs e)
        {
            if (cbTipoUsuario.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de usuário.");
                return;
            }
            TipoUsuario tipo = (TipoUsuario)cbTipoUsuario.SelectedItem;
            string descricao = GetEnumDescription(tipo);
            this.Close();
            EnumResultWindow resultWindow = new EnumResultWindow(descricao);
            resultWindow.ShowDialog();
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            if (fi != null)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi
                    .GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
            }
            return value.ToString();
        }
    }
}
