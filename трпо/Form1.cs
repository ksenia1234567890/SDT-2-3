using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace трпо
{
    public partial class Form1 : Form
    {
        public string collect;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }
        public void ButtonClick()
        {
            Random num = new Random();
            double x = num.Next(1, 100);
            double y = num.Next(1, 100);
            double z = num.Next(1, 100);
            string x2 = Convert.ToString(x);
            string y2 = Convert.ToString(y);
            string z2 = Convert.ToString(z);
            tekst.Text = $"Сгенерированы числа x = {x2} , y = {y2} , z = {z2}";
            collect = tekst.Text;
        }
        private void tekst_Click(object sender, EventArgs e)
        {
           
        }

        private void tekst_Leave(object sender, EventArgs e)
        {
            
        }
        private void rb1_enter(object sender, EventArgs e)
        {
            
        }
        public void Numbers(string str, out int x, out int y, out int z)
        {
            string[] numeric = new string[13];
            int index = 0;
            foreach (var i in str.Split(' '))
            {
                numeric[index++] = i;
            }
            x = Convert.ToInt32(numeric[4]);
            y = Convert.ToInt32(numeric[8]);
            z = Convert.ToInt32(numeric[12]);
        }
        private void tekst_enter(object sender, EventArgs e)
        {
            tekst.Text = "Добрый день! Программа посчитает данный пример: " +
               "max(f(x),y,z) + 5 = min(f(x),y). " +
               "Нажмите на кнопку 'Сгенерировать числа', потом выберете функцию внизу.";
        }
        private void rb2_enter(object sender, EventArgs e)
        {
            
        }
        private void rb3_enter(object sender, EventArgs e)
        {
            
        }
        private void rb1_click(object sender, EventArgs e)
        {
            int x, y, z;
            string stroka = collect;
            Numbers(stroka, out x, out y, out z);
            double g = ((Math.Pow(Math.E, x)) - (1 / (Math.Pow(Math.E, x)))) / 2;
            double a = Math.Max(Math.Max(g, y), z) / (Math.Min(g, y)) + 5;
            double r = Math.Round(a);
            string r1 = Convert.ToString(r);
            tekst.Text = $"\nРешение: {r1}";
            
        }
        private void rb2_click(object sender, EventArgs e)
        {
            int x, y, z;
            string stroka = collect;
            Numbers(stroka, out x, out y, out z);
            double g = Math.Pow(x, 2);
            double a = Math.Max(Math.Max(g, y), z) / (Math.Min(g, y)) + 5;
            double r = Math.Round(a);
            string r1 = Convert.ToString(r);
            tekst.Text = $"\nРешение: {r1}";
            
        }
        private void rb3_click(object sender, EventArgs e)
        {
            int x, y, z;
            string stroka = collect;
            Numbers(stroka, out x, out y, out z);
            double g = Math.Pow(Math.E, x);
            double a = Math.Max(Math.Max(g, y), z) / (Math.Min(g, y)) + 5;
            double r = Math.Round(a);
            string r1 = Convert.ToString(r);
            tekst.Text = $"\nРешение: {r1}";
            
        }
    }
}
