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
    /// Логика взаимодействия для TaskThree.xaml
    /// </summary>
    public partial class TaskThree : Window
    {
        public TaskThree()
        {
            InitializeComponent();
            combo.Items.Add("Красный");
            combo.Items.Add("Синий");
            combo.Items.Add("Черный");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grafic.Children.Clear();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Grafic.DefaultDrawingAttributes.Width = e.NewValue;
            Grafic.DefaultDrawingAttributes.Height = e.NewValue;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string select = (string)combo.SelectedItem;
            switch(select)
            {
                case "Красный":
                    Grafic.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Синий":
                    Grafic.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
                case "Черный":
                    Grafic.DefaultDrawingAttributes.Color = Colors.Black;
                    break;
            }    
        }
    }
}
