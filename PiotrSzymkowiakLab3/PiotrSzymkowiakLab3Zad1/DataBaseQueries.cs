using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab3Zad1
{
    class DataBaseQueries
    {
        private static SqlCommand sqlCommand;

        /// <summary>
        /// Metoda wyświetlająca całą zawartość podanej tabeli
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="table"></param>
        public static void SelectAll(SqlConnection sqlConnection, DataGridView dataGridView, string table)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table}", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// Metoda wypełniająca podany komponent DataGridView
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
        /// Metoda wyświetlajaca wszystkie klasy w dzienniku
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllClasses(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            var query = "SELECT stopien as \"Stopień klasy\", specjalizacja as \"Specjalizacja klasy\"," +
                        " imie as \"Imię wychowawcy\", nazwisko as \"Nazwisko wychowawcy\" " +
                        "FROM Klasa JOIN Nauczyciel ON Klasa.id_nauczyciela = Nauczyciel.id_nauczyciela ";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// Metoda wyświetlająca wszystkich uczniów w dzienniku lub należących do klasy o podanym stopniu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="degree"></param>
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

        /// <summary>
        /// Metoda wyświetlająca wszystkie oceny wszystkich uczniów lub podanego ucznia z imienia i nazwiska
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
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

        /// <summary>
        /// Metoda wyświetlająca lekcje wszystkich klas lub tej o podanym stopniu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="degree"></param>
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

        /// <summary>
        /// Metoda wyświetlających wszystkich nauczycieli
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllTeachers(SqlConnection sqlConnection, DataGridView dataGridView)
        {
           var query = "SELECT imie as \"Imię nauczyciela\", nazwisko as \"Nazwisko nauczyciela\"," +
                        " PESEL, Klasa.stopien as \"Wychowawca klasy o stopnu \"," +
                        " Klasa.specjalizacja as \"Specjalizacja klasy\" " +
                        "FROM Nauczyciel LEFT JOIN Klasa ON Nauczyciel.id_nauczyciela = Klasa.id_nauczyciela ";

           SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
           FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// Metoda przeszukująca podaną tabelę po podanym imieniu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        /// <param name="table"></param>
        public static void SearchByName(SqlConnection sqlConnection, DataGridView dataGridView, string name, string table)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table} WHERE imie LIKE '%{name}%'", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// Metoda wykonuje podane zapytanie i wyświetla MessageBox z podaną wiadomością
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="command"></param>
        /// <param name="message"></param>
        private static void ExecuteQuery(SqlConnection sqlConnection, DataGridView dataGridView, string command, string message)
        {
            sqlConnection.Open();           
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show(message);            
            sqlConnection.Close();
        }

        /// <summary>
        /// Metoda dodająca do tabeli Opiekun rekord z podanym imieniem, nazwiskiem i PESELEM
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="PESEL"></param>
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

        /// <summary>
        /// Metoda usuwająca rekord w tabeli Opiekun o podanym kluczu głównym
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="id"></param>
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

        /// <summary>
        /// Metoda edytująca rekord w tabeli Opiekun o podanym kluczu głównym, zmieniając zawartośc kolumn imie, nazwisko i PESEL
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="PESEL"></param>
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
