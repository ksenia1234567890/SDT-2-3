using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace трпо
{
    public partial class ЛабораторнаяРабота3 : Form
    {
        public int[,] matrix;
        public ЛабораторнаяРабота3()
        {
            InitializeComponent();
        }

        public void ЛабораторнаяРабота3_Load(object sender, EventArgs e)
        {
            matrix = new int[12, 12];
            Random n = new Random();
            int i = 0;
            int j = 0;
            for(;i<matrix.Length ;i++,j++ )
            {
                dataGridView1.Rows[i].Cells[j].Value = n.Next(-10,30);
            }
            
        }
        
        public int CountColumn(int[,] araks)
        {
            int a = 13;
            int b = 0;
            int c = 0;
            for (int j = 0; j < araks.GetLength(1); j++)
            {
                for (int i = 0; i < araks.GetLength(0); i++)
                {
                    if (araks[i, j] > -1)
                    {
                        b++;
                    }
                }
                if (a > b)
                {
                    a = b;
                    c = j;

                }
                b = 0;

            }
            return c;
        }
        public void WriteColumn(int[,] araks, int c2)
        {
            int a = 13;
            int b1 = 0;
            for (int j = 0; j < araks.GetLength(1); j++)
            {
                for (int i = 0; i < araks.GetLength(0); i++)
                {
                    if (araks[i, j] > -1)
                    {
                        b1++;
                    }
                }
                if (a == b1 && c2 != j)
                {

                    MessageBox.Show($"Найдено совпадение в {j + 1} столбце (не по индексу)");
                }

                b1 = 0;
            }
        }
        public int CountString(int[,] araks)
        {
            int a1 = -1;
            int d = 0;
            int e = 0;
            for (int i = 0; i < araks.GetLength(0); i++)
            {
                for (int j = 0; j < araks.GetLength(1); j++)
                {
                    if (araks[i, j] < 0)
                    {
                        d++;
                    }
                }
                if (a1 < d)
                {
                    a1 = d;
                    e = i;

                }
                d = 0;

            }
            return e;
        }
        public void WriteString(int[,] araks, int e2)
        {
            int a1 = -1;
            int f = 0;
            for (int i = 0; i < araks.GetLength(0); i++)
            {
                for (int j = 0; j < araks.GetLength(1); j++)
                {
                    if (araks[i, j] < 0)
                    {
                        f++;
                    }
                }
                if (a1 == f && e2 != i)
                {
                    MessageBox.Show($"Найдено совпадение в {i + 1} строке (не по индексу)");
                }
                f = 0;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void b_click(object sender, EventArgs e)
        {
            MessageBox.Show("Поиск номера столбца матрицы, в котором находится наименьшее количество положительных элементов");
            int index = CountColumn(matrix);
            MessageBox.Show($"Номер столбца: {index}");
            WriteColumn(matrix, index);
        }

        private void b2_click(object sender, EventArgs e)
        {
            MessageBox.Show("Поиск номера строки матрицы, в которой находится наибольшее количество отрицательных элементов");
            int index = CountString(matrix);
            MessageBox.Show($"Номер строки: {index}");
            WriteString(matrix, index);
        }

        public void b3_click(object sender, EventArgs e)
        {
            MessageBox.Show("Новое заполнение матрицы");
            matrix = new int[12, 12];
            Random c = new Random();
            int i = 0;
            int j = 0;
            for (; i < matrix.Length; i++, j++)
            {
                dataGridView1.Rows[i].Cells[j].Value = c.Next(-10, 30);
            }
        }
    }
}
