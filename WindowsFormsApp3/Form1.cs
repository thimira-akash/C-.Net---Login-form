using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "Admin" && textBox2.Text == "123456")
            {
                //Create an object from Homepage class
                Homepage homepage = new Homepage();
                //Display the Homepage form after the clicking login button
                homepage.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Incorrect Username or Password","Alert",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
