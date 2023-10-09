using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belgeornk1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnkontrol_Click(object sender, EventArgs e)
        {
            float ortalama;
            ortalama=Convert.ToSingle(txtOrtalama.Text);

            if (ortalama < 0)
            {
                lblSonuc.Text = "negatif deger giremezsiniz";
            }
            else if (ortalama < 50)
            {
                lblSonuc.Text = "kaldınız :(";
            }
            else if (ortalama < 70)
            {
                lblSonuc.Text = "tebrikler,geçtiniz";
            }
            else if (ortalama < 85)
            {
                lblSonuc.Text = "teşekkür belgesi aldiniz";
            }
            else if (ortalama <= 100)
            {
                lblSonuc.Text = "takdir belgesi aldiniz";
            }
            else
            {
                lblSonuc.Text = "100 den büyük deger giremezsin";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
        }
    }
}
