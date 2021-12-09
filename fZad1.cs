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
    public partial class fZad1 : Form
    {
        public fZad1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A = int.Parse(tbA.Text);
                int B = int.Parse(tbB.Text);
                int N = int.Parse(tbN1.Text);
                int n = int.Parse(tbN.Text);
                int m = int.Parse(tbM.Text);
                Arrays arr = new Arrays(N, n, m);
                string[] str = arr.Show();
                labArray.Text = str[0];
                labDArray.Text = str[1];
                str = arr.Result(A, B);
                labIndex.Text = str[0];
                labDIndex.Text = str[1];
            }
            catch(System.FormatException)
            {
                labArray.Text = "Введено что-то не то";
                labDArray.Text = "Введено что-то не то";
                labDIndex.Text = "Введено что-то не то";
                labIndex.Text = "Введено что-то не то";
            }
        }
    }
}
