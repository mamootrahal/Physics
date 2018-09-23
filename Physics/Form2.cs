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
    public partial class Form2 : Form
    {

        private DataToCalc calcs = new DataToCalc(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcs.InitialDistance = String.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            calcs.InitialSpeed = String.IsNullOrWhiteSpace(textBox4.Text) ? 0 : Convert.ToDouble(textBox4.Text);
            calcs.Acceleration = String.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToDouble(textBox2.Text);
            calcs.Time = String.IsNullOrWhiteSpace(textBox3.Text) ? 0 : Convert.ToDouble(textBox3.Text);
            calcs.Distance = calcs.InitialDistance + calcs.InitialSpeed * calcs.Time +
                             (calcs.Acceleration * (calcs.Time * calcs.Time)) / 2;
            calcs.Speed = calcs.InitialSpeed + calcs.Time * calcs.Acceleration;
            MessageBox.Show("Distance is " + calcs.Distance + " meters and final speed is " + calcs.Speed + " m/s");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
