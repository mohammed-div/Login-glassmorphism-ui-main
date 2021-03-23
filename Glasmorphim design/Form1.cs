using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glasmorphim_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = Color.FromArgb(100,0,0,0);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2CheckBox1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
