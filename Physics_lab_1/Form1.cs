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
            label_fin_E.Text = "value";
            label_fin_ro.Text = "value";

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
            textBox_v.Clear();
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
                   m_aver,
                   ro1,
                   ro2,
                   ro3,
                   ro_aver,
                   ro_del1,
                   ro_del2,
                   ro_del3,
                   ro_del_aver,
                   v = Convert.ToDouble(textBox_v.Text);

            a1 = variant_func(a1, v);
            a2 = variant_func(a2, v);
            a3 = variant_func(a3, v);

            b1 = variant_func(b1, v);
            b2 = variant_func(b2, v);
            b3 = variant_func(b3, v);

            c1 = variant_func(c1, v);
            c2 = variant_func(c2, v);
            c3 = variant_func(c3, v);

            m1 = variant_func(m1, v);
            m2 = variant_func(m2, v);
            m3 = variant_func(m3, v);

            textBox1_col1.Text = Convert.ToString(a1);
            textBox2_col1.Text = Convert.ToString(a2);
            textBox3_col1.Text = Convert.ToString(a3);

            textBox1_col2.Text = Convert.ToString(b1);
            textBox2_col2.Text = Convert.ToString(b2);
            textBox3_col2.Text = Convert.ToString(b3);

            textBox1_col3.Text = Convert.ToString(c1);
            textBox2_col3.Text = Convert.ToString(c2);
            textBox3_col3.Text = Convert.ToString(c3);

            textBox1_col4.Text = Convert.ToString(m1);
            textBox2_col4.Text = Convert.ToString(m2);
            textBox3_col4.Text = Convert.ToString(m3);

            a_aver = func_aver(a1, a2, a3);
            b_aver = func_aver(b1, b2, b3);
            c_aver = func_aver(c1, c2, c3);
            m_aver = func_aver(m1, m2, m3);

            label1_aver.Text = Convert.ToString(a_aver);
            label2_aver.Text = Convert.ToString(b_aver);
            label3_aver.Text = Convert.ToString(c_aver);
            label4_aver.Text = Convert.ToString(m_aver);

            ro1 = ro_parallelepiped(a1, b1, c1, m1);
            ro2 = ro_parallelepiped(a2, b2, c2, m2);
            ro3 = ro_parallelepiped(a3, b3, c3, m3);
            ro_aver = ro_parallelepiped(a_aver, b_aver, c_aver, m_aver);

            label_ro1.Text = Convert.ToString(ro1);
            label_ro2.Text = Convert.ToString(ro2);
            label_ro3.Text = Convert.ToString(ro3);
            label_ro_aver.Text = Convert.ToString(ro_aver);

            ro_del1 = del_ro(ro_aver, ro1);
            ro_del2 = del_ro(ro_aver, ro2);
            ro_del3 = del_ro(ro_aver, ro3);
            ro_del_aver = func_aver(ro_del1, ro_del2, ro_del3);

            label_ro_del1.Text = Convert.ToString(ro_del1);
            label_ro_del2.Text = Convert.ToString(ro_del2);
            label_ro_del3.Text = Convert.ToString(ro_del3);
            label_ro_del_aver.Text = Convert.ToString(ro_del_aver);

            double E_fin;
            string ro_fin = "ρ = " + ro_del_aver + " ± " + ro_aver;

            E_fin = fin_E_func(ro_aver, ro_del_aver);

            label_fin_ro.Text = ro_fin;
            label_fin_E.Text ="E = " + Convert.ToString(E_fin);        
        }

        private void button_calculate_cylinder_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox1_col1.Text),
                   d2 = Convert.ToDouble(textBox2_col1.Text),
                   d3 = Convert.ToDouble(textBox3_col1.Text),
                   d_aver,
                   h1 = Convert.ToDouble(textBox1_col2.Text),
                   h2 = Convert.ToDouble(textBox2_col2.Text),
                   h3 = Convert.ToDouble(textBox3_col2.Text),
                   h_aver,
                   m1 = Convert.ToDouble(textBox1_col3.Text),
                   m2 = Convert.ToDouble(textBox2_col3.Text),
                   m3 = Convert.ToDouble(textBox3_col3.Text),
                   m_aver,
                   ro1,
                   ro2,
                   ro3,
                   ro_aver,
                   ro_del1,
                   ro_del2,
                   ro_del3,
                   ro_del_aver,
                   v = Convert.ToDouble(textBox_v.Text);

            d1 = variant_func(d1, v);
            d2 = variant_func(d2, v);
            d3 = variant_func(d3, v);

            h1 = variant_func(h1, v);
            h2 = variant_func(h2, v);
            h3 = variant_func(h3, v);

            m1 = variant_func(m1, v);
            m2 = variant_func(m2, v);
            m3 = variant_func(m3, v);

            textBox1_col1.Text = Convert.ToString(d1);
            textBox2_col1.Text = Convert.ToString(d2);
            textBox3_col1.Text = Convert.ToString(d3);

            textBox1_col2.Text = Convert.ToString(h1);
            textBox2_col2.Text = Convert.ToString(h2);
            textBox3_col2.Text = Convert.ToString(h3);

            textBox1_col3.Text = Convert.ToString(m1);
            textBox2_col3.Text = Convert.ToString(m2);
            textBox3_col3.Text = Convert.ToString(m3);

            d_aver = func_aver(d1, d2, d3);
            h_aver = func_aver(h1, h2, h3);
            m_aver = func_aver(m1, m2, m3);

            label1_aver.Text = Convert.ToString(d_aver);
            label2_aver.Text = Convert.ToString(h_aver);
            label3_aver.Text = Convert.ToString(m_aver);

            ro1 = ro_cylinder(d1, h1, m1);
            ro2 = ro_cylinder(d2, h2, m2);
            ro3 = ro_cylinder(d3, h3, m3);
            ro_aver = ro_cylinder(d_aver, h_aver, m_aver);

            label_ro1.Text = Convert.ToString(ro1);
            label_ro2.Text = Convert.ToString(ro2);
            label_ro3.Text = Convert.ToString(ro3);
            label_ro_aver.Text = Convert.ToString(ro_aver);

            ro_del1 = del_ro(ro_aver, ro1);
            ro_del2 = del_ro(ro_aver, ro2);
            ro_del3 = del_ro(ro_aver, ro3);
            ro_del_aver = func_aver(ro_del1, ro_del2, ro_del3);

            label_ro_del1.Text = Convert.ToString(ro_del1);
            label_ro_del2.Text = Convert.ToString(ro_del2);
            label_ro_del3.Text = Convert.ToString(ro_del3);
            label_ro_del_aver.Text = Convert.ToString(ro_del_aver);

            double E_fin;
            string ro_fin = "ρ = " + ro_del_aver + " ± " + ro_aver;

            E_fin = fin_E_func(ro_aver, ro_del_aver);

            label_fin_ro.Text = ro_fin;
            label_fin_E.Text = "E = " + Convert.ToString(E_fin);
        }

        private void button_calculate_cylindrical_ring_Click(object sender, EventArgs e)
        {
            double d_on1 = Convert.ToDouble(textBox1_col1.Text),
                   d_on2 = Convert.ToDouble(textBox2_col1.Text),
                   d_on3 = Convert.ToDouble(textBox3_col1.Text),
                   d_on_aver,
                   d_in1 = Convert.ToDouble(textBox1_col2.Text),
                   d_in2 = Convert.ToDouble(textBox2_col2.Text),
                   d_in3 = Convert.ToDouble(textBox3_col2.Text),
                   d_in_aver,
                   h1 = Convert.ToDouble(textBox1_col3.Text),
                   h2 = Convert.ToDouble(textBox2_col3.Text),
                   h3 = Convert.ToDouble(textBox3_col3.Text),
                   h_aver,
                   m1 = Convert.ToDouble(textBox1_col4.Text),
                   m2 = Convert.ToDouble(textBox2_col4.Text),
                   m3 = Convert.ToDouble(textBox3_col4.Text),
                   m_aver,
                   ro1,
                   ro2,
                   ro3,
                   ro_aver,
                   ro_del1,
                   ro_del2,
                   ro_del3,
                   ro_del_aver,
                   v = Convert.ToDouble(textBox_v.Text);

            d_on1 = variant_func(d_on1, v);
            d_on2 = variant_func(d_on2, v);
            d_on3 = variant_func(d_on3, v);

            d_in1 = variant_func(d_in1, v);
            d_in2 = variant_func(d_in2, v);
            d_in3 = variant_func(d_in3, v);

            h1 = variant_func(h1, v);
            h2 = variant_func(h2, v);
            h3 = variant_func(h3, v);

            m1 = variant_func(m1, v);
            m2 = variant_func(m2, v);
            m3 = variant_func(m3, v);

            textBox1_col1.Text = Convert.ToString(d_on1);
            textBox2_col1.Text = Convert.ToString(d_on2);
            textBox3_col1.Text = Convert.ToString(d_on3);

            textBox1_col2.Text = Convert.ToString(d_in1);
            textBox2_col2.Text = Convert.ToString(d_in2);
            textBox3_col2.Text = Convert.ToString(d_in3);

            textBox1_col3.Text = Convert.ToString(h1);
            textBox2_col3.Text = Convert.ToString(h2);
            textBox3_col3.Text = Convert.ToString(h3);

            textBox1_col4.Text = Convert.ToString(m1);
            textBox2_col4.Text = Convert.ToString(m2);
            textBox3_col4.Text = Convert.ToString(m3);

            d_on_aver = func_aver(d_on1, d_on2, d_on3);
            d_in_aver = func_aver(d_in1, d_in2, d_in3);
            h_aver = func_aver(h1, h2, h3);
            m_aver = func_aver(m1, m2, m3);

            label1_aver.Text = Convert.ToString(d_on_aver);
            label2_aver.Text = Convert.ToString(d_in_aver);
            label3_aver.Text = Convert.ToString(h_aver);
            label4_aver.Text = Convert.ToString(m_aver);

            ro1 = ro_cylindrical_ring(d_on1, d_in1, h1, m1);
            ro2 = ro_cylindrical_ring(d_on2, d_in2, h2, m2);
            ro3 = ro_cylindrical_ring(d_on3, d_in3, h3, m3);
            ro_aver = ro_cylindrical_ring(d_on_aver, d_in_aver, h_aver, m_aver);

            label_ro1.Text = Convert.ToString(ro1);
            label_ro2.Text = Convert.ToString(ro2);
            label_ro3.Text = Convert.ToString(ro3);
            label_ro_aver.Text = Convert.ToString(ro_aver);

            ro_del1 = del_ro(ro_aver, ro1);
            ro_del2 = del_ro(ro_aver, ro2);
            ro_del3 = del_ro(ro_aver, ro3);
            ro_del_aver = func_aver(ro_del1, ro_del2, ro_del3);

            label_ro_del1.Text = Convert.ToString(ro_del1);
            label_ro_del2.Text = Convert.ToString(ro_del2);
            label_ro_del3.Text = Convert.ToString(ro_del3);
            label_ro_del_aver.Text = Convert.ToString(ro_del_aver);

            double E_fin;
            string ro_fin = "ρ = " + ro_del_aver + " ± " + ro_aver;

            E_fin = fin_E_func(ro_aver, ro_del_aver);

            label_fin_ro.Text = ro_fin;
            label_fin_E.Text = "E = " + Convert.ToString(E_fin);
        }

        private void button_calculate_ball_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox1_col1.Text),
                   d2 = Convert.ToDouble(textBox2_col1.Text),
                   d3 = Convert.ToDouble(textBox3_col1.Text),
                   d_aver,
                   m1 = Convert.ToDouble(textBox1_col2.Text),
                   m2 = Convert.ToDouble(textBox2_col2.Text),
                   m3 = Convert.ToDouble(textBox3_col2.Text),
                   m_aver,
                   ro1,
                   ro2,
                   ro3,
                   ro_aver,
                   ro_del1,
                   ro_del2,
                   ro_del3,
                   ro_del_aver,
                   v = Convert.ToDouble(textBox_v.Text);

            d1 = variant_func(d1, v);
            d2 = variant_func(d2, v);
            d3 = variant_func(d3, v);

            m1 = variant_func(m1, v);
            m2 = variant_func(m2, v);
            m3 = variant_func(m3, v);

            textBox1_col1.Text = Convert.ToString(d1);
            textBox2_col1.Text = Convert.ToString(d2);
            textBox3_col1.Text = Convert.ToString(d3);

            textBox1_col2.Text = Convert.ToString(m1);
            textBox2_col2.Text = Convert.ToString(m2);
            textBox3_col2.Text = Convert.ToString(m3);

            d_aver = func_aver(d1, d2, d3);
            m_aver = func_aver(m1, m2, m3);

            label1_aver.Text = Convert.ToString(d_aver);
            label2_aver.Text = Convert.ToString(m_aver);

            ro1 = ro_ball(d1, m1);
            ro2 = ro_ball(d2, m2);
            ro3 = ro_ball(d3, m3);
            ro_aver = ro_ball(d_aver, m_aver);

            label_ro1.Text = Convert.ToString(ro1);
            label_ro2.Text = Convert.ToString(ro2);
            label_ro3.Text = Convert.ToString(ro3);
            label_ro_aver.Text = Convert.ToString(ro_aver);

            ro_del1 = del_ro(ro_aver, ro1);
            ro_del2 = del_ro(ro_aver, ro2);
            ro_del3 = del_ro(ro_aver, ro3);
            ro_del_aver = func_aver(ro_del1, ro_del2, ro_del3);

            label_ro_del1.Text = Convert.ToString(ro_del1);
            label_ro_del2.Text = Convert.ToString(ro_del2);
            label_ro_del3.Text = Convert.ToString(ro_del3);
            label_ro_del_aver.Text = Convert.ToString(ro_del_aver);

            double E_fin;
            string ro_fin = "ρ = " + ro_del_aver + " ± " + ro_aver;

            E_fin = fin_E_func(ro_aver, ro_del_aver);

            label_fin_ro.Text = ro_fin;
            label_fin_E.Text = "E = " + Convert.ToString(E_fin);
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

        public static double ro_ball(double d, double m)
        {
            return (6 * m) / (3.14 * Math.Pow(d, 3));
        }

        public static double del_ro(double aver, double ro)
        {
            return aver - ro;
        }

        public static double variant_func(double a, double v)
        {
            return a + ((a * v) / 100);
        }

        public static double fin_E_func(double ro_aver, double del_ro_aver)
        {
            return (del_ro_aver / ro_aver) * 100;
        }
    }
}