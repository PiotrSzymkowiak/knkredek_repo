namespace PiotrSzymkowiakLab3
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
            this.dataGridViewZOO = new System.Windows.Forms.DataGridView();
            this.buttonShowAnimals = new System.Windows.Forms.Button();
            this.buttonShowSloths = new System.Windows.Forms.Button();
            this.textBoxAnimalSpecies = new System.Windows.Forms.TextBox();
            this.textBoxAnimalAmount = new System.Windows.Forms.TextBox();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZOO)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZOO
            // 
            this.dataGridViewZOO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZOO.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewZOO.Name = "dataGridViewZOO";
            this.dataGridViewZOO.Size = new System.Drawing.Size(620, 319);
            this.dataGridViewZOO.TabIndex = 0;
            // 
            // buttonShowAnimals
            // 
            this.buttonShowAnimals.Location = new System.Drawing.Point(12, 366);
            this.buttonShowAnimals.Name = "buttonShowAnimals";
            this.buttonShowAnimals.Size = new System.Drawing.Size(82, 23);
            this.buttonShowAnimals.TabIndex = 1;
            this.buttonShowAnimals.Text = "Show Animals";
            this.buttonShowAnimals.UseVisualStyleBackColor = true;
            this.buttonShowAnimals.Click += new System.EventHandler(this.buttonShowAnimals_Click);
            // 
            // buttonShowSloths
            // 
            this.buttonShowSloths.Location = new System.Drawing.Point(119, 366);
            this.buttonShowSloths.Name = "buttonShowSloths";
            this.buttonShowSloths.Size = new System.Drawing.Size(75, 23);
            this.buttonShowSloths.TabIndex = 2;
            this.buttonShowSloths.Text = "Show Sloths";
            this.buttonShowSloths.UseVisualStyleBackColor = true;
            this.buttonShowSloths.Click += new System.EventHandler(this.buttonShowSloths_Click);
            // 
            // textBoxAnimalSpecies
            // 
            this.textBoxAnimalSpecies.Location = new System.Drawing.Point(674, 114);
            this.textBoxAnimalSpecies.Name = "textBoxAnimalSpecies";
            this.textBoxAnimalSpecies.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnimalSpecies.TabIndex = 3;
            // 
            // textBoxAnimalAmount
            // 
            this.textBoxAnimalAmount.Location = new System.Drawing.Point(674, 140);
            this.textBoxAnimalAmount.Name = "textBoxAnimalAmount";
            this.textBoxAnimalAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnimalAmount.TabIndex = 4;
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(674, 167);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAnimal.TabIndex = 5;
            this.buttonAddAnimal.Text = "Add Animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // FormZOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 412);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.textBoxAnimalAmount);
            this.Controls.Add(this.textBoxAnimalSpecies);
            this.Controls.Add(this.buttonShowSloths);
            this.Controls.Add(this.buttonShowAnimals);
            this.Controls.Add(this.dataGridViewZOO);
            this.Name = "FormZOO";
            this.Text = "FormZOO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZOO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZOO;
        private System.Windows.Forms.Button buttonShowAnimals;
        private System.Windows.Forms.Button buttonShowSloths;
        private System.Windows.Forms.TextBox textBoxAnimalSpecies;
        private System.Windows.Forms.TextBox textBoxAnimalAmount;
        private System.Windows.Forms.Button buttonAddAnimal;
    }
}

