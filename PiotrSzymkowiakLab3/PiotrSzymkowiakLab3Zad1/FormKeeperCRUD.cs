using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3Zad1
{
    public partial class FormKeeperCRUD : Form
    {
        private readonly SqlConnection sqlConnection;
        private readonly DataGridView dataGridView;
        public FormKeeperCRUD(SqlConnection sqlConnection, DataGridView dataGridView, string panelType)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
            this.dataGridView = dataGridView;
            panelAdd.Enabled = false;
            panelDeleteKeeper.Enabled = false;
            panelUpdateKeeper.Enabled = false;

            ShowAdequatePanel(panelType);
        }

        private void ShowAdequatePanel(string panelType)
        {
            switch (panelType)
            {
                case "Add":
                    panelAdd.Enabled = true;
                    this.Text = "Add Keeper";
                    break;
                case "Update":                   
                    panelUpdateKeeper.Enabled = true;
                    this.Text = "Update Keeper";
                    DataBaseQueries.SelectAll(sqlConnection, dataGridViewUpdateKeeper, "Opiekun");
                    break;
                default:
                    panelDeleteKeeper.Enabled = true;
                    this.Text = "Delete Keeper";
                    DataBaseQueries.SelectAll(sqlConnection, dataGridViewDeleteKeeper, "Opiekun");
                    break;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxPESEL.Text == "")
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione!");
                return;
            }

            DataBaseQueries.AddKeeper(sqlConnection, dataGridView, textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text);
            this.Dispose();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DataBaseQueries.DeleteKeeper(sqlConnection, dataGridView, textBoxID.Text);           
            this.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (textBoxUpdateID.Text == "" || textBoxUpdateName.Text == "" || textBoxUpdateSurname.Text == "" || textBoxUpdatePESEL.Text == "")
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione!");
                return;
            }
            DataBaseQueries.UpdateKeeper(sqlConnection, dataGridView, textBoxUpdateID.Text,
                                         textBoxUpdateName.Text, textBoxUpdateSurname.Text, textBoxUpdatePESEL.Text);
            this.Dispose();
        }
    }
}
