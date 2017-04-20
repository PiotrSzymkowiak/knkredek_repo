using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    class Sloths
    {
        /// <summary>
        /// Wyswietlanie wszystkich leniwcow
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllSloths(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT Sloths.Name AS Imię, Age AS Wiek, Zookeeper.Name AS 'Imię opiekuna', 
                                                Zookeeper.Surname AS 'Nazwisko Opiekuna', Animals.Species AS 'Gatunek'
                                                FROM Sloths JOIN Animals ON Animals.ID = Sloths.AnimalID JOIN Zookeeper ON Sloths.ZookeeperID = Zookeeper.ID;", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
        /// <summary>
        /// Wyszukiwanie leniwca o podanym imieniu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        public static void FindByName(SqlConnection sqlConnection, DataGridView dataGridView, string name)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT* FROM Sloths WHERE Name LIKE '%{name}%'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
        /// <summary>
        /// Wyszukiwanie leniwca o wieku z podanego przedziału
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="ageLeft"></param>
        /// <param name="ageRight"></param>
        public static void AgeBeetween(SqlConnection sqlConnection,DataGridView dataGridView, string ageLeft, string ageRight)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT* FROM Sloths WHERE Age BETWEEN {ageLeft} AND {ageRight}", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

    }
}
