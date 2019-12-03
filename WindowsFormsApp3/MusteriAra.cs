using ISS.BLL;
using ISS.DAL;
using ISS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MusteriAra : Form
    {
        public Yonetim form1;

        public MusteriAra()
        {
            InitializeComponent();
        }

        public MusteriAra(Yonetim form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bul(int.Parse(textBox1.Text));
       
        }
        void Bul(int numara)
        {
            MusteriBL mbl = new MusteriBL();
            Musteri mstr;
               

           List<Musteri> mstrlist = mbl.MusteriListele(numara);

            foreach (Musteri musteri in mstrlist)
            {
                form1.textBox1.Text = musteri.musteri_ad;
                form1.textBox2.Text = musteri.musteri_adres;
                form1.maskedTextBox1.Text = musteri.musteri_tel;
            }

        

        }
        
    }
}
