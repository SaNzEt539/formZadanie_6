using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duiTask_6
{
    class Arrays
    {
        int[] m_Array;
        int[,] m_dArray;
        public Arrays(int N, int n, int m)
        {
            m_Array = Array(N);
            m_dArray = Array(n, m);
        }
        int[] Array(int n)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            return arr;
        }
        int[,] Array(int n, int m)
        {
            Random rand = new Random();
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
            return arr;
        }
        public string[] Show()
        {
            string[] str = { "", "" };
            foreach (int a in m_Array)
            {
                str[0] += a + " ";
            }
            int i = 0;
            foreach (int a in m_dArray)
            {
                str[1] += a + " ";
                if (i < m_dArray.GetUpperBound(1))
                {
                    i++;
                }
                else
                {
                    str[1] += '\n';
                    i = 0;
                }
            }
            return str;
        }
        public string[] Result(int a, int b)
        {
            string[] str = { "", "" };
            for (int i = 0; i < m_Array.Length; i++)
            {
                if (m_Array[i] < a || m_Array[i] > b)
                {
                    str[0] += i + " ";
                }
            }
            for (int i = 0; i < m_dArray.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < m_dArray.GetUpperBound(1) + 1; j++)
                {
                    if ((m_dArray[i, j] < a) || (m_dArray[i, j] > b))
                    {
                        str[1] += "[" + i + ", " + j + "] ";
                    }
                }
            }
            return str;
        }
    }
}
