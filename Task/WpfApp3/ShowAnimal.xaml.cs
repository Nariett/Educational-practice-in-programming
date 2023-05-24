using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для ShowAnimal.xaml
    /// </summary>
    public partial class ShowAnimal : Window
    {
        public string connectionString = "Data Source=Receiver.db;Version=3;";
        private DataTable animalDataTable;
        public ShowAnimal()
        {
            InitializeComponent();
            ConnectToSQLite("SELECT * FROM Animal");
            DisplayAnimalDataGrid();
        }

        private void ConnectToSQLite(string query)
        {

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        animalDataTable = new DataTable();
                        adapter.Fill(animalDataTable);
                    }
                }
                connection.Close();
            }
        }
        private void DisplayAnimalDataGrid()
        {
            animalDataGrid.ItemsSource = animalDataTable.DefaultView;
        }

        private void ButtonName_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != "")
            {
                ConnectToSQLite($"SELECT * FROM Animal WHERE Name = '{Name.Text}'");
                DisplayAnimalDataGrid();
            }
            else
            {
                MessageBox.Show("Заполните имя");
            }

        }

        private void ButtonYear_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (Year.Text != "" && int.TryParse(Year.Text,out i))
            {
                ConnectToSQLite($"SELECT * FROM Animal WHERE Year = {Year.Text}");
                DisplayAnimalDataGrid();
            }
            else
            {
                MessageBox.Show("Заполните Возраст");
            }
        }

        private void ButtonType_Click(object sender, RoutedEventArgs e)
        {
            if (Type.Text != "")
            {
                ConnectToSQLite($"SELECT * FROM Animal WHERE Kind = '{Type.Text}'");
                DisplayAnimalDataGrid();
            }
            else
            {
                MessageBox.Show("Заполните Тип животного");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConnectToSQLite("SELECT * FROM Animal");
            DisplayAnimalDataGrid();
        }
    }
}
