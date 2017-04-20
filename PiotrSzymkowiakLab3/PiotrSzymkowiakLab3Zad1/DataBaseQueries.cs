using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3Zad1
{
    class DataBaseQueries
    {
        private static SqlCommand sqlCommand;
        public static void SelectAll(SqlConnection sqlConnection, DataGridView dataGridView, string table)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table}", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        public static void ShowAllClasses(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            var query = "SELECT stopien as \"Stopień klasy\", specjalizacja as \"Specjalizacja klasy\"," +
                        " imie as \"Imię wychowawcy\", nazwisko as \"Nazwisko wychowawcy\" " +
                        "FROM Klasa JOIN Nauczyciel ON Klasa.id_nauczyciela = Nauczyciel.id_nauczyciela ";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void ShowStudentsFromClass(SqlConnection sqlConnection, DataGridView dataGridView, string degree)
        {
            var query = "SELECT imie as \"Imię ucznia\", nazwisko as \"Nazwisko Ucznia\"," +
                        " PESEL, stopien as \"Stopien klasy\"," +
                        " specjalizacja as \"Specjalizacja klasy\" " +
                        "FROM Uczen JOIN Klasa on Uczen.id_klasy = Klasa.id_klasy ";

            if (degree != "" )
            {
                query += $"WHERE stopien = {degree}";
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void ShowStudentsGrades(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname)
        {

            var query = "SELECT imie as \"Imię ucznia\", nazwisko as \"Nazwisko Ucznia\"," +
                        " PESEL, Ocena.tytul as \"Tytuł oceny\"," +
                        " ocena, Waga, Lekcja.tytul as \"Lekcja\" " +
                        "FROM Uczen JOIN Ocena on Uczen.id_ucznia = Ocena.id_ucznia " +
                        "JOIN  Lekcja on Lekcja.id_lekcji = Ocena.id_lekcji ";

            if (name != "" && surname != "")
            {
                query += $"WHERE imie = '{name}' AND nazwisko = '{surname}'";
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void ShowClassLessons(SqlConnection sqlConnection, DataGridView dataGridView, string degree)
        {
           var query = "SELECT stopien as \"Stopień klasy\", specjalizacja as \"Specjalizacja klasy\"," +
                        " imie as \"Imię nauczyciela\", nazwisko as \"Nazwisko nauczyciela\"," +
                        " tytul as \"Lekcja\", data as \"Data lekcji\", sala as \"Sala\" " +
                        " FROM Klasa JOIN Lekcja on Klasa.id_klasy = Lekcja.id_klasy" +
                        " JOIN  Nauczyciel on Lekcja.id_nauczyciela = Nauczyciel.id_nauczyciela ";

            if (degree != "")
            {
                query += $"WHERE stopien = {degree}";
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void ShowAllTeachers(SqlConnection sqlConnection, DataGridView dataGridView)
        {
           var query = "SELECT imie as \"Imię nauczyciela\", nazwisko as \"Nazwisko nauczyciela\"," +
                        " PESEL, Klasa.stopien as \"Wychowawca klasy o stopnu \"," +
                        " Klasa.specjalizacja as \"Specjalizacja klasy\" " +
                        "FROM Nauczyciel LEFT JOIN Klasa ON Nauczyciel.id_nauczyciela = Klasa.id_nauczyciela ";

           SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
           FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void SearchByName(SqlConnection sqlConnection, DataGridView dataGridView, string name, string table)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table} WHERE imie LIKE '%{name}%'", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        private static void ExecuteQuery(SqlConnection sqlConnection, DataGridView dataGridView, string command, string message)
        {
            sqlConnection.Open();           
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show(message);            
            sqlConnection.Close();
        }

        public static void AddKeeper(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname, string PESEL)
        {
            try
            {
                
                string command = $"INSERT INTO Opiekun (imie, nazwisko, PESEL, adres_zamieszkania) values ('{name}','{surname}','{PESEL}', 1)";
                ExecuteQuery(sqlConnection, dataGridView, command, "Dodano");
                SelectAll(sqlConnection, dataGridView, "Opiekun");
            }
            catch
            {
                sqlConnection.Close();
                MessageBox.Show("Błąd");
            }
        }

        public static void DeleteKeeper(SqlConnection sqlConnection, DataGridView dataGridView, string id)
        {
            try
            {
                string command = $"DELETE FROM Opiekun WHERE id_opiekuna = {id}";
                ExecuteQuery(sqlConnection, dataGridView, command, "Usunięto");
                SelectAll(sqlConnection, dataGridView, "Opiekun");
            }
            catch
            {
                sqlConnection.Close();
                MessageBox.Show("Błąd");
            }
        }

        public static void UpdateKeeper(SqlConnection sqlConnection, DataGridView dataGridView, 
                                        string id, string name, string surname, string PESEL)
        {
            try
            {
                string command = $"EXEC spAktualizujOpiekuna @id_opiekuna = {id}, @imie = {name}," +
                                 $" @nazwisko = {surname}, @PESEL = {PESEL}";
                ExecuteQuery(sqlConnection, dataGridView, command, "Edytowano");
                SelectAll(sqlConnection, dataGridView, "Opiekun");
            }
            catch
            {
                sqlConnection.Close();
                MessageBox.Show("Błąd");
                
            }
        }
       
    }
}
