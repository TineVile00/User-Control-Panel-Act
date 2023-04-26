using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class panel1 : UserControl
    {
        public panel1()
        {
            InitializeComponent();
        }

        private void panel1txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            var panel1txtBox = this.panel11txtBox.Text;
            var panel11txtBox = this.panel11txtBox.Text;

            var parent = this.Parent as Form1;

            parent.DataOne = panel1txtBox;
            parent.DataTwo = panel11txtBox;
        }
    }
}
