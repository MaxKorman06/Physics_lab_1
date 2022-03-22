using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e) // Кнопка виходу
        {
            Application.Exit();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label_tabel.Text = "Таблиця";
            label_col1.Text = "value";
            label_col2.Text = "value";
            label_col3.Text = "value";
            label_col4.Text = "value";
            label1_aver.Text = "value";
            label2_aver.Text = "value";
            label3_aver.Text = "value";
            label4_aver.Text = "value";
            label_ro1.Text = "value";
            label_ro2.Text = "value";
            label_ro3.Text = "value";
            label_ro_del1.Text = "value";
            label_ro_del2.Text = "value";
            label_ro_del3.Text = "value";
            label_ro_aver.Text = "value";
            label_ro_del_aver.Text = "value";

            textBox1_col1.Clear();
            textBox1_col2.Clear();
            textBox1_col3.Clear();
            textBox1_col4.Clear();
            textBox2_col1.Clear();
            textBox2_col2.Clear();
            textBox2_col3.Clear();
            textBox2_col4.Clear();
            textBox3_col1.Clear();
            textBox3_col2.Clear();
            textBox3_col3.Clear();
            textBox3_col4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_parallelepiped_Click(object sender, EventArgs e)
        {
            label_tabel.Text = "Таблиця 1. Паралелепіпед.";
            label_col1.Text = "a,";
            label_col2.Text = "b,";
            label_col3.Text = "c,";
            label_col4.Text = "m,";
        }

        private void button_cylinder_Click(object sender, EventArgs e)
        {
            label_tabel.Text = "Таблиця 2. Циліндр.";
            label_col1.Text = "d,";
            label_col2.Text = "h,";
            label_col3.Text = "m,";
            label_col4.Text = "";
        }

        private void button_cylindrical_ring_Click(object sender, EventArgs e)
        {
            label_tabel.Text = "Таблиця 3. Циліндричне кільце.";
            label_col1.Text = "d_зов,";
            label_col2.Text = "d_внут,";
            label_col3.Text = "h,";
            label_col4.Text = "m,";
        }

        private void button_ball_Click(object sender, EventArgs e)
        {
            label_tabel.Text = "Таблиця 4. Куля.";
            label_col1.Text = "d,";
            label_col2.Text = "m,";
            label_col3.Text = "";
            label_col4.Text = "";
        }

        private void button_calculate_parallelepiped_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(textBox1_col1.Text),
                   a2 = Convert.ToDouble(textBox2_col1.Text),
                   a3 = Convert.ToDouble(textBox3_col1.Text),
                   a_aver,
                   b1 = Convert.ToDouble(textBox1_col2.Text),
                   b2 = Convert.ToDouble(textBox2_col2.Text),
                   b3 = Convert.ToDouble(textBox3_col2.Text),
                   b_aver,
                   c1 = Convert.ToDouble(textBox1_col3.Text),
                   c2 = Convert.ToDouble(textBox2_col3.Text),
                   c3 = Convert.ToDouble(textBox3_col3.Text),
                   c_aver,
                   m1 = Convert.ToDouble(textBox1_col4.Text),
                   m2 = Convert.ToDouble(textBox2_col4.Text),
                   m3 = Convert.ToDouble(textBox3_col4.Text),
                   m_aver;

            a_aver = func_aver(a1, a2, a3);
            b_aver = func_aver(b1, b2, b3);
            c_aver = func_aver(c1, c2, c3);
            m_aver = func_aver(m1, m2, m3);

            label1_aver.Text = Convert.ToString(a_aver);
            label2_aver.Text = Convert.ToString(b_aver);
            label3_aver.Text = Convert.ToString(c_aver);
            label4_aver.Text = Convert.ToString(m_aver);
        }

       public static double func_aver(double a, double b, double c)
       { 
            return (a + b + c) / 3;
       }

        public static double ro_parallelepiped(double a, double b, double c, double m)
        {
            return m / (a * b * c);
        }

        public static double ro_cylinder(double d, double h, double m)
        { 
            return (4 * m) / (3.14 * Math.Pow(d, 2) * h);
        }

        public static double ro_cylindrical_ring(double d_on, double d_in, double h, double m)
        {
            return (4 * m) / (3.14 * h * (Math.Pow(d_on, 2) - Math.Pow(d_in, 2)));
        }
        public static double ro_ball (double d, double m)
        {
            return (6 * m) / (3.14 * Math.Pow(d, 3));
        }
    }
    
}
