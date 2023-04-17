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
using System.Windows.Shapes;

namespace WFPForm
{
    /// <summary>
    /// Логика взаимодействия для TaskTwo.xaml
    /// </summary>
    public partial class TaskTwo : Window
    {
        public TaskTwo()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Цвет изменен");
            this.Background = Brushes.Red;
            statusText.Text = "Цвет изменен";

        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик саша");
            statusText.Text = "Разработчик саша";
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Команда выполнена");
            statusText.Text = "Команда выполнена";
        }
    }
}
