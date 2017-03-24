namespace PiotrSzymkowiakLab1Zad2
{
    partial class FormZad2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.progressBarOfGameCompletion = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.diffuciltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClickMe = new System.Windows.Forms.Button();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTickAmountMax = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarOfGameCompletion
            // 
            this.progressBarOfGameCompletion.Location = new System.Drawing.Point(12, 27);
            this.progressBarOfGameCompletion.Name = "progressBarOfGameCompletion";
            this.progressBarOfGameCompletion.Size = new System.Drawing.Size(260, 23);
            this.progressBarOfGameCompletion.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(87, 129);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start The Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diffuciltyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // diffuciltyToolStripMenuItem
            // 
            this.diffuciltyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.diffuciltyToolStripMenuItem.Name = "diffuciltyToolStripMenuItem";
            this.diffuciltyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.diffuciltyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.CheckOnClick = true;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Checked = true;
            this.mediumToolStripMenuItem.CheckOnClick = true;
            this.mediumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // buttonClickMe
            // 
            this.buttonClickMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClickMe.Location = new System.Drawing.Point(12, 56);
            this.buttonClickMe.Name = "buttonClickMe";
            this.buttonClickMe.Size = new System.Drawing.Size(10, 10);
            this.buttonClickMe.TabIndex = 3;
            this.buttonClickMe.UseVisualStyleBackColor = true;
            this.buttonClickMe.Click += new System.EventHandler(this.buttonClickMe_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.CheckOnClick = true;
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // labelTickAmountMax
            // 
            this.labelTickAmountMax.AutoSize = true;
            this.labelTickAmountMax.Location = new System.Drawing.Point(248, 9);
            this.labelTickAmountMax.Name = "labelTickAmountMax";
            this.labelTickAmountMax.Size = new System.Drawing.Size(24, 13);
            this.labelTickAmountMax.TabIndex = 4;
            this.labelTickAmountMax.Text = "0/0";
            // 
            // FormZad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelTickAmountMax);
            this.Controls.Add(this.buttonClickMe);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarOfGameCompletion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormZad2";
            this.Text = "FormZad2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ProgressBar progressBarOfGameCompletion;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem diffuciltyToolStripMenuItem;
        private System.Windows.Forms.Button buttonClickMe;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labelTickAmountMax;
    }
}

