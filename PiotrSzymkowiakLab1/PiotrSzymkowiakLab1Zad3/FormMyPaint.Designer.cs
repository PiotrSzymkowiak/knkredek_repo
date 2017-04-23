namespace PiotrSzymkowiakLab1Zad3
{
    partial class FormMyPaint
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
            this.panelForPaintings = new System.Windows.Forms.Panel();
            this.pictureBoxGreenColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellowColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlackColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxWhiteColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrentColor = new System.Windows.Forms.PictureBox();
            this.colorDialogMenu = new System.Windows.Forms.ColorDialog();
            this.comboBoxOfPenWidth = new System.Windows.Forms.ComboBox();
            this.labelPenSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhiteColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForPaintings
            // 
            this.panelForPaintings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForPaintings.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelForPaintings.Location = new System.Drawing.Point(13, 33);
            this.panelForPaintings.Name = "panelForPaintings";
            this.panelForPaintings.Size = new System.Drawing.Size(259, 216);
            this.panelForPaintings.TabIndex = 0;
            this.panelForPaintings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForPaintings_MouseDown);
            this.panelForPaintings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelForPaintings_MouseMove);
            this.panelForPaintings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelForPaintings_MouseUp);
            // 
            // pictureBoxGreenColor
            // 
            this.pictureBoxGreenColor.BackColor = System.Drawing.Color.Green;
            this.pictureBoxGreenColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGreenColor.Location = new System.Drawing.Point(13, 17);
            this.pictureBoxGreenColor.Name = "pictureBoxGreenColor";
            this.pictureBoxGreenColor.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxGreenColor.TabIndex = 1;
            this.pictureBoxGreenColor.TabStop = false;
            this.pictureBoxGreenColor.Click += new System.EventHandler(this.pictureBoxGreenColor_Click);
            // 
            // pictureBoxYellowColor
            // 
            this.pictureBoxYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxYellowColor.Location = new System.Drawing.Point(29, 17);
            this.pictureBoxYellowColor.Name = "pictureBoxYellowColor";
            this.pictureBoxYellowColor.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxYellowColor.TabIndex = 2;
            this.pictureBoxYellowColor.TabStop = false;
            this.pictureBoxYellowColor.Click += new System.EventHandler(this.pictureBoxYellowColor_Click);
            // 
            // pictureBoxRedColor
            // 
            this.pictureBoxRedColor.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRedColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRedColor.Location = new System.Drawing.Point(45, 17);
            this.pictureBoxRedColor.Name = "pictureBoxRedColor";
            this.pictureBoxRedColor.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxRedColor.TabIndex = 3;
            this.pictureBoxRedColor.TabStop = false;
            this.pictureBoxRedColor.Click += new System.EventHandler(this.pictureBoxRedColor_Click);
            // 
            // pictureBoxBlackColor
            // 
            this.pictureBoxBlackColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBlackColor.Location = new System.Drawing.Point(61, 17);
            this.pictureBoxBlackColor.Name = "pictureBoxBlackColor";
            this.pictureBoxBlackColor.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxBlackColor.TabIndex = 4;
            this.pictureBoxBlackColor.TabStop = false;
            this.pictureBoxBlackColor.Click += new System.EventHandler(this.pictureBoxBlackColor_Click);
            // 
            // pictureBoxWhiteColor
            // 
            this.pictureBoxWhiteColor.BackColor = System.Drawing.Color.White;
            this.pictureBoxWhiteColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWhiteColor.Location = new System.Drawing.Point(78, 17);
            this.pictureBoxWhiteColor.Name = "pictureBoxWhiteColor";
            this.pictureBoxWhiteColor.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxWhiteColor.TabIndex = 5;
            this.pictureBoxWhiteColor.TabStop = false;
            this.pictureBoxWhiteColor.Click += new System.EventHandler(this.pictureBoxWhiteColor_Click);
            // 
            // pictureBoxCurrentColor
            // 
            this.pictureBoxCurrentColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCurrentColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCurrentColor.Location = new System.Drawing.Point(95, 8);
            this.pictureBoxCurrentColor.Name = "pictureBoxCurrentColor";
            this.pictureBoxCurrentColor.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCurrentColor.TabIndex = 6;
            this.pictureBoxCurrentColor.TabStop = false;
            this.pictureBoxCurrentColor.Click += new System.EventHandler(this.pictureBoxCurrentColor_Click);
            // 
            // comboBoxOfPenWidth
            // 
            this.comboBoxOfPenWidth.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxOfPenWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfPenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxOfPenWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxOfPenWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxOfPenWidth.Location = new System.Drawing.Point(236, 6);
            this.comboBoxOfPenWidth.Name = "comboBoxOfPenWidth";
            this.comboBoxOfPenWidth.Size = new System.Drawing.Size(36, 21);
            this.comboBoxOfPenWidth.Sorted = true;
            this.comboBoxOfPenWidth.TabIndex = 7;
            this.comboBoxOfPenWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfPenWidth_SelectedIndexChanged);
            // 
            // labelPenSize
            // 
            this.labelPenSize.AutoSize = true;
            this.labelPenSize.Location = new System.Drawing.Point(180, 9);
            this.labelPenSize.Name = "labelPenSize";
            this.labelPenSize.Size = new System.Drawing.Size(50, 13);
            this.labelPenSize.TabIndex = 8;
            this.labelPenSize.Text = "Pen size:";
            // 
            // FormMyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelPenSize);
            this.Controls.Add(this.comboBoxOfPenWidth);
            this.Controls.Add(this.pictureBoxCurrentColor);
            this.Controls.Add(this.pictureBoxWhiteColor);
            this.Controls.Add(this.pictureBoxBlackColor);
            this.Controls.Add(this.pictureBoxRedColor);
            this.Controls.Add(this.pictureBoxYellowColor);
            this.Controls.Add(this.pictureBoxGreenColor);
            this.Controls.Add(this.panelForPaintings);
            this.Name = "FormMyPaint";
            this.Text = "MyPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhiteColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForPaintings;
        private System.Windows.Forms.PictureBox pictureBoxGreenColor;
        private System.Windows.Forms.PictureBox pictureBoxYellowColor;
        private System.Windows.Forms.PictureBox pictureBoxRedColor;
        private System.Windows.Forms.PictureBox pictureBoxBlackColor;
        private System.Windows.Forms.PictureBox pictureBoxWhiteColor;
        private System.Windows.Forms.PictureBox pictureBoxCurrentColor;
        private System.Windows.Forms.ColorDialog colorDialogMenu;
        private System.Windows.Forms.ComboBox comboBoxOfPenWidth;
        private System.Windows.Forms.Label labelPenSize;
    }
}

