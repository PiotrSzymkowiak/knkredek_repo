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
    public partial class FormLogged : Form
    {
        
        public FormLogged()
        {
            InitializeComponent();
           
        }
        public FormLogged(string labelNameText)
        {
            InitializeComponent();
            labelLoginName.Text = labelNameText;
        }

    }
}
