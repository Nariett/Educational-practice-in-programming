using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp
{
    public partial class CartWindow : Window
    {
        public static double Allitog = 0;
        public static readonly DependencyProperty CartItemsProperty =
            DependencyProperty.Register("CartItems", typeof(ObservableCollection<CartItem>), typeof(CartWindow), new PropertyMetadata(new ObservableCollection<CartItem>()));

        public ObservableCollection<CartItem> CartItems
        {
            get { return (ObservableCollection<CartItem>)GetValue(CartItemsProperty); }
            set { SetValue(CartItemsProperty, value); }
        }

        public CartWindow(List<Product> selectedProducts)
        {
            InitializeComponent();
            CartItems = new ObservableCollection<CartItem>();
            cartGrid.ItemsSource = CartItems;
            DataContext = this;

            foreach (Product product in selectedProducts)
            {
                AddToCart(product.Name, product.Unit, product.Price, product.Quantity);
            }
            AddItog(Allitog);
        }

        public void AddToCart(string productName, string unit, double price, int quantity)
        {
            CartItems.Add(new CartItem { ProductName = productName, Unit = unit, Price = price, Quantity = quantity, Itog =  price * quantity });
            Allitog += price * quantity;
        }
        public void AddItog(double Allitog)
        {
            CartItems.Add(new CartItem { Itog = Allitog + (Allitog*5/100) });
        }
    }

    public class CartItem
    {
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Itog { get; set; }
    }
}
