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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        DataToCalc calcs = new DataToCalc(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        private void button1_Click(object sender, EventArgs e)
        {
            calcs.Distance = String.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            calcs.Acceleration = String.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDouble(textBox2.Text);
            if (calcs.Acceleration == 0)
            {
                MessageBox.Show("Error: division by zero");
                Hide();
            }
            else
            {
                calcs.Time = Math.Sqrt((2 * calcs.Distance) / calcs.Acceleration);
                calcs.Speed = calcs.Time * calcs.Acceleration;
                MessageBox.Show("Time is " + calcs.Time + " seconds and final speed is " + calcs.Speed + " m/s");
            }
        }
    }
}
