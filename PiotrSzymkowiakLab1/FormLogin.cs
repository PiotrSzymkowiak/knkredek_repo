using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab1
{
    public partial class FormLogin : Form
    {
        //Licznik kliknięć
        public int counter = 0;

        //Zmienna tekstowa
        public string text = "Przykładowy ekran";

        public FormLogin()
        {
            InitializeComponent();
        } 
         
        /// <summary>
        /// Przycisk logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                var loginBackColor = textBoxLogin.BackColor;
                var passwordBackColor = textBoxPassword.BackColor;
                textBoxLogin.BackColor = Color.Red;
                textBoxPassword.BackColor = Color.Red;
                MessageBox.Show("Enter login and password!");
                textBoxLogin.BackColor = loginBackColor;
                textBoxPassword.BackColor = passwordBackColor;
                return;
            }

            if (textBoxPassword.Text != "pass")
            {
                var loginBackColor = textBoxLogin.BackColor;
                var passwordBackColor = textBoxPassword.BackColor;
                textBoxLogin.BackColor = Color.Red;
                textBoxPassword.BackColor = Color.Red;
                MessageBox.Show("Bad password!");
                textBoxLogin.BackColor = loginBackColor;
                textBoxPassword.BackColor = passwordBackColor;
                return;
            }

            textBoxLogin.BackColor = Color.Azure;
            textBoxPassword.BackColor = Color.Azure;
            labelLoggedIn.Text = textBoxLogin.Text;
            labelLoggedIn.Visible = true;
            MessageBox.Show($"Zalogowano jako {textBoxLogin.Text}");
            

        }

        /// <summary>
        /// Przykładowa pętla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                textBoxLogin.Text += i+1;
            }
        }

        /// <summary>
        /// Tworzy nowe okienko zalogowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FormLogged formLogged = new FormLogged(textBoxLogin.Text);
            formLogged.Text = textBoxLogin.Text;                                 
            formLogged.Show();
        }
    }
}
