using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string DataOne {
            set {
                datainput1Box.Text = value;
            }
        }
        public string DataTwo {
            set {
                dataInput2Box.Text = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel1Btn_Click(object sender, EventArgs e)
        {
            panel11.Show();
            panel11.BringToFront();
            panel21.Hide();
        }

        private void Panel2Btn_Click(object sender, EventArgs e)
        {
            panel21.Show();
            panel21.BringToFront();
            panel11.Hide();
        }
    }
}
