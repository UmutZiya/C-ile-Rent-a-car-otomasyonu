﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentACarOtomasyonu
{


    public partial class frmAraçListele : Form
    {
        RentACarOtomasyonu rentacarotomasyonu = new RentACarOtomasyonu();
        public frmAraçListele()
        {
            InitializeComponent();
        }

        private void frmAraçListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            try
            {
                comboAraçlar.SelectedIndex = 0;
            }
            catch
            {


            }


        }


        private void YenileAraçlarListesi()
        {
            string cümle = "select * from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = rentacarotomasyonu.listele(adtr2, cümle);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Plakatxt.Text = satır.Cells["plaka"].Value.ToString();
            Markacombo.Text = satır.Cells["marka"].Value.ToString();
            Sericombo.Text = satır.Cells["seri"].Value.ToString();
            Yiltxt.Text = satır.Cells["yil"].Value.ToString();
            Renktxt.Text = satır.Cells["renk"].Value.ToString();
            Kmtxt.Text = satır.Cells["km"].Value.ToString();
            Yakitcombo.Text = satır.Cells["yakit"].Value.ToString();
            Ücrettxt.Text = satır.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();
        }




        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // dosyalara geçiş yapması için
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", Sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakitcombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(Ücrettxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            rentacarotomasyonu.ekle_sil_güncelle(komut2, cümle);
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = "";
            YenileAraçlarListesi();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            rentacarotomasyonu.ekle_sil_güncelle(komut2, cümle);
            YenileAraçlarListesi();
            pictureBox2.ImageLocation = "";
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";


        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sericombo.Items.Clear();
                if (Markacombo.SelectedItem.ToString() == "Opel")
                {
                    Sericombo.Items.Add("Astra");
                    Sericombo.Items.Add("Vectra");
                    Sericombo.Items.Add("Corsa");


                }
                else if (Markacombo.SelectedIndex == 1)
                {
                    Sericombo.Items.Add("Megane");
                    Sericombo.Items.Add("Clio");

                }
                else if (Markacombo.SelectedIndex == 2)
                {
                    Sericombo.Items.Add("Linea");
                    Sericombo.Items.Add("Egea");

                }
                else if (Markacombo.SelectedIndex == 3)
                {
                    Sericombo.Items.Add("Fiesta");
                    Sericombo.Items.Add("Focus");

                }
            }
            catch
            {

                ;
            }
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraçlar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (comboAraçlar.SelectedIndex == 1)
                {
                    string cümle = "select * from araç where durumu= 'BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = rentacarotomasyonu.listele(adtr2, cümle);
                }

                if (comboAraçlar.SelectedIndex == 2)
                {
                    string cümle = "select * from araç where durumu= 'DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = rentacarotomasyonu.listele(adtr2, cümle);
                }

            }
            catch
            {

                ;
            }
        }

    }
}
