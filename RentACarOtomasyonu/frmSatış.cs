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
    public partial class frmSatış : Form
    {
        public frmSatış()
        {
            InitializeComponent();
        }
        RentACarOtomasyonu arac = new RentACarOtomasyonu();
        private void frmSatış_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from satis";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2,sorgu2);
            arac.satışhesapla(label1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
