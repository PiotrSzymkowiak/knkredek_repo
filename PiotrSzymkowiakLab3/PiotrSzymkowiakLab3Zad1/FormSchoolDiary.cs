using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3Zad1
{
    public partial class FormSchoolDiary : Form
    {
        private readonly SqlConnection sqlConnection;
        /// <summary>
        /// Konstruktor głównego okna aplikacji, łączy się z bazą za pomoca podanego connection stringa. 
        /// </summary>
        public FormSchoolDiary()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=LAPEKPIOTREK\\KREDEKINSTANCE; database=Dziennik_szkolny; Trusted_Connection=yes");   
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli adres_zamieszkania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddress_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "adres_zamieszkania");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Klasa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClass_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Klasa");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Komentarz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonComments_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Komentarz");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Lekcja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLessons_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Lekcja");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Nauczyciel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Nauczyciel");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Ocena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGrades_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Ocena");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Opiekun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKeepers_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Opiekun");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Plan_lekcji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLessonPlan_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Plan_lekcji");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli Uczen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStudents_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "Uczen");
        }

        /// <summary>
        /// Przycisk wyświetląjacy zawartość tabeli uczen_opiekun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStudent_Keeper_Click(object sender, EventArgs e)
        {
            DataBaseQueries.SelectAll(sqlConnection, dataGridViewSchoolDiary, "uczen_opiekun");
        }

        /// <summary>
        /// Komponent menu obsługujący wyświetlanie sie odpowiednich paneli w oknie głównym
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Przycisk wyświetlający wszystkie klasy z dodatkowymi informacjami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowAllClasses_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowAllClasses(sqlConnection, dataGridViewSchoolDiary);
        }

        /// <summary>
        /// Przycisk wyświetlający wszystkich uczniów w klasie o podanym stopniu (lub ogólnie wszystkich uczniów w dzienniku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowStudentsFromClass_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowStudentsFromClass(sqlConnection, dataGridViewSchoolDiary, textBoxClassDegree.Text);
        }

        /// <summary>
        /// Przycisk wyświetląjacy oceny ucznia o podanym imieniu i nazwisku (lub wszystkie oceny wszystkich uczniów)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowStudentsGrades_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowStudentsGrades(sqlConnection, dataGridViewSchoolDiary, textBoxStudentName.Text, textBoxStudentSurname.Text);
        }

        /// <summary>
        /// Przycisk wyświetlający lekcje danej klasy (lub wszystkich klas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowClassLessons_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowClassLessons(sqlConnection, dataGridViewSchoolDiary, textBoxClassDegree.Text);
        }

        /// <summary>
        /// Przycisk wyświetlający informacje o nauczycielach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowAllTeachers_Click(object sender, EventArgs e)
        {
            DataBaseQueries.ShowAllTeachers(sqlConnection, dataGridViewSchoolDiary);
        }

        /// <summary>
        /// Dynamiczne wyszukiwanie uczniów po imieniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchByNameStudents_TextChanged(object sender, EventArgs e)
        {
            DataBaseQueries.SearchByName(sqlConnection, dataGridViewSchoolDiary, textBoxSearchByNameStudents.Text, "Uczen");
        }

        /// <summary>
        /// Dynamiczne wyszukiwanie nauczycieli po imieniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchByNameTeachers_TextChanged(object sender, EventArgs e)
        {
            DataBaseQueries.SearchByName(sqlConnection, dataGridViewSchoolDiary, textBoxSearchByNameTeachers.Text, "Nauczyciel");
        }

        /// <summary>
        /// Dynamiczne wyszukiwanie opiekunów po imieniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchByNameKeepers_TextChanged(object sender, EventArgs e)
        {
            DataBaseQueries.SearchByName(sqlConnection, dataGridViewSchoolDiary, textBoxSearchByNameKeepers.Text, "Opiekun");
        }

        /// <summary>
        /// Przycisk odpowiedzialny za wyświetlenie okna edycji tabeli Opiekun z uprawnieniami do dodawania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddKeeper_Click(object sender, EventArgs e)
        {
            var addForm = new FormKeeperCRUD(sqlConnection, dataGridViewSchoolDiary, "Add");
            addForm.Show();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za wyświetlenie okna edycji tabeli Opiekun z uprawnieniami do usuwania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteKeeper_Click(object sender, EventArgs e)
        {
            var deleteForm = new FormKeeperCRUD(sqlConnection, dataGridViewSchoolDiary, "Delete");
            deleteForm.Show();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za wyświetlenie okna edycji tabeli Opiekun z uprawnieniami do aktualizowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateKeeper_Click(object sender, EventArgs e)
        {
            var updateForm = new FormKeeperCRUD(sqlConnection, dataGridViewSchoolDiary, "Update");
            updateForm.Show();
        }
    }
}
