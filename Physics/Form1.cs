11using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Physics
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var start = new Form2();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var start = new Form3();
            start.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var start = new Form4();
            start.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var start = new Form5();
            start.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var start = new Form6();
            start.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var start = new Form7();
            start.Show();
        }
    }
}
