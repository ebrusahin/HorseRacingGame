using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int deger = 0;

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            deger = Convert.ToInt32(textBox1.Text);
            Close();
        }
      
    }
}
