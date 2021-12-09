using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duiTask_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fZad1 z1 = new fZad1();
            z1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fZad2 z1 = new fZad2();
            z1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fZad3 z1 = new fZad3();
            z1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fZad4 z1 = new fZad4();
            z1.ShowDialog();
        }
    }
}
