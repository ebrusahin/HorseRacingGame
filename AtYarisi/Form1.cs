using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int[] counts = new int[6];
        int ileri = 0;
        public int count =0;
        int yarisSayac = 0;
        List<string> sonuclar = new List<string>();  //yarış sonuçlarının tutulduğu liste. Winners metotu içinde ekleniyor.
        List<List<string>> form2data = new List<List<string>>();
        List<List<string>> form2data2 = new List<List<string>>();
        List<List<string>> kuponlar = new List<List<string>>();
        List<string> karsilastirma = new List<string>();


        private void Form1_Load(object sender, EventArgs e)
        {
     
            button3.Font = new Font("Arial", 12.25F, FontStyle.Bold);
            this.BackColor = Color.White;
            button1.Font = new Font("Arial", 12.25F, FontStyle.Bold);
            this.BackColor = Color.White;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            //  pictureBox1.ImageLocation = @"C:\Users\Lenovo\Desktop\pp\AtYarisi\gifs\horse1.gif";
            pictureBox1.ImageLocation = @"C:\Users\Öğle\Desktop\pp\AtYarisi\gifs\horse1.gif";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox2.ImageLocation = @"C:\Users\Lenovo\Desktop\pp\AtYarisi\gifs\horse2.gif";
            pictureBox2.ImageLocation = @"C:\Users\Öğle\Desktop\pp\AtYarisi\gifs\horse2.gif";

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox3.ImageLocation = @"C:\Users\Lenovo\Desktop\pp\AtYarisi\gifs\horse3.gif";
            pictureBox3.ImageLocation = @"C:\Users\Öğle\Desktop\pp\AtYarisi\gifs\horse3.gif";

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox4.ImageLocation = @"C:\Users\Lenovo\Desktop\pp\AtYarisi\gifs\horse4.gif";
            pictureBox4.ImageLocation = @"C:\Users\Öğle\Desktop\pp\AtYarisi\gifs\horse4.gif";

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pictureBox5.ImageLocation = @"C:\Users\Lenovo\Desktop\pp\AtYarisi\gifs\horse5.gif";
            pictureBox5.ImageLocation = @"C:\Users\Öğle\Desktop\pp\AtYarisi\gifs\horse5.gif";

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox6.ImageLocation = @"C:\Users\Lenovo\Desktop\pp\AtYarisi\gifs\Horse6.gif";
            pictureBox6.ImageLocation = @"C:\Users\Öğle\Desktop\pp\AtYarisi\gifs\Horse6.gif";

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            timer1.Enabled = false; timer4.Enabled = false;
            timer1.Interval = 100; timer4.Interval = 100;
            timer2.Enabled = false; timer5.Enabled = false;
            timer2.Interval = 100; timer5.Interval = 100;
            timer3.Enabled = false; timer6.Enabled = false;
            timer3.Interval = 100; timer6.Interval = 100;

            textBox2.Font = new Font("Arial", 18.25F);
            panel1.Visible = false;
            panel2.Visible = false;

        }

        public void ComboEkle()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Horses));
            comboBox2.DataSource = Enum.GetValues(typeof(Horses));
            comboBox3.DataSource = Enum.GetValues(typeof(Horses));
            comboBox4.DataSource = Enum.GetValues(typeof(Horses));
            comboBox5.DataSource = Enum.GetValues(typeof(Horses));
            comboBox6.DataSource = Enum.GetValues(typeof(Horses));
        }

        private void button2_Click(object sender, EventArgs e)       //yarışı başlat butonu
        {
            button6.Visible = false;
            //     button3.Enabled = false;
            if (pictureBox1.Location.X == 12)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;

                if (yarisSayac < 6)
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    timer4.Start();
                    timer5.Start();
                    timer6.Start();
                    yarisSayac++;
                    label16.Text = yarisSayac.ToString() + ".ayak";
                }
                else
                {
                    MessageBox.Show("Koşu bitti!");

                } 
            }
            else
            {
                MessageBox.Show("Atlar başlangıç pozisyonunda değil!");
            }

            if (radioButton1.Checked == true)
            {
                label1.BackColor = Color.Gold;
                label2.BackColor = Color.Gold;
                label3.BackColor = Color.Gold;
                label4.BackColor = Color.Gold;
                label5.BackColor = Color.Gold;
                label6.BackColor = Color.Gold;
            }
            if (radioButton2.Checked == true)
            {
                label1.BackColor = Color.DarkGreen;
                label2.BackColor = Color.DarkGreen;
                label3.BackColor = Color.DarkGreen;
                label4.BackColor = Color.DarkGreen;
                label5.BackColor = Color.DarkGreen;
                label6.BackColor = Color.DarkGreen;
            }

            if (yarisSayac>=6)
            {
                button6.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dat = pictureBox1.Width;
            ileri = rand.Next(10, 30);
            pictureBox1.Left += ileri;

            if (pictureBox1.Left + dat >= pictureBox7.Left)
            {
                timer1.Stop();
                listBox1.Items.Add(label1.Text);
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int dat = pictureBox2.Width;
            ileri = rand.Next(10, 30);
            pictureBox2.Left += ileri;

            if (pictureBox2.Left + dat >= pictureBox7.Left)
            {
                timer2.Stop();
                listBox1.Items.Add(label2.Text);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int dat = pictureBox3.Width;
            ileri = rand.Next(10, 30);
            pictureBox3.Left += ileri;


            if (pictureBox3.Left + dat >= pictureBox7.Left)
            {
                timer3.Stop();
                listBox1.Items.Add(label3.Text);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int dat = pictureBox4.Width;
            ileri = rand.Next(10, 30);
            pictureBox4.Left += ileri;

            if (pictureBox4.Left + dat >= pictureBox7.Left)
            {
                timer4.Stop();
                listBox1.Items.Add(label4.Text);
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int dat = pictureBox5.Width;
            ileri = rand.Next(10, 30);
            pictureBox5.Left += ileri;

            if (pictureBox5.Left + dat >= pictureBox7.Left)
            {
                timer5.Stop();
                listBox1.Items.Add(label5.Text);
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int dat = pictureBox6.Width;
            ileri = rand.Next(10, 30);
            pictureBox6.Left += ileri;

            if (pictureBox6.Left + dat >= pictureBox7.Left)
            {
                timer6.Stop();
                listBox1.Items.Add(label6.Text);
            }
        }
        public enum Horses
        {
            Seçiniz, Ribella, Ekinoks, Trapper, BPilot, GoldGuard, Karayel
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)      //bahis panelini açar
        {
            panel1.Visible = true;
            ComboEkle();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            bool sonuc = true, devam = true;
            List<string> bets = new List<string>();

            bets.Add(textBox1.Text);
            bets.Add(comboBox1.SelectedItem.ToString());
            bets.Add(comboBox2.SelectedItem.ToString());
            bets.Add(comboBox3.SelectedItem.ToString());
            bets.Add(comboBox4.SelectedItem.ToString());
            bets.Add(comboBox5.SelectedItem.ToString());
            bets.Add(comboBox6.SelectedItem.ToString());

            while (devam)
            {
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    if (!char.IsDigit(textBox2.Text[i]))
                        sonuc = false;      //Eğer karakter sayı değilse false döner
                }

                if (sonuc == false)
                {
                    MessageBox.Show("Tutarı rakam olarak giriniz!");
                    devam = false;
                }
                else
                {
                    bets.Add(textBox2.Text);
                    kuponlar.Add(bets);
                    devam = false;
                }
            }
            devam = true;

            textBox1.Clear();
            textBox2.Clear();

        }

        private void Button5_Click(object sender, EventArgs e)    //kaydedilmiş betsleri gösterir, kuponlar butonu
        {

            foreach (var item in kuponlar)
            {
                var dd = item.ToArray();
                dataGridView1.Rows.Add(dd);
            }
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)       
            //kazananlar formunu açar, kazananlar ve kaybedenler listlerini doldurur
        {
            panel1.Visible = false;

            foreach (var item in kuponlar)
            {
                List<string> karsilastirma = new List<string>();
                var b = item.ToArray();

                for (int i = 1; i < 7; i++)
                {
                    karsilastirma.Add(b[i]);
                }

                var v = sonuclar.Except(karsilastirma).ToList();

                if (v.Count == 0)
                {
                    form2data.Add(item);
                }
                else
                {
                    form2data2.Add(item);

                }
            }

            Form2 ff = new Form2(form2data, form2data2);
            //ff.VeriGonder(form2data);
            ff.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)    //yeni yarışa hazırlan
        {

            if (listBox1.Items.Count > 0)
            {
                if (yarisSayac < 6)
                {
                    sonuclar.Add(listBox1.Items[0].ToString());
                }
                pictureBox1.Location = new Point(12, 33);
                pictureBox2.Location = new Point(12, 110);
                pictureBox3.Location = new Point(12, 184);
                pictureBox4.Location = new Point(12, 264);
                pictureBox5.Location = new Point(12, 346);
                pictureBox6.Location = new Point(12, 436);
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Son yarış bitmeden yeni yarış başlatamazsınız!");
            }        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            count = form.deger;

            string[] isimler = new string[] {"Alper", "Kerem", "Ebru", "Neslihan", "Elif","Nagihan","Ayşenur","Belen","Selin",
                                            "Eyüp","Buğra","Oğuz","Anıl","Hakkıcan","Merve"};
          
            for (int i = 0; i < count; i++)
            {
                List<string> bets = new List<string>();
                bets.Add(isimler[rand.Next(0, 15)]);
                for (int n = 0; n < 6; n++)
                {
                    int at= rand.Next(0, 6);
                    switch (at)
                    {
                        case 0:
                            bets.Add(Horses.Ribella.ToString());
                            break;
                        case 1:
                            bets.Add(Horses.Ekinoks.ToString());
                            break;
                        case 2:
                            bets.Add(Horses.Trapper.ToString());
                            break;
                        case 3:
                            bets.Add(Horses.BPilot.ToString());
                            break;
                        case 4:
                            bets.Add(Horses.GoldGuard.ToString());
                            break;
                        case 5:
                            bets.Add(Horses.Karayel.ToString());
                            break;
                        default:
                            break;
                    }                 
                }
                bets.Add(rand.Next(0, 1000).ToString());
                kuponlar.Add(bets);

            }

        }
    }
}
