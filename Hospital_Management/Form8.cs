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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 500);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
