
namespace RentACarOtomasyonu
{
    partial class frmAraçListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Yakitcombo = new System.Windows.Forms.ComboBox();
            this.Ücrettxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Sericombo = new System.Windows.Forms.ComboBox();
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(730, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboAraçlar.Location = new System.Drawing.Point(894, 44);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(121, 23);
            this.comboAraçlar.TabIndex = 1;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(42, 531);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(94, 25);
            this.btnResim.TabIndex = 40;
            this.btnResim.Text = "Resim Değiştir";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(130, 573);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(82, 36);
            this.btnİptal.TabIndex = 39;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(42, 573);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(82, 36);
            this.btnGüncelle.TabIndex = 38;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Plaka";
            // 
            // Yakitcombo
            // 
            this.Yakitcombo.FormattingEnabled = true;
            this.Yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.Yakitcombo.Location = new System.Drawing.Point(110, 253);
            this.Yakitcombo.Name = "Yakitcombo";
            this.Yakitcombo.Size = new System.Drawing.Size(144, 23);
            this.Yakitcombo.TabIndex = 28;
            // 
            // Ücrettxt
            // 
            this.Ücrettxt.Location = new System.Drawing.Point(110, 283);
            this.Ücrettxt.Name = "Ücrettxt";
            this.Ücrettxt.Size = new System.Drawing.Size(144, 23);
            this.Ücrettxt.TabIndex = 27;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(110, 223);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(144, 23);
            this.Kmtxt.TabIndex = 26;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(110, 193);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(144, 23);
            this.Renktxt.TabIndex = 25;
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(110, 163);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(144, 23);
            this.Yiltxt.TabIndex = 24;
            // 
            // Sericombo
            // 
            this.Sericombo.FormattingEnabled = true;
            this.Sericombo.Location = new System.Drawing.Point(110, 133);
            this.Sericombo.Name = "Sericombo";
            this.Sericombo.Size = new System.Drawing.Size(144, 23);
            this.Sericombo.TabIndex = 23;
            // 
            // Markacombo
            // 
            this.Markacombo.FormattingEnabled = true;
            this.Markacombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.Markacombo.Location = new System.Drawing.Point(110, 103);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(144, 23);
            this.Markacombo.TabIndex = 22;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.Markacombo_SelectedIndexChanged);
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(110, 73);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(144, 23);
            this.Plakatxt.TabIndex = 21;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1045, 73);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 36);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(42, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 213);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1226, 691);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yakitcombo);
            this.Controls.Add(this.Ücrettxt);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Yiltxt);
            this.Controls.Add(this.Sericombo);
            this.Controls.Add(this.Markacombo);
            this.Controls.Add(this.Plakatxt);
            this.Controls.Add(this.comboAraçlar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAraçListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmAraçListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Yakitcombo;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.ComboBox Sericombo;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}