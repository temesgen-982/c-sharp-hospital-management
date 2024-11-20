using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 500);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 180;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if(username[0]=='p' || username[0] == 'P')
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if(username[0] == 'd' || username[0] == 'D')
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
