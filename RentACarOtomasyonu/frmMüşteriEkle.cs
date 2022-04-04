using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentACarOtomasyonu
{
    public partial class frmMüşteriEkle : Form
    {
        RentACarOtomasyonu rentacarotomasyonu = new RentACarOtomasyonu();
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into müşteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            rentacarotomasyonu.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Tamamlandı");
            
        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
