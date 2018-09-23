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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private DataToCalc calcs = new DataToCalc(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);



        private void button1_Click(object sender, EventArgs e)
        {
            calcs.Force = String.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            calcs.Mass = String.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDouble(textBox2.Text);
            if (calcs.Mass == 0)
            {
                MessageBox.Show("Error: division by zero");
                Hide();
            }
            else
            {
                calcs.Acceleration = calcs.Force / calcs.Mass;
                MessageBox.Show("Acceleration is " + calcs.Acceleration + " m/s^2");
            }
        }
    }
}
