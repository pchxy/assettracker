/*using System.Data;
using System.Windows;
using Oracle.ManagedDataAccess.Client;

namespace AssetTracker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "User Id=system;Password=password;Data Source=134.124.189.240:1521/XE;";
            // home ip 24.107.79.188 and umsl ip 134.124.189.240
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Load data for Asset Table
                    string assetQuery = "SELECT * FROM Asset";
                    DataTable assetTable = GetDataTable(connection, assetQuery);
                    assetDataGrid.ItemsSource = assetTable.DefaultView;

                    // Load data for Transaction Table
                    string transactionQuery = "SELECT * FROM Transaction";
                    DataTable transactionTable = GetDataTable(connection, transactionQuery);
                    transactionDataGrid.ItemsSource = transactionTable.DefaultView;

                    // Load data for Employees Table
                    string employeesQuery = "SELECT * FROM Employees";
                    DataTable employeesTable = GetDataTable(connection, employeesQuery);
                    employeesDataGrid.ItemsSource = employeesTable.DefaultView;

                    // Load data for Location Table
                    string locationQuery = "SELECT * FROM Location";
                    DataTable locationTable = GetDataTable(connection, locationQuery);
                    locationDataGrid.ItemsSource = locationTable.DefaultView;

                    // Load data for Category Table
                    string categoryQuery = "SELECT * FROM Category";
                    DataTable categoryTable = GetDataTable(connection, categoryQuery);
                    categoryDataGrid.ItemsSource = categoryTable.DefaultView;

                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General Error: " + ex.Message);
                }
            }
        }

        // Helper function to fetch data from the database and return as DataTable
        private DataTable GetDataTable(OracleConnection connection, string query)
        {
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}


namespace AssetTracker 
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = "User Id=system;Password=password;Data Source=134.124.189.240:1521/XE;";
            // home ip 24.107.79.188 and umsl ip 134.124.189.240
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                   
                    connection.Open();


                    string query = "SELECT * FROM Asset";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        
                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();

                       
                        adapter.Fill(dataTable);

                        
                        dataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General Error: " + ex.Message);
                }
            }
        }
    }
} */

using System.Data;
using System.Windows;
using Oracle.ManagedDataAccess.Client;

namespace AssetTracker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "User Id=system;Password=password;Data Source=24.107.79.188:1521/XE;";
            // home ip 24.107.79.188 and umsl ip 134.124.189.240
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Load data for Asset Table
                    string assetQuery = "SELECT * FROM Asset";
                    DataTable assetTable = GetDataTable(connection, assetQuery);
                    assetDataGrid.ItemsSource = assetTable.DefaultView;

                    // Load data for Transaction Table
                    string transactionQuery = "SELECT * FROM Transaction";
                    DataTable transactionTable = GetDataTable(connection, transactionQuery);
                    transactionDataGrid.ItemsSource = transactionTable.DefaultView;

                    // Load data for Employees Table
                    string employeesQuery = "SELECT * FROM Employees";
                    DataTable employeesTable = GetDataTable(connection, employeesQuery);
                    employeesDataGrid.ItemsSource = employeesTable.DefaultView;

                    // Load data for Location Table
                    string locationQuery = "SELECT * FROM Location";
                    DataTable locationTable = GetDataTable(connection, locationQuery);
                    locationDataGrid.ItemsSource = locationTable.DefaultView;

                    // Load data for Category Table
                    string categoryQuery = "SELECT * FROM Category";
                    DataTable categoryTable = GetDataTable(connection, categoryQuery);
                    categoryDataGrid.ItemsSource = categoryTable.DefaultView;

                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General Error: " + ex.Message);
                }
            }
        }

        // Helper function to fetch data from the database and return as DataTable
        private DataTable GetDataTable(OracleConnection connection, string query)
        {
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}




