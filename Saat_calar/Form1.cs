using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Saat_calar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string saat;
        string dakika;
        string saniye;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saat = DateTime.Now.Hour.ToString("00");
            dakika = DateTime.Now.Minute.ToString("00");
            saniye = DateTime.Now.Second.ToString("00");
            lblsaat.Text = saat.ToString();
            lbldakika.Text = dakika.ToString();
            lblsaniye.Text = saniye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




       
        private void Form1_Load(object sender, EventArgs e)
        {

            radioButton1.Select();

            for ( int i = 0; i <= 24; i++)
            {
                comboBox1.Items.Add(i);
                
                
            }
            for (int j = 1; j <= 60; j++)
            {
                comboBox2.Items.Add(j);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldur!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Sistem Kuruldu!");
                    timer2.Start();
                    button2.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    button2.Visible = false;
                   
                }
                if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Sistem Kuruldu!");
                    timer4.Start();
                    button2.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    button2.Visible = false;
                   
                }
                if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Sistem Kuruldu!");
                    timer5.Start();
                    button2.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    button2.Visible = false;
                   
                }
                
            }
           
            
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        string a;
        string b;
        private void timer2_Tick(object sender, EventArgs e)
        {
             a = Convert.ToString(comboBox1.SelectedItem);
             b = Convert.ToString(comboBox2.SelectedItem);
            Convert.ToInt32(saat);
            if ((Convert.ToString(DateTime.Now.Hour)) == a && (Convert.ToString(DateTime.Now.Minute) == b))
            {
                label3.Text = "Bilgisayar Kapatılıyor.";
                
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
                psi.Arguments = "-f -s -t 0";
                Process.Start(psi);
                 
            }

                
              
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("Durduruldu!");
        }




        // Burası Panel MaouseMove,Up,Down Yeri //
        private bool mouseDown;
        private Point lastLocation;

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
       
        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblgorev.Text = "Kapatılacak";
            }
            if (radioButton2.Checked == true)
            {
                lblgorev.Text = "Yeniden Başlatılacak";
            }
            if (radioButton3.Checked == true)
            {
                lblgorev.Text = "Oturum Kapatılacak";
            }
            
            lblsaata.Text = Convert.ToString(comboBox1.SelectedItem);
            lbldakikaa.Text = Convert.ToString(comboBox2.SelectedItem);
           
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            a = Convert.ToString(comboBox1.SelectedItem);
            b = Convert.ToString(comboBox2.SelectedItem);
            Convert.ToInt32(saat);
            if ((Convert.ToString(DateTime.Now.Hour)) == a && (Convert.ToString(DateTime.Now.Minute) == b))
            {
                label3.Text = "Yeniden Başlatılıyor.";
                System.Diagnostics.Process.Start("shutdown", "-r -f -t 0");
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            a = Convert.ToString(comboBox1.SelectedItem);
            b = Convert.ToString(comboBox2.SelectedItem);
            Convert.ToInt32(saat);
            if ((Convert.ToString(DateTime.Now.Hour) == a) && (Convert.ToString(DateTime.Now.Minute) == b))
            {
                label3.Text = "Oturum Kapatılıyor.";
                System.Diagnostics.Process.Start("shutdown", "-l -f");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("İşlemi durdurmak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", " -a");
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button2.Visible = true;
                button2.Enabled = true;
                
                
               
                
            }
        }

       

      
    }
}
