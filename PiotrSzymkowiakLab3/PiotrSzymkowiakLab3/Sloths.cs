using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3
{
    class Sloths
    {
        public static void ShowSloths(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT Sloths.Name, Sloths.Age, Zookeeper.Name, Zookeeper.Surname, Animals.Species FROM Sloths JOIN Animals ON Animals.ID=Sloths.AnimalID JOIN Zookeeper ON Zookeeper.ID=Sloths.ZookeeperID", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }

    }
}
