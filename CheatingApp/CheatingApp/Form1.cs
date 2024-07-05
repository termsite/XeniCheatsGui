using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/termsite/XeniCheats/releases/download/main/Playspace_joystick_test.dll";

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/termsite/XeniCheats/releases/download/main/PredsSlider.dll";

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/termsite/XeniCheats/releases/download/main/iis_Stupid_Menu.dll";

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
