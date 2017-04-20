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
    public partial class FormSchoolDiary : Form
    {
        private readonly SqlConnection sqlConnection;
        public FormSchoolDiary()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=LAPEKPIOTREK\\KREDEKINSTANCE; database=Dziennik_szkolny; Trusted_Connection=yes");   
        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "adres_zamieszkania");
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Klasa");
        }

        private void buttonComments_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Komentarz");
        }

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Lekcja");
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Nauczyciel");
        }

        private void buttonGrades_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Ocena");
        }

        private void buttonKeepers_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Opiekun");
        }

        private void buttonLessonPlan_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Plan_lekcji");
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Uczen");
        }

        private void buttonStudent_Keeper_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "uczen_opiekun");
        }

        private void RawDataButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RawDataButtonsToolStripMenuItem.Checked)
            {
                RawDataButtonsToolStripMenuItem.Checked = false;
                mainPanel.BringToFront();
            }
            else
            {
                RawDataButtonsToolStripMenuItem.Checked = true;
                panelForRawDataButtons.BringToFront();
            }
        }

        private void buttonShowAllClasses_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowAllClasses(sqlConnection, dataGridViewSchoolDiary);
        }

        private void buttonShowStudentsFromClass_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowStudentsFromClass(sqlConnection, dataGridViewSchoolDiary, textBoxClassDegree.Text);
        }

        private void buttonShowStudentsGrades_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowStudentsGrades(sqlConnection, dataGridViewSchoolDiary, textBoxStudentName.Text, textBoxStudentSurname.Text);
        }

        private void buttonShowClassLessons_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowClassLessons(sqlConnection, dataGridViewSchoolDiary, textBoxClassDegree.Text);
        }

        private void buttonShowAllTeachers_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowAllTeachers(sqlConnection, dataGridViewSchoolDiary);
        }

        private void textBoxSearchByNameStudents_TextChanged(object sender, EventArgs e)
        {
            DataBaseQueries.SearchByName(sqlConnection, dataGridViewSchoolDiary, textBoxSearchByNameStudents.Text, "Uczen");
        }

        private void textBoxSearchByNameTeachers_TextChanged(object sender, EventArgs e)
        {
            DataBaseQueries.SearchByName(sqlConnection, dataGridViewSchoolDiary, textBoxSearchByNameTeachers.Text, "Nauczyciel");
        }

        private void textBoxSearchByNameKeepers_TextChanged(object sender, EventArgs e)
        {
            DataBaseQueries.SearchByName(sqlConnection, dataGridViewSchoolDiary, textBoxSearchByNameKeepers.Text, "Opiekun");
        }

        private void buttonAddKeeper_Click(object sender, EventArgs e)
        {
            var addForm = new FormKeeperCRUD(sqlConnection, dataGridViewSchoolDiary, "Add");
            addForm.Show();
        }

        private void buttonDeleteKeeper_Click(object sender, EventArgs e)
        {
            var deleteForm = new FormKeeperCRUD(sqlConnection, dataGridViewSchoolDiary, "Delete");
            deleteForm.Show();
        }

        private void buttonUpdateKeeper_Click(object sender, EventArgs e)
        {
            var updateForm = new FormKeeperCRUD(sqlConnection, dataGridViewSchoolDiary, "Update");
            updateForm.Show();
        }
    }
}
