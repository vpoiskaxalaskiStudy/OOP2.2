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

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Savchuk_wpf
{
    
    public partial class MainWindow : Window
    {
        string connectionString1 = @"Data Source=cloud\sqlexpress;Initial Catalog=user1;Integrated Security=True";
        string connectionString2 = @"Data Source=cloud\sqlexpress;Initial Catalog=user2;Integrated Security=True";

        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();

            connection = new SqlConnection(connectionString1);

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Users";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, connection);
            dataAdapter.Fill(dataTable);
            userGrid.ItemsSource = dataTable.DefaultView;
           
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (connection.ConnectionString.Equals(connectionString1))
            {
                connection = new SqlConnection(connectionString2);
            }
            else
            {
                connection = new SqlConnection(connectionString1);
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Users";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, connection);
            dataAdapter.Fill(dataTable);
            userGrid.ItemsSource = dataTable.DefaultView;
        }
    }
}
