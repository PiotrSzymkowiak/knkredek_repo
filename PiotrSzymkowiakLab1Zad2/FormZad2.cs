using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab1Zad2
{
    public partial class FormZad2 : Form
    {
        private int tickAmountMax;
        private int tickAmount;
        private int clickMaximumCount;
        private int clickCount;
        Random random = new Random();
        public FormZad2()
        {
            InitializeComponent();
            buttonClickMe.Hide();                    
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonClickMe.Show();
            buttonStart.Hide();
            GameInitialization();
            labelTickAmountMax.Text = $"0/{tickAmountMax.ToString()}";
            gameTimer.Interval = 1500;
            gameTimer.Start();                    
        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {           
            clickCount++;                               
            progressBarOfGameCompletion.Increment(1);
            if(clickCount >= clickMaximumCount)
            {
                gameTimer.Stop();
                MessageBox.Show($"You won! You have clicked in time for {clickCount} times");                
            }
          
        }

        /// <summary>
        /// Inicjalizuje ustawienia gry w zależności od wybranego poziomu trudności.
        /// </summary>
        private void GameInitialization()
        {
            if(mediumToolStripMenuItem.Checked)
            {
                clickMaximumCount = 6;
                tickAmountMax = 20;
            }
            else if(easyToolStripMenuItem.Checked)
            {
                clickMaximumCount = 3;
                tickAmountMax = 15;
            }
            else if(hardToolStripMenuItem.Checked)
            {
                clickMaximumCount = 10;               
                tickAmountMax = 30;
            }

            progressBarOfGameCompletion.Maximum = clickMaximumCount;
        }

        /// <summary>
        /// Implementuje zachowanie opcji trudności(MenuItems) w stylu RadioButton w zależności od podanego stringa.
        /// easy - uncheck medium, hard
        /// medium - uncheck easy, hard
        /// hard - uncheck easy, medium
        /// </summary>
        /// <param name="difficulty"></param>
        private void DifficultyRadioButtonSettings(string difficulty)
        {
            if(difficulty != "medium" && difficulty != "easy" && difficulty != "hard")
            {
                return;
            }

            if(difficulty == "medium")
            {
                easyToolStripMenuItem.Checked = false;
                hardToolStripMenuItem.Checked = false;
            }
            else if(difficulty == "easy")
            {
                mediumToolStripMenuItem.Checked = false;
                hardToolStripMenuItem.Checked = false;
            }
            else if (difficulty == "hard")
            {
                easyToolStripMenuItem.Checked = false;
                mediumToolStripMenuItem.Checked = false;
            }

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyRadioButtonSettings("easy");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyRadioButtonSettings("medium");
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyRadioButtonSettings("hard");
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            var x = random.Next(12, 288);
            var y = random.Next(50, 250);
            var point = new Point(x, y);
            buttonClickMe.Location = point;
            tickAmount++;
            labelTickAmountMax.Text = $"{tickAmount}/{tickAmountMax}";
           

        }
    }
}
