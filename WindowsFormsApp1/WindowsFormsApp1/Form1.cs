using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            k = dataGridView1.ColumnCount;
            if (k != 0)
                for (int i = 0; i < k; i++)
                    dataGridView1.Columns.RemoveAt(0);
            dataGridView1.Columns.Clear();
            label1.Text = "";

        }
       
        public int[,] func(int [,] array, int M, int N)
        {
            //int M = 5;
            //int N = 5;
            Random rand = new Random();
            //int[,] array = new int[M, N];
            {
                M = array.GetLength(0);
                N = array.GetLength(1);
                dataGridView1.ColumnCount = N;
                dataGridView1.RowCount = M;
                for (int i = 0; i < M; i++)
                {

                    for (int j = 0; j < N; j++)
                    {
                        array[i, j] = rand.Next(-5, 15);
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
            }
            return array;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int M = 5;
            int N = 5;
            int max = 0;
            int i1 = 0;
            int j1 = 0;
            int sum = 0;
            int sum2 = 0;
            int[,] array = new int[M, N];
            int[,] array2 = new int[M, N];
            array2 = func(array, M, N);
            
            //задание 1
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array2[i, j] > max)
                    {
                        max = array2[i, j];
                        i1 = i + 1;
                        j1 = j + 1;
                    }
                }
            }
            
            //задание 2
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum += array2[i, j];
                }
            }

            Random rand = new Random();
            int k = rand.Next(5);
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (j == k)
                        sum2 += array2[i, j];
                    }
                }
            k += 1;

            //задание 3
            string str = "";
            int f = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array2[i, j] % 2 != 0)
                    {
                        f = array2[i, j];
                        str +=f.ToString() + " ";
                    }
                }
            }

            //задание 4
            string str1 = "";
            int f1 = 0;
            for (int i = 0; i < M ; i++)
            {
                for (int j = 0; j < N ; j++)
                {
                    if (i == j)
                    {
                        f1 = array2[i, j];
                        str1 += f1.ToString() + " ";
                    }
                }
            }

            //задание 5
            int minLine = 0;
            int f2 = 0;
            string str2 = "";
            for (int i = 0; i < M; i++)
            {
                minLine = array2[i, 0];
                for (int j = 0; j < N; j++)
                {
                    if (array2[i, j] < minLine)
                    {
                        minLine = array2[i, j];
                    }
                }
            }
            label1.Text = "1) Максимальное число = " + max.ToString() + " Индекс:  " + "[" + i1.ToString() + ";" + j1.ToString() + "]" + "\n2) Сумма элементов первой строки = " + sum.ToString() + "\n    Сумма элементов " + k + " столбца = " + sum2.ToString() + "\n3) Список всех нечетных чисел: " + "\n    " + str + "\n4) Элементы главной диагонали: " + str1 + "\n5) Все существующие минимальные элементы: " + minLine;
        }
    }
}