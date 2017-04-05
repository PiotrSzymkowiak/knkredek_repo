using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3
{
    public partial class FormZOO : Form
    {
        private SqlConnection sqlConnection;

        public FormZOO()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=LAPEKPIOTREK\\KREDEKINSTANCE; database=ZOO; Trusted_Connection=yes");

        }

        private void buttonShowAnimals_Click(object sender, System.EventArgs e)
        {
            Animals.ShowAnimals(sqlConnection, dataGridViewZOO);
        }

        private void buttonShowSloths_Click(object sender, System.EventArgs e)
        {
            Sloths.ShowSloths(sqlConnection, dataGridViewZOO);
        }

        private void buttonAddAnimal_Click(object sender, System.EventArgs e)
        {
            Animals.AddAnimal(sqlConnection, dataGridViewZOO, textBoxAnimalSpecies.Text, textBoxAnimalAmount.Text);
        }
    }
}
