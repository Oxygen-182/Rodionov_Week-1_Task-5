using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_5_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            return Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);

                if (a > b)
                {
                    textBox4.Text += "Параметр a не может быть больше b";
                    return;
                }

                if (h <= 0)
                {
                    textBox4.Text += "Параметр h не может быть меньше или равен нулю";
                    return;
                }

                for (double i = a; a <= b; a += h)
                    try
                    {
                        textBox4.Text += ($"y({a})={f(a)}") + Environment.NewLine;
                    }
                    catch
                    {
                        textBox4.Text += ($"y({a})=error") + Environment.NewLine;
                    }
            }
            catch (FormatException)
            {
                textBox4.Text += ("Неверный формат ввода данных");
            }
            catch
            {
                textBox4.Text += ("Неизвестная ошибка");
            }
        }
    }
}
