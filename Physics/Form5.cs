using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{

    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private DataToCalc calcs = new DataToCalc(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        private void button1_Click(object sender, EventArgs e)
        {
            calcs.Mass = String.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            calcs.Acceleration = String.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDouble(textBox2.Text);
            calcs.Force = calcs.Mass * calcs.Acceleration;
            MessageBox.Show("Force is " + calcs.Force + " newtons");
        }
    }
}
