using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sıra = (textBox1.Text).Split(textBox2.Text.ToCharArray());

            int[] a = Array.ConvertAll(sıra, s => int.Parse(s));

            Array.Sort(a);

            int temp = 0;
            if (temp == 0)
            {
                textBox1.Clear();
                foreach (int myInt in a)
                {
                    textBox1.AppendText(myInt.ToString() + textBox2.Text.ToString());
                } 
            }    
        }
    }
}
