using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zoo
{
    public partial class FormZOO : Form
    {
        readonly SqlConnection sqlConnection;

        public FormZOO()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=LAPEKPIOTREK\\KREDEKINSTANCE; database=ZOO; Trusted_Connection=yes");
            var species = Animals.ListOfSpecies(sqlConnection);
            foreach (var n in species)
            {
                comboBoxSpecies.Items.Add(n);
            }
        }

        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            Animals.ShowAllAnimals(sqlConnection, dataGridViewZoo);
        }

        private void buttonSloths_Click(object sender, EventArgs e)
        {
            Sloths.ShowAllSloths(sqlConnection, dataGridViewZoo);
        }

        private void buttonAddZookeeper_Click(object sender, EventArgs e)
        {
            Zookeepers.AddZookeeper(sqlConnection, dataGridViewZoo, textBoxZookeeperName.Text, textBoxZookeeperSurname.Text);
        }

        private void buttonShowAllZookeepers_Click(object sender, EventArgs e)
        {
           Zookeepers.ShowAllZookeepers(sqlConnection, dataGridViewZoo);

        }

        private void buttonFindAge_Click(object sender, EventArgs e)
        {
            Sloths.AgeBeetween(sqlConnection, dataGridViewZoo, textBoxAgeLeft.Text, textBoxAgeRight.Text);
        }

        private void buttonAddMoreAnimals_Click(object sender, EventArgs e)
        {
            if (!IsDigitsOnlyAndNotEmpty(textBoxAnimalsAmountToAdd.Text))
            {
                return;
            }
            Animals.AddMore(sqlConnection, dataGridViewZoo, comboBoxSpecies.Text, textBoxAnimalsAmountToAdd.Text);
        }

        /// <summary>
        /// Sprawdza czy w podanym stringu są tylko i wyłącznie cyfry
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool IsDigitsOnlyAndNotEmpty(string str)
        {
            if (str == "")
            {
                return false;
            }

            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void textBoxFindSloths_TextChanged(object sender, EventArgs e)
        {
            Sloths.FindByName(sqlConnection, dataGridViewZoo, textBoxFindSloths.Text);
        }

        private void buttonDeleteZookeeper_Click(object sender, EventArgs e)
        {
            Zookeepers.DeleteZookeeper(sqlConnection, dataGridViewZoo, textBoxZookeeperName.Text, textBoxZookeeperSurname.Text);
        }
    }
}
