using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private DataToCalc calcs = new DataToCalc(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        private void button1_Click(object sender, EventArgs e)
        {
            calcs.Force = String.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            calcs.Acceleration = String.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDouble(textBox2.Text);
            if (calcs.Acceleration == 0)
            {
                MessageBox.Show("Error: division by zero");
                Hide();
            }
            else
            {
                calcs.Mass = calcs.Force / calcs.Acceleration;
                MessageBox.Show("Mass is " + calcs.Mass + " kilos");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
