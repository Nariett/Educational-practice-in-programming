using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private List<Product> products;
        private CartWindow cartWindow;

        public MainWindow()
        {
            InitializeComponent();
            products = LoadProducts();
            productGrid.ItemsSource = products;
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            List<Product> selectedProducts = new List<Product>();
            foreach (Product selectedProduct in productGrid.Items)
            {
                if (selectedProduct.IsSelected == true)
                {

                    selectedProducts.Add(selectedProduct);
                }
            }

            cartWindow = new CartWindow(selectedProducts);
            cartWindow.Owner = this;
            cartWindow.ShowDialog();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Product product = (Product)textBox.DataContext;
            if (int.TryParse(textBox.Text, out int quantity))
            {
                product.Quantity = quantity;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Product product = (Product)checkBox.DataContext;
            product.IsSelected = checkBox.IsChecked ?? false;
        }

        private List<Product> LoadProducts()
        {
            List<Product> productList = new List<Product>
        {
            new Product { Name = "Помидоры", Unit = "кг.", Price = 10 },
            new Product { Name = "Гвозди", Unit = "шт.", Price = 15 },
            new Product { Name = "Наушники", Unit = "шт.", Price = 5 },
            new Product { Name = "Краска", Unit = "л.", Price = 8 },
            new Product { Name = "Пицца", Unit = "шт", Price = 9 }
        };
            return productList;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool IsSelected { get; set; }
    }

}