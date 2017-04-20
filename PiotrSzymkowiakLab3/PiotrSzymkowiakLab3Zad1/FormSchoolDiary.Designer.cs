namespace PiotrSzymkowiakLab3Zad1
{
    partial class FormSchoolDiary
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
            this.dataGridViewSchoolDiary = new System.Windows.Forms.DataGridView();
            this.buttonAddress = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonComments = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonGrades = new System.Windows.Forms.Button();
            this.buttonKeepers = new System.Windows.Forms.Button();
            this.buttonLessonPlan = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonStudent_Keeper = new System.Windows.Forms.Button();
            this.panelForRawDataButtons = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RawDataButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.textBoxClassDegree = new System.Windows.Forms.TextBox();
            this.labelClassDegree = new System.Windows.Forms.Label();
            this.labelStudentSurname = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.textBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.buttonShowAllTeachers = new System.Windows.Forms.Button();
            this.buttonShowClassLessons = new System.Windows.Forms.Button();
            this.buttonShowStudentsGrades = new System.Windows.Forms.Button();
            this.buttonShowStudentsFromClass = new System.Windows.Forms.Button();
            this.buttonShowAllClasses = new System.Windows.Forms.Button();
            this.panelSearchByName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.textBoxSearchByNameStudents = new System.Windows.Forms.TextBox();
            this.textBoxSearchByNameTeachers = new System.Windows.Forms.TextBox();
            this.textBoxSearchByNameKeepers = new System.Windows.Forms.TextBox();
            this.labelSearchByNameStudents = new System.Windows.Forms.Label();
            this.labelSearchByNameTeachers = new System.Windows.Forms.Label();
            this.labelSearchByNameKeepers = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonAddKeeper = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteKeeper = new System.Windows.Forms.Button();
            this.buttonUpdateKeeper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchoolDiary)).BeginInit();
            this.panelForRawDataButtons.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panelSearchByName.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchoolDiary
            // 
            this.dataGridViewSchoolDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchoolDiary.Location = new System.Drawing.Point(13, 27);
            this.dataGridViewSchoolDiary.Name = "dataGridViewSchoolDiary";
            this.dataGridViewSchoolDiary.Size = new System.Drawing.Size(759, 246);
            this.dataGridViewSchoolDiary.TabIndex = 0;
            // 
            // buttonAddress
            // 
            this.buttonAddress.Location = new System.Drawing.Point(54, 6);
            this.buttonAddress.Name = "buttonAddress";
            this.buttonAddress.Size = new System.Drawing.Size(173, 36);
            this.buttonAddress.TabIndex = 1;
            this.buttonAddress.Text = "Adresy Zamieszkania";
            this.buttonAddress.UseVisualStyleBackColor = true;
            this.buttonAddress.Click += new System.EventHandler(this.buttonAddress_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.Location = new System.Drawing.Point(271, 6);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(173, 36);
            this.buttonClass.TabIndex = 2;
            this.buttonClass.Text = "Klasy";
            this.buttonClass.UseVisualStyleBackColor = true;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // buttonComments
            // 
            this.buttonComments.Location = new System.Drawing.Point(271, 225);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(173, 36);
            this.buttonComments.TabIndex = 3;
            this.buttonComments.Text = "Komentarze";
            this.buttonComments.UseVisualStyleBackColor = true;
            this.buttonComments.Click += new System.EventHandler(this.buttonComments_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.Location = new System.Drawing.Point(271, 152);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Size = new System.Drawing.Size(173, 36);
            this.buttonLessons.TabIndex = 4;
            this.buttonLessons.Text = "Lekcje";
            this.buttonLessons.UseVisualStyleBackColor = true;
            this.buttonLessons.Click += new System.EventHandler(this.buttonLessons_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.Location = new System.Drawing.Point(488, 79);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(173, 36);
            this.buttonTeachers.TabIndex = 5;
            this.buttonTeachers.Text = "Nauczyciele";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonGrades
            // 
            this.buttonGrades.Location = new System.Drawing.Point(488, 152);
            this.buttonGrades.Name = "buttonGrades";
            this.buttonGrades.Size = new System.Drawing.Size(173, 36);
            this.buttonGrades.TabIndex = 6;
            this.buttonGrades.Text = "Oceny";
            this.buttonGrades.UseVisualStyleBackColor = true;
            this.buttonGrades.Click += new System.EventHandler(this.buttonGrades_Click);
            // 
            // buttonKeepers
            // 
            this.buttonKeepers.Location = new System.Drawing.Point(54, 152);
            this.buttonKeepers.Name = "buttonKeepers";
            this.buttonKeepers.Size = new System.Drawing.Size(173, 36);
            this.buttonKeepers.TabIndex = 7;
            this.buttonKeepers.Text = "Opiekunowie";
            this.buttonKeepers.UseVisualStyleBackColor = true;
            this.buttonKeepers.Click += new System.EventHandler(this.buttonKeepers_Click);
            // 
            // buttonLessonPlan
            // 
            this.buttonLessonPlan.Location = new System.Drawing.Point(54, 79);
            this.buttonLessonPlan.Name = "buttonLessonPlan";
            this.buttonLessonPlan.Size = new System.Drawing.Size(173, 36);
            this.buttonLessonPlan.TabIndex = 8;
            this.buttonLessonPlan.Text = "Plan lekcji";
            this.buttonLessonPlan.UseVisualStyleBackColor = true;
            this.buttonLessonPlan.Click += new System.EventHandler(this.buttonLessonPlan_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(271, 79);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(173, 36);
            this.buttonStudents.TabIndex = 9;
            this.buttonStudents.Text = "Uczniowie";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonStudent_Keeper
            // 
            this.buttonStudent_Keeper.Location = new System.Drawing.Point(488, 6);
            this.buttonStudent_Keeper.Name = "buttonStudent_Keeper";
            this.buttonStudent_Keeper.Size = new System.Drawing.Size(173, 36);
            this.buttonStudent_Keeper.TabIndex = 10;
            this.buttonStudent_Keeper.Text = "Uczeń - Opiekun";
            this.buttonStudent_Keeper.UseVisualStyleBackColor = true;
            this.buttonStudent_Keeper.Click += new System.EventHandler(this.buttonStudent_Keeper_Click);
            // 
            // panelForRawDataButtons
            // 
            this.panelForRawDataButtons.Controls.Add(this.buttonAddress);
            this.panelForRawDataButtons.Controls.Add(this.buttonStudent_Keeper);
            this.panelForRawDataButtons.Controls.Add(this.buttonClass);
            this.panelForRawDataButtons.Controls.Add(this.buttonStudents);
            this.panelForRawDataButtons.Controls.Add(this.buttonComments);
            this.panelForRawDataButtons.Controls.Add(this.buttonLessonPlan);
            this.panelForRawDataButtons.Controls.Add(this.buttonLessons);
            this.panelForRawDataButtons.Controls.Add(this.buttonKeepers);
            this.panelForRawDataButtons.Controls.Add(this.buttonTeachers);
            this.panelForRawDataButtons.Controls.Add(this.buttonGrades);
            this.panelForRawDataButtons.Location = new System.Drawing.Point(13, 279);
            this.panelForRawDataButtons.Name = "panelForRawDataButtons";
            this.panelForRawDataButtons.Size = new System.Drawing.Size(759, 270);
            this.panelForRawDataButtons.TabIndex = 11;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RawDataButtonsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // RawDataButtonsToolStripMenuItem
            // 
            this.RawDataButtonsToolStripMenuItem.Name = "RawDataButtonsToolStripMenuItem";
            this.RawDataButtonsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.RawDataButtonsToolStripMenuItem.Text = "Wyświetl przyciski dla tabel";
            this.RawDataButtonsToolStripMenuItem.Click += new System.EventHandler(this.RawDataButtonsToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonUpdateKeeper);
            this.mainPanel.Controls.Add(this.buttonAddKeeper);
            this.mainPanel.Controls.Add(this.buttonDeleteKeeper);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.panelSearchByName);
            this.mainPanel.Location = new System.Drawing.Point(13, 279);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(759, 270);
            this.mainPanel.TabIndex = 13;
            // 
            // textBoxClassDegree
            // 
            this.textBoxClassDegree.Location = new System.Drawing.Point(109, 48);
            this.textBoxClassDegree.Name = "textBoxClassDegree";
            this.textBoxClassDegree.Size = new System.Drawing.Size(185, 20);
            this.textBoxClassDegree.TabIndex = 10;
            // 
            // labelClassDegree
            // 
            this.labelClassDegree.AutoSize = true;
            this.labelClassDegree.Location = new System.Drawing.Point(106, 29);
            this.labelClassDegree.Name = "labelClassDegree";
            this.labelClassDegree.Size = new System.Drawing.Size(73, 13);
            this.labelClassDegree.TabIndex = 9;
            this.labelClassDegree.Text = "Stopień klasy:";
            // 
            // labelStudentSurname
            // 
            this.labelStudentSurname.AutoSize = true;
            this.labelStudentSurname.Location = new System.Drawing.Point(8, 71);
            this.labelStudentSurname.Name = "labelStudentSurname";
            this.labelStudentSurname.Size = new System.Drawing.Size(90, 13);
            this.labelStudentSurname.TabIndex = 8;
            this.labelStudentSurname.Text = "Nazwisko ucznia:";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(22, 29);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(63, 13);
            this.labelStudentName.TabIndex = 7;
            this.labelStudentName.Text = "Imię ucznia:";
            // 
            // textBoxStudentSurname
            // 
            this.textBoxStudentSurname.Location = new System.Drawing.Point(3, 87);
            this.textBoxStudentSurname.Name = "textBoxStudentSurname";
            this.textBoxStudentSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentSurname.TabIndex = 6;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(3, 48);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentName.TabIndex = 5;
            // 
            // buttonShowAllTeachers
            // 
            this.buttonShowAllTeachers.Location = new System.Drawing.Point(109, 86);
            this.buttonShowAllTeachers.Name = "buttonShowAllTeachers";
            this.buttonShowAllTeachers.Size = new System.Drawing.Size(104, 23);
            this.buttonShowAllTeachers.TabIndex = 4;
            this.buttonShowAllTeachers.Text = "Lista nauczycieli";
            this.buttonShowAllTeachers.UseVisualStyleBackColor = true;
            this.buttonShowAllTeachers.Click += new System.EventHandler(this.buttonShowAllTeachers_Click);
            // 
            // buttonShowClassLessons
            // 
            this.buttonShowClassLessons.Location = new System.Drawing.Point(219, 3);
            this.buttonShowClassLessons.Name = "buttonShowClassLessons";
            this.buttonShowClassLessons.Size = new System.Drawing.Size(75, 23);
            this.buttonShowClassLessons.TabIndex = 3;
            this.buttonShowClassLessons.Text = "Lekcje klas";
            this.buttonShowClassLessons.UseVisualStyleBackColor = true;
            this.buttonShowClassLessons.Click += new System.EventHandler(this.buttonShowClassLessons_Click);
            // 
            // buttonShowStudentsGrades
            // 
            this.buttonShowStudentsGrades.Location = new System.Drawing.Point(3, 3);
            this.buttonShowStudentsGrades.Name = "buttonShowStudentsGrades";
            this.buttonShowStudentsGrades.Size = new System.Drawing.Size(100, 23);
            this.buttonShowStudentsGrades.TabIndex = 2;
            this.buttonShowStudentsGrades.Text = "Oceny uczniów";
            this.buttonShowStudentsGrades.UseVisualStyleBackColor = true;
            this.buttonShowStudentsGrades.Click += new System.EventHandler(this.buttonShowStudentsGrades_Click);
            // 
            // buttonShowStudentsFromClass
            // 
            this.buttonShowStudentsFromClass.Location = new System.Drawing.Point(109, 3);
            this.buttonShowStudentsFromClass.Name = "buttonShowStudentsFromClass";
            this.buttonShowStudentsFromClass.Size = new System.Drawing.Size(104, 23);
            this.buttonShowStudentsFromClass.TabIndex = 1;
            this.buttonShowStudentsFromClass.Text = "Lista uczniów klas";
            this.buttonShowStudentsFromClass.UseVisualStyleBackColor = true;
            this.buttonShowStudentsFromClass.Click += new System.EventHandler(this.buttonShowStudentsFromClass_Click);
            // 
            // buttonShowAllClasses
            // 
            this.buttonShowAllClasses.Location = new System.Drawing.Point(219, 87);
            this.buttonShowAllClasses.Name = "buttonShowAllClasses";
            this.buttonShowAllClasses.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAllClasses.TabIndex = 0;
            this.buttonShowAllClasses.Text = "Lista klas";
            this.buttonShowAllClasses.UseVisualStyleBackColor = true;
            this.buttonShowAllClasses.Click += new System.EventHandler(this.buttonShowAllClasses_Click);
            // 
            // panelSearchByName
            // 
            this.panelSearchByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchByName.Controls.Add(this.labelSearchByNameKeepers);
            this.panelSearchByName.Controls.Add(this.labelSearchByNameTeachers);
            this.panelSearchByName.Controls.Add(this.labelSearchByNameStudents);
            this.panelSearchByName.Controls.Add(this.textBoxSearchByNameKeepers);
            this.panelSearchByName.Controls.Add(this.textBoxSearchByNameTeachers);
            this.panelSearchByName.Controls.Add(this.textBoxSearchByNameStudents);
            this.panelSearchByName.Controls.Add(this.labelSearchByName);
            this.panelSearchByName.Location = new System.Drawing.Point(483, 3);
            this.panelSearchByName.Name = "panelSearchByName";
            this.panelSearchByName.Size = new System.Drawing.Size(273, 264);
            this.panelSearchByName.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonShowStudentsGrades);
            this.panel1.Controls.Add(this.buttonShowAllClasses);
            this.panel1.Controls.Add(this.textBoxClassDegree);
            this.panel1.Controls.Add(this.buttonShowStudentsFromClass);
            this.panel1.Controls.Add(this.labelClassDegree);
            this.panel1.Controls.Add(this.buttonShowClassLessons);
            this.panel1.Controls.Add(this.labelStudentSurname);
            this.panel1.Controls.Add(this.buttonShowAllTeachers);
            this.panel1.Controls.Add(this.labelStudentName);
            this.panel1.Controls.Add(this.textBoxStudentName);
            this.panel1.Controls.Add(this.textBoxStudentSurname);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 118);
            this.panel1.TabIndex = 12;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchByName.Location = new System.Drawing.Point(48, 3);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(187, 25);
            this.labelSearchByName.TabIndex = 0;
            this.labelSearchByName.Text = "Szukaj po imieniu:";
            // 
            // textBoxSearchByNameStudents
            // 
            this.textBoxSearchByNameStudents.Location = new System.Drawing.Point(5, 64);
            this.textBoxSearchByNameStudents.Name = "textBoxSearchByNameStudents";
            this.textBoxSearchByNameStudents.Size = new System.Drawing.Size(265, 20);
            this.textBoxSearchByNameStudents.TabIndex = 1;
            this.textBoxSearchByNameStudents.TextChanged += new System.EventHandler(this.textBoxSearchByNameStudents_TextChanged);
            // 
            // textBoxSearchByNameTeachers
            // 
            this.textBoxSearchByNameTeachers.Location = new System.Drawing.Point(5, 128);
            this.textBoxSearchByNameTeachers.Name = "textBoxSearchByNameTeachers";
            this.textBoxSearchByNameTeachers.Size = new System.Drawing.Size(265, 20);
            this.textBoxSearchByNameTeachers.TabIndex = 2;
            this.textBoxSearchByNameTeachers.TextChanged += new System.EventHandler(this.textBoxSearchByNameTeachers_TextChanged);
            // 
            // textBoxSearchByNameKeepers
            // 
            this.textBoxSearchByNameKeepers.Location = new System.Drawing.Point(4, 192);
            this.textBoxSearchByNameKeepers.Name = "textBoxSearchByNameKeepers";
            this.textBoxSearchByNameKeepers.Size = new System.Drawing.Size(266, 20);
            this.textBoxSearchByNameKeepers.TabIndex = 3;
            this.textBoxSearchByNameKeepers.TextChanged += new System.EventHandler(this.textBoxSearchByNameKeepers_TextChanged);
            // 
            // labelSearchByNameStudents
            // 
            this.labelSearchByNameStudents.AutoSize = true;
            this.labelSearchByNameStudents.Location = new System.Drawing.Point(5, 45);
            this.labelSearchByNameStudents.Name = "labelSearchByNameStudents";
            this.labelSearchByNameStudents.Size = new System.Drawing.Size(59, 13);
            this.labelSearchByNameStudents.TabIndex = 4;
            this.labelSearchByNameStudents.Text = "Uczniowie:";
            // 
            // labelSearchByNameTeachers
            // 
            this.labelSearchByNameTeachers.AutoSize = true;
            this.labelSearchByNameTeachers.Location = new System.Drawing.Point(5, 105);
            this.labelSearchByNameTeachers.Name = "labelSearchByNameTeachers";
            this.labelSearchByNameTeachers.Size = new System.Drawing.Size(68, 13);
            this.labelSearchByNameTeachers.TabIndex = 5;
            this.labelSearchByNameTeachers.Text = "Nauczyciele:";
            // 
            // labelSearchByNameKeepers
            // 
            this.labelSearchByNameKeepers.AutoSize = true;
            this.labelSearchByNameKeepers.Location = new System.Drawing.Point(5, 173);
            this.labelSearchByNameKeepers.Name = "labelSearchByNameKeepers";
            this.labelSearchByNameKeepers.Size = new System.Drawing.Size(72, 13);
            this.labelSearchByNameKeepers.TabIndex = 6;
            this.labelSearchByNameKeepers.Text = "Opiekunowie:";
            // 
            // buttonAddKeeper
            // 
            this.buttonAddKeeper.Location = new System.Drawing.Point(3, 144);
            this.buttonAddKeeper.Name = "buttonAddKeeper";
            this.buttonAddKeeper.Size = new System.Drawing.Size(150, 52);
            this.buttonAddKeeper.TabIndex = 13;
            this.buttonAddKeeper.Text = "Dodaj opiekuna";
            this.buttonAddKeeper.UseVisualStyleBackColor = true;
            this.buttonAddKeeper.Click += new System.EventHandler(this.buttonAddKeeper_Click);
            // 
            // buttonDeleteKeeper
            // 
            this.buttonDeleteKeeper.Location = new System.Drawing.Point(3, 209);
            this.buttonDeleteKeeper.Name = "buttonDeleteKeeper";
            this.buttonDeleteKeeper.Size = new System.Drawing.Size(150, 52);
            this.buttonDeleteKeeper.TabIndex = 13;
            this.buttonDeleteKeeper.Text = "Usuń opiekuna";
            this.buttonDeleteKeeper.UseVisualStyleBackColor = true;
            this.buttonDeleteKeeper.Click += new System.EventHandler(this.buttonDeleteKeeper_Click);
            // 
            // buttonUpdateKeeper
            // 
            this.buttonUpdateKeeper.Location = new System.Drawing.Point(152, 144);
            this.buttonUpdateKeeper.Name = "buttonUpdateKeeper";
            this.buttonUpdateKeeper.Size = new System.Drawing.Size(150, 52);
            this.buttonUpdateKeeper.TabIndex = 14;
            this.buttonUpdateKeeper.Text = "Edytuj opiekuna";
            this.buttonUpdateKeeper.UseVisualStyleBackColor = true;
            this.buttonUpdateKeeper.Click += new System.EventHandler(this.buttonUpdateKeeper_Click);
            // 
            // FormSchoolDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewSchoolDiary);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelForRawDataButtons);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormSchoolDiary";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchoolDiary)).EndInit();
            this.panelForRawDataButtons.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panelSearchByName.ResumeLayout(false);
            this.panelSearchByName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchoolDiary;
        private System.Windows.Forms.Button buttonAddress;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Button buttonComments;
        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonGrades;
        private System.Windows.Forms.Button buttonKeepers;
        private System.Windows.Forms.Button buttonLessonPlan;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonStudent_Keeper;
        private System.Windows.Forms.Panel panelForRawDataButtons;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RawDataButtonsToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonShowAllClasses;
        private System.Windows.Forms.Button buttonShowAllTeachers;
        private System.Windows.Forms.Button buttonShowClassLessons;
        private System.Windows.Forms.Button buttonShowStudentsGrades;
        private System.Windows.Forms.Button buttonShowStudentsFromClass;
        private System.Windows.Forms.TextBox textBoxStudentSurname;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxClassDegree;
        private System.Windows.Forms.Label labelClassDegree;
        private System.Windows.Forms.Label labelStudentSurname;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSearchByName;
        private System.Windows.Forms.Label labelSearchByNameKeepers;
        private System.Windows.Forms.Label labelSearchByNameTeachers;
        private System.Windows.Forms.Label labelSearchByNameStudents;
        private System.Windows.Forms.TextBox textBoxSearchByNameKeepers;
        private System.Windows.Forms.TextBox textBoxSearchByNameTeachers;
        private System.Windows.Forms.TextBox textBoxSearchByNameStudents;
        private System.Windows.Forms.Label labelSearchByName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonAddKeeper;
        private System.Windows.Forms.Button buttonDeleteKeeper;
        private System.Windows.Forms.Button buttonUpdateKeeper;
    }
}

