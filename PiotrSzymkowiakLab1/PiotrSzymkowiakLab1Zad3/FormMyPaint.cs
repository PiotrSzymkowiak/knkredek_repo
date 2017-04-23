using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrSzymkowiakLab1Zad3
{
    public partial class FormMyPaint : Form
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 1);
        Point mouseStartPoint;
        Point mouseEndPoint;
        bool mouseControl = false;
        public FormMyPaint()
        {
            InitializeComponent();
        }

        private void panelForPaintings_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStartPoint = e.Location;
            if (e.Button == MouseButtons.Left) mouseControl = true;
        }

        private void panelForPaintings_MouseUp(object sender, MouseEventArgs e)
        {
            mouseControl = false;           
        }

        private void panelForPaintings_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseControl == true)
            {
                mouseEndPoint = e.Location;
                graphics = panelForPaintings.CreateGraphics();
                graphics.DrawLine(pen, mouseStartPoint, mouseEndPoint);
            }
            mouseStartPoint = mouseEndPoint;
        }

        private void pictureBoxGreenColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
            pictureBoxCurrentColor.BackColor = Color.Green;    
        }

        private void pictureBoxYellowColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
            pictureBoxCurrentColor.BackColor = Color.Yellow;
        }

        private void pictureBoxRedColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            pictureBoxCurrentColor.BackColor = Color.Red;
        }

        private void pictureBoxBlackColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            pictureBoxCurrentColor.BackColor = Color.Black;
        }

        private void pictureBoxWhiteColor_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            pictureBoxCurrentColor.BackColor = Color.White;
        }

        private void pictureBoxCurrentColor_Click(object sender, EventArgs e)
        {
            colorDialogMenu.ShowDialog();
            pen.Color = colorDialogMenu.Color;
            pictureBoxCurrentColor.BackColor = colorDialogMenu.Color;
        }

        private void comboBoxOfPenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {             
            pen.Width = float.Parse(comboBoxOfPenWidth.SelectedItem.ToString());
        }
    }
}
