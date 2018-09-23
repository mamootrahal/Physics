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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private DataToCalc calcs = new DataToCalc(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        private void button1_Click(object sender, EventArgs e)
        {
            calcs.Distance = String.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            calcs.Time = String.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDouble(textBox2.Text);
            if (calcs.Time == 0)
            {
                MessageBox.Show("Error: division by zero");
                Hide();
            }
            else
            {
                calcs.Acceleration = (2 * calcs.Distance) / (calcs.Time * calcs.Time);
                calcs.Speed = calcs.Time * calcs.Acceleration;
                MessageBox.Show("Acceleration is " + calcs.Acceleration + " m/s^2 and final speed is " + calcs.Speed + " m/s");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
