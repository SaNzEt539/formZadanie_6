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
    public partial class fZad2 : Form
    {
        public fZad2()
        {
            InitializeComponent();
        }
        double[] Arr(int N)
        {
            Random rand = new Random();
            double[] arr = new double[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.NextDouble();
            }
            return arr;
        }
        string Res(double[] arr)
        {
            string str = String.Empty;
            double max;
            max = arr[0];
            foreach (double a in arr)
            {
                if (Math.Abs(max) > Math.Abs(a))
                {
                    max = a;
                }
            }
            return max.ToString();
        }
        string Out(double[] arr)
        {
            string str = String.Empty;
            foreach (double a in arr)
            {
                str += a + " ";
            }
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(tbN.Text);
                double[] arr = Arr(N);
                labArr.Text = "Массив: \n" + Out(arr);
                labMax.Text = "Максимальное число: \n" + Res(arr);
            }
            catch(System.FormatException)
            {
                labArr.Text = "Введено что-то не то";
                labMax.Text = "Введено что-то не то";
            }
        }
    }
}
