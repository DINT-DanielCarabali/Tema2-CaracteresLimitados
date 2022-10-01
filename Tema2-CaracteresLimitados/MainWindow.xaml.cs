using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textoTextBox.IsReadOnly = false;
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int contador = textoTextBox.Text.Length;
            contadorTextBlock.Text = $"{contador}/140";
            if (contador == textoTextBox.MaxLength)
                textoTextBox.IsReadOnly = true;
        }
    }
}