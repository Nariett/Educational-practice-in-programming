using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WFPForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string[] arr = new string[] { "a", "b", "c", "d", "e", "f" };
        public string[] color = new string[] { "Yellow", "Red", "Green", "Blue", "Grey", "White" };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            TaskOne taskOne = new TaskOne();
            taskOne.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TaskTwo taskTwo = new TaskTwo();
            taskTwo.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            TaskThree taskThree = new TaskThree();
            taskThree.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            TaskFour taskFour = new TaskFour();
            taskFour.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            TaskFive taskFive = new TaskFive();
            taskFive.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            TaskSix taskSix = new TaskSix();
            taskSix.Show();
        }
    }
}
