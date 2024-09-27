using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace şşişişişişşi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_CheckedChanged(object sender, EventArgs e)
        {
            Btna.Checked = false;   
            BtnB.Checked = false;
            BtnC.Checked = false;
            BtnD.Checked = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnB.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true; 
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = yanlis.ToString(); 
                pictureBox2.Visible = false;
            }
        }

        private void BtnC_CheckedChanged(object sender, EventArgs e)
        {
            Btna.Checked = false;
            BtnB.Checked = false;
            BtnC.Checked = false;
            BtnD.Checked = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = false;
            }
        }

        private void BtnD_CheckedChanged(object sender, EventArgs e)
        {
            Btna.Checked = false;
            BtnB.Checked = false;
            BtnC.Checked = false;
            BtnD.Checked = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = false;
            }
        }

        private void Btna_CheckedChanged(object sender, EventArgs e)
        {
            Btna.Enabled = true;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = Btna.Text;
            if(label4.Text == label5.Text)
            if (Btna.Checked)
            {
                    dogru++;
                    Lbldogru.Text=dogru.ToString();
                    pictureBox1.Visible = true; 
                MessageBox.Show("Doğru cevap!");
            }
            else if (BtnB.Checked || BtnC.Checked || BtnD.Checked)
            {
                yanlis++;
                Lblyanlis.Text=yanlis.ToString();
                    pictureBox2.Visible= true;  
                MessageBox.Show("Yanlış cevap!");
            }
            else 
            {
                MessageBox.Show("Lütfen bir seçenek işaretleyin.");
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            Btna.Enabled=true;
            BtnB.Enabled=true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible=false;

            soruno++;
            Lblsoruno.Text= soruno.ToString();
              
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kac yılında ilan edilmiştir ? ";
                Btna.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "HANGİ İL EGE BÖLGEMİZDE BULUNMAZ";
                Btna.Text = "İZMİR";
                BtnB.Text = "BALIKESİR";
                BtnC.Text = "MANİSA";
                BtnD.Text = "AYDIN";
                label4.Text = "BALIKESİR";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuşlar kimin kitabı?";
                Btna.Text = "sait faik";
                BtnB.Text = "cemal süreyaa";
                BtnC.Text = "atilla ilhan";
                BtnD.Text = "reşat nuri";
                label4.Text = "BALIKESİR";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                Btna.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "yanlış:" + yanlis);
            }
        }
    }
}
