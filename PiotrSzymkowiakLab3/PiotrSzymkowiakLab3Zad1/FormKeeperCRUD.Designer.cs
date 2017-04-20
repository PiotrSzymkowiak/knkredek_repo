namespace PiotrSzymkowiakLab3Zad1
{
    partial class FormKeeperCRUD
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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panelDeleteKeeper = new System.Windows.Forms.Panel();
            this.panelUpdateKeeper = new System.Windows.Forms.Panel();
            this.textBoxUpdateID = new System.Windows.Forms.TextBox();
            this.labelUpdateID = new System.Windows.Forms.Label();
            this.labelUpdatePESEL = new System.Windows.Forms.Label();
            this.labelUpdateSurname = new System.Windows.Forms.Label();
            this.labelUpdateName = new System.Windows.Forms.Label();
            this.textBoxUpdatePESEL = new System.Windows.Forms.TextBox();
            this.textBoxUpdateSurname = new System.Windows.Forms.TextBox();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewUpdateKeeper = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewDeleteKeeper = new System.Windows.Forms.DataGridView();
            this.panelAdd.SuspendLayout();
            this.panelDeleteKeeper.SuspendLayout();
            this.panelUpdateKeeper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteKeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Controls.Add(this.labelPESEL);
            this.panelAdd.Controls.Add(this.labelSurname);
            this.panelAdd.Controls.Add(this.labelName);
            this.panelAdd.Controls.Add(this.textBoxPESEL);
            this.panelAdd.Controls.Add(this.textBoxSurname);
            this.panelAdd.Controls.Add(this.textBoxName);
            this.panelAdd.Controls.Add(this.buttonConfirm);
            this.panelAdd.Location = new System.Drawing.Point(12, 11);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(260, 237);
            this.panelAdd.TabIndex = 0;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(27, 103);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(44, 13);
            this.labelPESEL.TabIndex = 7;
            this.labelPESEL.Text = "PESEL:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(27, 59);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(27, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Imię:";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(130, 97);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(130, 53);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(66, 159);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(121, 43);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Zatwierdź";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // panelDeleteKeeper
            // 
            this.panelDeleteKeeper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeleteKeeper.Controls.Add(this.labelID);
            this.panelDeleteKeeper.Controls.Add(this.textBoxID);
            this.panelDeleteKeeper.Controls.Add(this.buttonDelete);
            this.panelDeleteKeeper.Controls.Add(this.dataGridViewDeleteKeeper);
            this.panelDeleteKeeper.Location = new System.Drawing.Point(335, 11);
            this.panelDeleteKeeper.Name = "panelDeleteKeeper";
            this.panelDeleteKeeper.Size = new System.Drawing.Size(260, 237);
            this.panelDeleteKeeper.TabIndex = 8;
            // 
            // panelUpdateKeeper
            // 
            this.panelUpdateKeeper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateKeeper.Controls.Add(this.textBoxUpdateID);
            this.panelUpdateKeeper.Controls.Add(this.labelUpdateID);
            this.panelUpdateKeeper.Controls.Add(this.labelUpdatePESEL);
            this.panelUpdateKeeper.Controls.Add(this.labelUpdateSurname);
            this.panelUpdateKeeper.Controls.Add(this.labelUpdateName);
            this.panelUpdateKeeper.Controls.Add(this.textBoxUpdatePESEL);
            this.panelUpdateKeeper.Controls.Add(this.textBoxUpdateSurname);
            this.panelUpdateKeeper.Controls.Add(this.textBoxUpdateName);
            this.panelUpdateKeeper.Controls.Add(this.buttonUpdate);
            this.panelUpdateKeeper.Controls.Add(this.dataGridViewUpdateKeeper);
            this.panelUpdateKeeper.Location = new System.Drawing.Point(658, 11);
            this.panelUpdateKeeper.Name = "panelUpdateKeeper";
            this.panelUpdateKeeper.Size = new System.Drawing.Size(260, 237);
            this.panelUpdateKeeper.TabIndex = 4;
            // 
            // textBoxUpdateID
            // 
            this.textBoxUpdateID.Location = new System.Drawing.Point(47, 150);
            this.textBoxUpdateID.Name = "textBoxUpdateID";
            this.textBoxUpdateID.Size = new System.Drawing.Size(32, 20);
            this.textBoxUpdateID.TabIndex = 9;
            // 
            // labelUpdateID
            // 
            this.labelUpdateID.AutoSize = true;
            this.labelUpdateID.Location = new System.Drawing.Point(20, 153);
            this.labelUpdateID.Name = "labelUpdateID";
            this.labelUpdateID.Size = new System.Drawing.Size(21, 13);
            this.labelUpdateID.TabIndex = 8;
            this.labelUpdateID.Text = "ID:";
            // 
            // labelUpdatePESEL
            // 
            this.labelUpdatePESEL.AutoSize = true;
            this.labelUpdatePESEL.Location = new System.Drawing.Point(96, 209);
            this.labelUpdatePESEL.Name = "labelUpdatePESEL";
            this.labelUpdatePESEL.Size = new System.Drawing.Size(44, 13);
            this.labelUpdatePESEL.TabIndex = 7;
            this.labelUpdatePESEL.Text = "PESEL:";
            // 
            // labelUpdateSurname
            // 
            this.labelUpdateSurname.AutoSize = true;
            this.labelUpdateSurname.Location = new System.Drawing.Point(96, 181);
            this.labelUpdateSurname.Name = "labelUpdateSurname";
            this.labelUpdateSurname.Size = new System.Drawing.Size(56, 13);
            this.labelUpdateSurname.TabIndex = 6;
            this.labelUpdateSurname.Text = "Nazwisko:";
            // 
            // labelUpdateName
            // 
            this.labelUpdateName.AutoSize = true;
            this.labelUpdateName.Location = new System.Drawing.Point(96, 153);
            this.labelUpdateName.Name = "labelUpdateName";
            this.labelUpdateName.Size = new System.Drawing.Size(29, 13);
            this.labelUpdateName.TabIndex = 5;
            this.labelUpdateName.Text = "Imię:";
            // 
            // textBoxUpdatePESEL
            // 
            this.textBoxUpdatePESEL.Location = new System.Drawing.Point(157, 202);
            this.textBoxUpdatePESEL.Name = "textBoxUpdatePESEL";
            this.textBoxUpdatePESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdatePESEL.TabIndex = 4;
            // 
            // textBoxUpdateSurname
            // 
            this.textBoxUpdateSurname.Location = new System.Drawing.Point(157, 176);
            this.textBoxUpdateSurname.Name = "textBoxUpdateSurname";
            this.textBoxUpdateSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateSurname.TabIndex = 3;
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(157, 150);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateName.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(4, 181);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Zatwierdź";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewUpdateKeeper
            // 
            this.dataGridViewUpdateKeeper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdateKeeper.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewUpdateKeeper.Name = "dataGridViewUpdateKeeper";
            this.dataGridViewUpdateKeeper.Size = new System.Drawing.Size(257, 138);
            this.dataGridViewUpdateKeeper.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(63, 151);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(68, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "Identyfikator:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(66, 167);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(112, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(66, 193);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 41);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewDeleteKeeper
            // 
            this.dataGridViewDeleteKeeper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteKeeper.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewDeleteKeeper.Name = "dataGridViewDeleteKeeper";
            this.dataGridViewDeleteKeeper.Size = new System.Drawing.Size(253, 136);
            this.dataGridViewDeleteKeeper.TabIndex = 0;
            // 
            // FormKeeperCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 261);
            this.Controls.Add(this.panelUpdateKeeper);
            this.Controls.Add(this.panelDeleteKeeper);
            this.Controls.Add(this.panelAdd);
            this.Name = "FormKeeperCRUD";
            this.Text = "Keeper options";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelDeleteKeeper.ResumeLayout(false);
            this.panelDeleteKeeper.PerformLayout();
            this.panelUpdateKeeper.ResumeLayout(false);
            this.panelUpdateKeeper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteKeeper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panelDeleteKeeper;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewDeleteKeeper;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panelUpdateKeeper;
        private System.Windows.Forms.TextBox textBoxUpdateID;
        private System.Windows.Forms.Label labelUpdateID;
        private System.Windows.Forms.Label labelUpdatePESEL;
        private System.Windows.Forms.Label labelUpdateSurname;
        private System.Windows.Forms.Label labelUpdateName;
        private System.Windows.Forms.TextBox textBoxUpdatePESEL;
        private System.Windows.Forms.TextBox textBoxUpdateSurname;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewUpdateKeeper;
    }
}