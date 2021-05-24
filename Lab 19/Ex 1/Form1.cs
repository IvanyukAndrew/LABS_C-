using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                int a = Convert.ToInt32(SR.ReadLine());
                int b = 0;
                for (int i = 0; i < a; i++)
                {
                    int c = Convert.ToInt32(SR.ReadLine());
                    if (c%2==0 )
                    {
                        b++;
                    }
                }
                textBox1.Text = Convert.ToString(b);
                SR.Close();
            }
        }
    }
}
