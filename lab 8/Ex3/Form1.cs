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

        private void button1_Click(object sender, EventArgs e)
        {
            int x0 = 0;
            int x2 = 9;
            int x1 = 9;
            Console.Write("n=");
            int n = Convert.ToInt32(textBox1.Text);
            int xn = 0;
            for (int i = 3; i < n + 1; i++)
            {
                xn = x2 + 4 * x0;
                x0 = x1;
                x1 = x2;
                x2 = xn;
            }
            textBox2.Text = xn.ToString();
        }
    }
}
