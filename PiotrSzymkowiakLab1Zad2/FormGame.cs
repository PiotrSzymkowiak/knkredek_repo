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
    public partial class FormGame : Form
    {
        private int tickAmountMaximum;
        private int tickCount;
        private int clickAmountMaximum;
        private int clickCount;
        private int wrongClickAmountMaxiumum;
        private int wrongClickCount;
        private int numberOfWrongButtons;
        private List<Button> listOfWrongButtons = new List<Button>();
        Random random = new Random();
        public FormGame()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameInitialization();
        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {
            clickCount++;
            progressBarOfGameCompletion.Increment(1);
            buttonClickMe.Enabled = false;
            CheckLoseOrWinConditions();

        }

        /// <summary>
        /// Inicjalizuje ustawienia gry biorąc pod uwagę wybrany poziom trudności.
        /// </summary>
        private void GameInitialization()
        {
            if (mediumToolStripMenuItem.Checked)
            {
                SetGameSettings(6, 12, 3, 12);
            }
            else if (easyToolStripMenuItem.Checked)
            {
                SetGameSettings(3, 6, 2, 6);
            }
            else if (hardToolStripMenuItem.Checked)
            {
                SetGameSettings(10, 20, 4, 20);
            }

            progressBarOfGameCompletion.Maximum = clickAmountMaximum;
            
            ProduceWrongButtons();
            SetRandomButtonPosition(ref buttonClickMe);                                  
            labelTickAmountMax.Text = $"Seconds: 0/{tickAmountMaximum.ToString()}";
            labelOfWrongClicks.Text = $"Wrong clicks: 0/{wrongClickAmountMaxiumum}";
            buttonStart.Hide();
            diffuciltyToolStripMenuItem.Visible = false;
            labelTickAmountMax.Visible = true;
            labelOfWrongClicks.Visible = true;         
            gamePanel.Visible = true;
            gameTimer.Interval = 1000;
            gameTimer.Start();
        }
        /// <summary>
        /// Pozwala ustawić podstawowe atrybuty gry.
        /// </summary>
        /// <param name="clickmaxcount"></param>
        /// <param name="tickamountmax"></param>
        /// <param name="wrongclickmax"></param>
        /// <param name="numberofwrongbuttons"></param>
        private void SetGameSettings(int clickmaxcount, int tickamountmax, int wrongclickmax, int numberofwrongbuttons)
        {
            if (clickmaxcount < 0 || tickamountmax < 0 || wrongclickmax < 0 || numberofwrongbuttons < 0)
            {
                return;
            }
            clickAmountMaximum = clickmaxcount;
            tickAmountMaximum = tickamountmax;
            wrongClickAmountMaxiumum = wrongclickmax;
            numberOfWrongButtons = numberofwrongbuttons;
        }

        /// <summary>
        /// Implementuje zachowanie opcji trudności(MenuItems) w stylu RadioButton w zależności od podanego stringa.
        /// easy - uncheck medium, hard
        /// medium - uncheck easy, hard
        /// hard - uncheck easy, medium
        /// </summary>
        /// <param name="difficulty"></param>
        private void DifficultySettingsLikeRadioButtons(string difficulty)
        {
            if(difficulty != "medium" && difficulty != "easy" && difficulty != "hard")
            {
                return;
            }

            if(difficulty == "medium")
            {
                mediumToolStripMenuItem.Checked = true;
                easyToolStripMenuItem.Checked = false;
                hardToolStripMenuItem.Checked = false;
            }
            else if(difficulty == "easy")
            {
                easyToolStripMenuItem.Checked = true;
                mediumToolStripMenuItem.Checked = false;
                hardToolStripMenuItem.Checked = false;
            }
            else if (difficulty == "hard")
            {
                hardToolStripMenuItem.Checked = true;
                easyToolStripMenuItem.Checked = false;
                mediumToolStripMenuItem.Checked = false;
            }

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultySettingsLikeRadioButtons("easy");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultySettingsLikeRadioButtons("medium");
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultySettingsLikeRadioButtons("hard");
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {            
            RandomizeButtonsPositions();
            tickCount++;
            labelTickAmountMax.Text = $"Seconds: {tickCount}/{tickAmountMaximum}";
            buttonClickMe.Enabled = true;
            CheckLoseOrWinConditions();
        }

        /// <summary>
        /// Losuje nową pozycje dla wszystkich przycisków wchodzących w skład gry
        /// </summary>
        private void RandomizeButtonsPositions()
        {
            SetRandomButtonPosition(ref buttonClickMe);
            for (int i = 0; i < listOfWrongButtons.Count; i++)
            {
                var button = listOfWrongButtons.ElementAt(i);
                SetRandomButtonPosition(ref button);
            }
        }

        /// <summary>
        /// Ustawia losowe położenie, podanego jako parametr przycisku, wewnątrz okna.
        /// </summary>
        /// <param name="button"></param>
        private void SetRandomButtonPosition( ref Button button)
        {
            var x = random.Next(gamePanel.Location.X, gamePanel.Width - button.Width);
            var y = random.Next(gamePanel.Location.Y, gamePanel.Height - button.Height);
            var point = new Point(x, y);
            button.Location = point;
        }

        /// <summary>
        /// Wywoływane poprzez naciśnięcie złego przycisku. Liczy liczbę błędnych kliknięć i sprawdza czy nie przekroczono limitu pomyłek.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WrongButtonClick(object sender, EventArgs e)
        {            
            wrongClickCount++;                       
            labelOfWrongClicks.Text = $"Wrong clicks: {wrongClickCount}/{wrongClickAmountMaxiumum}";
            CheckLoseOrWinConditions(); 
        }
        /// <summary>
        /// Tworzy złe przyciski, a ich ilość jest zależna od ustawienia numberOfWrongButtons.
        /// </summary>
        private void ProduceWrongButtons()
        {
            for (int i = 0; i < numberOfWrongButtons; i++)
            {
                Button tempButton = new Button();
                Size tempSize = new Size(10, 10);
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.BackColor = Color.Red;
                tempButton.Size = tempSize;
                tempButton.Click += new System.EventHandler(this.WrongButtonClick);
                gamePanel.Controls.Add(tempButton);
                SetRandomButtonPosition(ref tempButton);
                listOfWrongButtons.Add(tempButton);
            }
        }

        /// <summary>
        /// Sprawdza warunki wygranej bądź przegranej i wyświetla stosowny komunikat.
        /// </summary>
        private void CheckLoseOrWinConditions()
        {
            if (clickCount >= clickAmountMaximum)
            {
               StopGameAndShowMessage($"You win! You have clicked for {clickCount} times and needed for it {tickCount} seconds :D", "You win!");
            }
            else if (wrongClickCount >= wrongClickAmountMaxiumum)
            {
               StopGameAndShowMessage("You lose! Too many wrong clicks... :(", "You lose!");
            }
            else if (tickCount >= tickAmountMaximum)
            {
                StopGameAndShowMessage("You lose! Time has run out :/", "You lose!");
            }            
        }

        /// <summary>
        /// Zatrzymuje gre i wyświetla MessageBox z treścią podaną w parametrze message.
        /// </summary>
        /// <param name="message"></param>
       private void StopGameAndShowMessage(string message, string caption)
        {
            gameTimer.Stop();          
            var result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel);
            if(result == DialogResult.Retry)
            {
                GameRestart();
            }
            else
            {
                Close();
            }
            
        }

        /// <summary>
        /// Przywraca ustawienia gry do początkowych.
        /// </summary>
        private void GameRestart()
        {
            gamePanel.Visible = false;
            diffuciltyToolStripMenuItem.Visible = true;
            labelTickAmountMax.Visible = false;
            labelOfWrongClicks.Visible = false;
            buttonStart.Show();
            gamePanel.Controls.Clear();
            gamePanel.Controls.Add(buttonClickMe);
            DifficultySettingsLikeRadioButtons("medium");
            progressBarOfGameCompletion.Value = 0;       
            listOfWrongButtons.Clear();
            tickCount = 0;
            clickCount = 0;
            wrongClickCount = 0;
        }

    }
}
