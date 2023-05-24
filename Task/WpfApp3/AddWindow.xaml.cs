using System;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Markup;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public string connectionString = "Data Source=Receiver.db;Version=3;";
        public AddWindow()
        {
            InitializeComponent();
            ConnectToSQLite();
        }
        private void ConnectToSQLite()
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Animal";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        animalDataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
                connection.Close();
            }
        }
        public string SelectData()
        {
            if (Calendar.SelectedDate.HasValue)
            {
                DateTime data = Calendar.SelectedDate.Value;
                return $"{data.Day:00}.{data.Month:00}.{data.Year}";
            }
            else
            {
                DateTime data = DateTime.Now;
                return $"{data.Day:00}.{data.Month:00}.{data.Year}";
            }
        }
        private void Update_Data()
        {
            animalDataGrid.ItemsSource = null;
            ConnectToSQLite();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO Animal (Name, Kind, Breed, Year, Date, Info) VALUES (@Name, @Kind, @Breed, @Year, @Date, @Info)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name.Text);
                    command.Parameters.AddWithValue("@Kind", Kind.Text);
                    command.Parameters.AddWithValue("@Breed",Breed.Text);
                    command.Parameters.AddWithValue("@Year", Convert.ToInt32(Year.Text));
                    command.Parameters.AddWithValue("@Date", SelectData());
                    command.Parameters.AddWithValue("@Info", Info.Text);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            Update_Data();
        }
    }
}
