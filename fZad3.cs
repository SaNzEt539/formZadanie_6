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
    public partial class fZad3 : Form
    {
        public fZad3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(tbM.Text);
                int n = int.Parse(tbN.Text);
                Matrix matrix = new Matrix(m, n);
                labRes.Text = "Результат:\n" + matrix.Show();
            }
            catch (System.FormatException)
            {
                labRes.Text = "Введено что-то не то";
            }
            finally
            {
                labRes.Visible = true;
            }
        }
    }
    class Matrix
    {
        int m;
        int k;
        int[,] matrix;
        public Matrix(int m, int k)
        {
            this.m = m;
            this.k = k;
            matrix = new int[m, k];
            int n = m * k;
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    matrix[i, j] = rand.Next(1, n);
                }
            }
        }
        public string Show()
        {
            string str = String.Empty;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    str += matrix[i, j] + " ";
                }
                str += "\n";
            }
            return str;
        }
    }
}
