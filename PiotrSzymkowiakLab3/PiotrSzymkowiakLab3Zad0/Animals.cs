using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Zoo
{
    class Animals
    {
        /// <summary>
        /// Wyswietlanie wszystkich zwierzat
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllAnimals(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Species AS Gatunek, Amount AS Ilość FROM Animals", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
        /// <summary>
        /// Wypelnianie DataGridView
        /// </summary>
        /// <param name="sqlDataAdapter"></param>
        /// <param name="dataGridView"></param>
        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            
        }
        /// <summary>
        /// Zwraca List<string> wypelniona gatunkami zwierzat
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <returns></returns>
        public static List<string> ListOfSpecies(SqlConnection sqlConnection)
        {
            var Species = new List<string>();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Species FROM Animals", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Species = dataTable.AsEnumerable().Select(n => n.Field<string>(0)).ToList();

            return Species;
        }
        /// <summary>
        /// Zwierzkanie liczby zwierzat ze wzgledu na wybrany gatunek (comboBox)
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="species"></param>
        public static void AddMore(SqlConnection sqlConnection, DataGridView dataGridView, string species, string amount)
        {

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"UPDATE Animals SET Amount = Amount + {amount} WHERE Species = '{species}'", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
            ShowAllAnimals(sqlConnection, dataGridView);
        }
    }
}
