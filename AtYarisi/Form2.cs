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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<List<string>> form2data, List<List<string>> form2data2)
        {
            InitializeComponent();

            foreach (var item in form2data)
            {
                var ganyan="";
                var d = item.ToArray();
                for (int i = 0; i < d.Length; i++)
                {
                    ganyan = d[d.Length - 1];
                }
                int kazanılan = Convert.ToInt32(ganyan) * 6;
                item.Add(kazanılan.ToString());
                var k = item.ToArray();
                dataGridView1.Rows.Add(k);
            }

            foreach (var item in form2data2)
            {
                var ganyan = "";
                var e = item.ToArray();
                for (int i = 0; i < e.Length; i++)
                {
                    ganyan = e[e.Length - 1];
                }
                int kaybedilen = Convert.ToInt32(ganyan);
                item.Add(kaybedilen.ToString());
                var kk = item.ToArray();
                dataGridView2.Rows.Add(kk);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }
    }
}
