namespace Zoo
{
    partial class FormZOO
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
            this.dataGridViewZoo = new System.Windows.Forms.DataGridView();
            this.buttonAnimals = new System.Windows.Forms.Button();
            this.buttonSloths = new System.Windows.Forms.Button();
            this.textBoxZookeeperName = new System.Windows.Forms.TextBox();
            this.textBoxZookeeperSurname = new System.Windows.Forms.TextBox();
            this.buttonAddZookeeper = new System.Windows.Forms.Button();
            this.buttonShowAllZookeepers = new System.Windows.Forms.Button();
            this.textBoxFindSloths = new System.Windows.Forms.TextBox();
            this.textBoxAgeLeft = new System.Windows.Forms.TextBox();
            this.textBoxAgeRight = new System.Windows.Forms.TextBox();
            this.labelBetween = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonFindAge = new System.Windows.Forms.Button();
            this.comboBoxSpecies = new System.Windows.Forms.ComboBox();
            this.buttonAddMoreAnimals = new System.Windows.Forms.Button();
            this.labelSlothsName = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelKeeperName = new System.Windows.Forms.Label();
            this.labelKeeperSurname = new System.Windows.Forms.Label();
            this.textBoxAnimalsAmountToAdd = new System.Windows.Forms.TextBox();
            this.labelAmountOfAnimalsToAdd = new System.Windows.Forms.Label();
            this.labelFindSloths = new System.Windows.Forms.Label();
            this.buttonDeleteZookeeper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZoo
            // 
            this.dataGridViewZoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoo.Location = new System.Drawing.Point(25, 12);
            this.dataGridViewZoo.Name = "dataGridViewZoo";
            this.dataGridViewZoo.Size = new System.Drawing.Size(652, 203);
            this.dataGridViewZoo.TabIndex = 0;
            // 
            // buttonAnimals
            // 
            this.buttonAnimals.Location = new System.Drawing.Point(545, 239);
            this.buttonAnimals.Name = "buttonAnimals";
            this.buttonAnimals.Size = new System.Drawing.Size(132, 40);
            this.buttonAnimals.TabIndex = 1;
            this.buttonAnimals.Text = "Zwierzątka";
            this.buttonAnimals.UseVisualStyleBackColor = true;
            this.buttonAnimals.Click += new System.EventHandler(this.buttonAnimals_Click);
            // 
            // buttonSloths
            // 
            this.buttonSloths.Location = new System.Drawing.Point(545, 297);
            this.buttonSloths.Name = "buttonSloths";
            this.buttonSloths.Size = new System.Drawing.Size(132, 40);
            this.buttonSloths.TabIndex = 2;
            this.buttonSloths.Text = "Leniwce";
            this.buttonSloths.UseVisualStyleBackColor = true;
            this.buttonSloths.Click += new System.EventHandler(this.buttonSloths_Click);
            // 
            // textBoxZookeeperName
            // 
            this.textBoxZookeeperName.Location = new System.Drawing.Point(385, 239);
            this.textBoxZookeeperName.Name = "textBoxZookeeperName";
            this.textBoxZookeeperName.Size = new System.Drawing.Size(100, 20);
            this.textBoxZookeeperName.TabIndex = 3;
            // 
            // textBoxZookeeperSurname
            // 
            this.textBoxZookeeperSurname.Location = new System.Drawing.Point(385, 265);
            this.textBoxZookeeperSurname.Name = "textBoxZookeeperSurname";
            this.textBoxZookeeperSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxZookeeperSurname.TabIndex = 4;
            // 
            // buttonAddZookeeper
            // 
            this.buttonAddZookeeper.Location = new System.Drawing.Point(353, 293);
            this.buttonAddZookeeper.Name = "buttonAddZookeeper";
            this.buttonAddZookeeper.Size = new System.Drawing.Size(132, 22);
            this.buttonAddZookeeper.TabIndex = 5;
            this.buttonAddZookeeper.Text = "Dodaj Opiekuna";
            this.buttonAddZookeeper.UseVisualStyleBackColor = true;
            this.buttonAddZookeeper.Click += new System.EventHandler(this.buttonAddZookeeper_Click);
            // 
            // buttonShowAllZookeepers
            // 
            this.buttonShowAllZookeepers.Location = new System.Drawing.Point(545, 354);
            this.buttonShowAllZookeepers.Name = "buttonShowAllZookeepers";
            this.buttonShowAllZookeepers.Size = new System.Drawing.Size(132, 40);
            this.buttonShowAllZookeepers.TabIndex = 6;
            this.buttonShowAllZookeepers.Text = "Opiekunowie";
            this.buttonShowAllZookeepers.UseVisualStyleBackColor = true;
            this.buttonShowAllZookeepers.Click += new System.EventHandler(this.buttonShowAllZookeepers_Click);
            // 
            // textBoxFindSloths
            // 
            this.textBoxFindSloths.Location = new System.Drawing.Point(47, 239);
            this.textBoxFindSloths.Name = "textBoxFindSloths";
            this.textBoxFindSloths.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindSloths.TabIndex = 7;
            this.textBoxFindSloths.TextChanged += new System.EventHandler(this.textBoxFindSloths_TextChanged);
            // 
            // textBoxAgeLeft
            // 
            this.textBoxAgeLeft.Location = new System.Drawing.Point(34, 308);
            this.textBoxAgeLeft.Name = "textBoxAgeLeft";
            this.textBoxAgeLeft.Size = new System.Drawing.Size(32, 20);
            this.textBoxAgeLeft.TabIndex = 9;
            // 
            // textBoxAgeRight
            // 
            this.textBoxAgeRight.Location = new System.Drawing.Point(88, 308);
            this.textBoxAgeRight.Name = "textBoxAgeRight";
            this.textBoxAgeRight.Size = new System.Drawing.Size(32, 20);
            this.textBoxAgeRight.TabIndex = 10;
            // 
            // labelBetween
            // 
            this.labelBetween.AutoSize = true;
            this.labelBetween.Location = new System.Drawing.Point(72, 311);
            this.labelBetween.Name = "labelBetween";
            this.labelBetween.Size = new System.Drawing.Size(10, 13);
            this.labelBetween.TabIndex = 11;
            this.labelBetween.Text = ":";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(60, 284);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(35, 13);
            this.labelAge.TabIndex = 12;
            this.labelAge.Text = "WIEK";
            // 
            // buttonFindAge
            // 
            this.buttonFindAge.Location = new System.Drawing.Point(156, 288);
            this.buttonFindAge.Name = "buttonFindAge";
            this.buttonFindAge.Size = new System.Drawing.Size(132, 40);
            this.buttonFindAge.TabIndex = 13;
            this.buttonFindAge.Text = "Daj leniwca";
            this.buttonFindAge.UseVisualStyleBackColor = true;
            this.buttonFindAge.Click += new System.EventHandler(this.buttonFindAge_Click);
            // 
            // comboBoxSpecies
            // 
            this.comboBoxSpecies.FormattingEnabled = true;
            this.comboBoxSpecies.Location = new System.Drawing.Point(26, 373);
            this.comboBoxSpecies.Name = "comboBoxSpecies";
            this.comboBoxSpecies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecies.TabIndex = 14;
            // 
            // buttonAddMoreAnimals
            // 
            this.buttonAddMoreAnimals.Location = new System.Drawing.Point(353, 362);
            this.buttonAddMoreAnimals.Name = "buttonAddMoreAnimals";
            this.buttonAddMoreAnimals.Size = new System.Drawing.Size(132, 40);
            this.buttonAddMoreAnimals.TabIndex = 16;
            this.buttonAddMoreAnimals.Text = "Dodaj więcej zwierząt";
            this.buttonAddMoreAnimals.UseVisualStyleBackColor = true;
            this.buttonAddMoreAnimals.Click += new System.EventHandler(this.buttonAddMoreAnimals_Click);
            // 
            // labelSlothsName
            // 
            this.labelSlothsName.AutoSize = true;
            this.labelSlothsName.Location = new System.Drawing.Point(12, 242);
            this.labelSlothsName.Name = "labelSlothsName";
            this.labelSlothsName.Size = new System.Drawing.Size(29, 13);
            this.labelSlothsName.TabIndex = 17;
            this.labelSlothsName.Text = "Imię:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(30, 348);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(51, 13);
            this.labelSpecies.TabIndex = 18;
            this.labelSpecies.Text = "Gatunek:";
            // 
            // labelKeeperName
            // 
            this.labelKeeperName.AutoSize = true;
            this.labelKeeperName.Location = new System.Drawing.Point(323, 239);
            this.labelKeeperName.Name = "labelKeeperName";
            this.labelKeeperName.Size = new System.Drawing.Size(29, 13);
            this.labelKeeperName.TabIndex = 19;
            this.labelKeeperName.Text = "Imię:";
            // 
            // labelKeeperSurname
            // 
            this.labelKeeperSurname.AutoSize = true;
            this.labelKeeperSurname.Location = new System.Drawing.Point(323, 272);
            this.labelKeeperSurname.Name = "labelKeeperSurname";
            this.labelKeeperSurname.Size = new System.Drawing.Size(56, 13);
            this.labelKeeperSurname.TabIndex = 20;
            this.labelKeeperSurname.Text = "Nazwisko:";
            // 
            // textBoxAnimalsAmountToAdd
            // 
            this.textBoxAnimalsAmountToAdd.Location = new System.Drawing.Point(156, 373);
            this.textBoxAnimalsAmountToAdd.Multiline = true;
            this.textBoxAnimalsAmountToAdd.Name = "textBoxAnimalsAmountToAdd";
            this.textBoxAnimalsAmountToAdd.Size = new System.Drawing.Size(132, 21);
            this.textBoxAnimalsAmountToAdd.TabIndex = 21;
            // 
            // labelAmountOfAnimalsToAdd
            // 
            this.labelAmountOfAnimalsToAdd.AutoSize = true;
            this.labelAmountOfAnimalsToAdd.Location = new System.Drawing.Point(153, 348);
            this.labelAmountOfAnimalsToAdd.Name = "labelAmountOfAnimalsToAdd";
            this.labelAmountOfAnimalsToAdd.Size = new System.Drawing.Size(129, 13);
            this.labelAmountOfAnimalsToAdd.TabIndex = 22;
            this.labelAmountOfAnimalsToAdd.Text = "Ilość zwierząt do dodania:";
            // 
            // labelFindSloths
            // 
            this.labelFindSloths.AutoSize = true;
            this.labelFindSloths.Location = new System.Drawing.Point(47, 223);
            this.labelFindSloths.Name = "labelFindSloths";
            this.labelFindSloths.Size = new System.Drawing.Size(81, 13);
            this.labelFindSloths.TabIndex = 23;
            this.labelFindSloths.Text = "Szukaj leniwca:";
            // 
            // buttonDeleteZookeeper
            // 
            this.buttonDeleteZookeeper.Location = new System.Drawing.Point(353, 314);
            this.buttonDeleteZookeeper.Name = "buttonDeleteZookeeper";
            this.buttonDeleteZookeeper.Size = new System.Drawing.Size(132, 23);
            this.buttonDeleteZookeeper.TabIndex = 24;
            this.buttonDeleteZookeeper.Text = "Usuń Opiekuna";
            this.buttonDeleteZookeeper.UseVisualStyleBackColor = true;
            this.buttonDeleteZookeeper.Click += new System.EventHandler(this.buttonDeleteZookeeper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 430);
            this.Controls.Add(this.buttonDeleteZookeeper);
            this.Controls.Add(this.labelFindSloths);
            this.Controls.Add(this.labelAmountOfAnimalsToAdd);
            this.Controls.Add(this.textBoxAnimalsAmountToAdd);
            this.Controls.Add(this.labelKeeperSurname);
            this.Controls.Add(this.labelKeeperName);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelSlothsName);
            this.Controls.Add(this.buttonAddMoreAnimals);
            this.Controls.Add(this.comboBoxSpecies);
            this.Controls.Add(this.buttonFindAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelBetween);
            this.Controls.Add(this.textBoxAgeRight);
            this.Controls.Add(this.textBoxAgeLeft);
            this.Controls.Add(this.textBoxFindSloths);
            this.Controls.Add(this.buttonShowAllZookeepers);
            this.Controls.Add(this.buttonAddZookeeper);
            this.Controls.Add(this.textBoxZookeeperSurname);
            this.Controls.Add(this.textBoxZookeeperName);
            this.Controls.Add(this.buttonSloths);
            this.Controls.Add(this.buttonAnimals);
            this.Controls.Add(this.dataGridViewZoo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZoo;
        private System.Windows.Forms.Button buttonAnimals;
        private System.Windows.Forms.Button buttonSloths;
        private System.Windows.Forms.TextBox textBoxZookeeperName;
        private System.Windows.Forms.TextBox textBoxZookeeperSurname;
        private System.Windows.Forms.Button buttonAddZookeeper;
        private System.Windows.Forms.Button buttonShowAllZookeepers;
        private System.Windows.Forms.TextBox textBoxFindSloths;
        private System.Windows.Forms.TextBox textBoxAgeLeft;
        private System.Windows.Forms.TextBox textBoxAgeRight;
        private System.Windows.Forms.Label labelBetween;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonFindAge;
        private System.Windows.Forms.ComboBox comboBoxSpecies;
        private System.Windows.Forms.Button buttonAddMoreAnimals;
        private System.Windows.Forms.Label labelSlothsName;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelKeeperName;
        private System.Windows.Forms.Label labelKeeperSurname;
        private System.Windows.Forms.TextBox textBoxAnimalsAmountToAdd;
        private System.Windows.Forms.Label labelAmountOfAnimalsToAdd;
        private System.Windows.Forms.Label labelFindSloths;
        private System.Windows.Forms.Button buttonDeleteZookeeper;
    }
}

