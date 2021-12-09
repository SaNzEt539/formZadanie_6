using System;
using System.Collections;
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
    public partial class fZad4 : Form
    {
        public fZad4()
        {
            InitializeComponent();
        }
        static string ToStr(ArrayList aL)
        {
            string str = String.Empty;
            for (int i = 0; i < aL.Count; i++)
            {
                str += aL[i] + " ";
            }
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(tbN.Text);
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
                Massive mas = new Massive(N);
                labMas.Text = mas.Show();
                labRes.Text = ToStr(mas.ShowInterval(a, b));
            }
            catch(System.FormatException)
            {
                labRes.Text = "Введено что-то не то";
                labMas.Text = "Введено что-то не то";
            }
            finally
            {
                labRes.Visible = true;
                labMas.Visible = true;
            }
        }
    }
    class Massive
    {
        int[][] arr;
        Random rand = new Random();
        public Massive(int n)
        {
            arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[rand.Next(1, 10)];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(-100, 100);
                }
            }
        }
        public string Show()
        {
            string str = String.Empty;
            foreach (int[] a in arr)
            {
                foreach (int j in a)
                {
                    str += j + " ";
                }
                str += "\n";
            }
            return str;
        }
        public ArrayList ShowInterval(int a, int b)
        {
            ArrayList aList = new ArrayList();
            foreach (int[] i in arr)
            {
                foreach (int j in i)
                {
                    if (j < a || j > b)
                    {
                        aList.Add(j);
                    }
                }
            }
            return aList;
        }
    }
}
