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
    public partial class panel2 : UserControl
    {
        public panel2()
        {
            InitializeComponent();
        }

        private void panel2_Load(object sender, EventArgs e)
        {

        }

        private void panel2txtBox_TextChanged(object sender, EventArgs e)
        {
            var panel22Input = this.panel2txtBox.Text;
            var parent1 = this.Parent as Form1;
            parent1.DataOne = panel22Input;
        }

        private void panel22txtBox_TextChanged(object sender, EventArgs e)
        {
            var panel22InputTwo = this.panel22txtBox.Text;
            var parent1 = this.Parent as Form1;
            parent1.DataTwo = panel22InputTwo;
        }
    }
}
