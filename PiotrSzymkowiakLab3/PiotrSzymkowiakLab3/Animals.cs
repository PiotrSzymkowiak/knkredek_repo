using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3
{
    class Animals
    {
        public static void ShowAnimals(SqlConnection sqlConnection, DataGridView  dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Species AS Gatunek, Amount AS Ilosc FROM Animals", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
          
        }

        public static void AddAnimal(SqlConnection sqlConnection, DataGridView dataGridView, string species, string amount)
        {
            sqlConnection.Open();
            string command = $"INSERT INTO Animals (Species, Amount) VALUES ('{species}','{amount}')";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("udało się!");
            ShowAnimals(sqlConnection, dataGridView);
            sqlConnection.Close();
        }

    }
}
