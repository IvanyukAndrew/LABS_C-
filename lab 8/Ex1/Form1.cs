using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб8_Завд1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double upper = Funkcions.getmax(x, y, z) + Funkcions.getmax(x + y, x * y, 4 * z);
            double lower = Funkcions.getmax(Math.Pow(Funkcions.getmax(x + y, x * y, x * x), 2), 7, z * z);
            double answ = upper / lower;
            textBox4.Text = answ.ToString();
        }
    }
}
