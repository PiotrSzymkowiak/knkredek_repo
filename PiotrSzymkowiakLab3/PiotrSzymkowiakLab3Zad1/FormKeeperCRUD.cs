using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3Zad1
{
    public partial class FormKeeperCRUD : Form
    {
        private readonly SqlConnection sqlConnection;
        private readonly DataGridView dataGridView;
        /// <summary>
        /// Konstruktor okna służącego do edycji rekordów tabeli Opiekun
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="panelType"></param>
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

        /// <summary>
        /// Ustala który panel do edycji opiekuna ma być dostępny
        /// </summary>
        /// <param name="panelType"></param>
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

        /// <summary>
        /// Przycisk potwierdzający dodanie rekordu do tabeli Opiekun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Przycisk potwierdzający usunięcie rekordu z tabeli Opiekun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DataBaseQueries.DeleteKeeper(sqlConnection, dataGridView, textBoxID.Text);           
            this.Dispose();
        }

        /// <summary>
        /// Przycisk potwierdzający edycję rekordu w tabeli Opiekun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
