namespace Proje1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxSırala = new System.Windows.Forms.ComboBox();
            this.txbArama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUrun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cbxPersonel = new System.Windows.Forms.ComboBox();
            this.dtpSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.gbxKayit = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.gbxAktar = new System.Windows.Forms.GroupBox();
            this.gbxGrafik = new System.Windows.Forms.GroupBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpGrafikTarih2 = new System.Windows.Forms.DateTimePicker();
            this.dtpGrafikTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.gbxKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbxAktar.SuspendLayout();
            this.gbxGrafik.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSırala
            // 
            this.cbxSırala.FormattingEnabled = true;
            this.cbxSırala.Items.AddRange(new object[] {
            "A\'dan Z\'ye",
            "Z\'den A\'ya",
            "Eskiden Yeniye",
            "Yeniden Eskiye"});
            this.cbxSırala.Location = new System.Drawing.Point(423, 51);
            this.cbxSırala.Name = "cbxSırala";
            this.cbxSırala.Size = new System.Drawing.Size(121, 24);
            this.cbxSırala.TabIndex = 30;
            this.cbxSırala.SelectedIndexChanged += new System.EventHandler(this.cbxSırala_SelectedIndexChanged);
            // 
            // txbArama
            // 
            this.txbArama.Location = new System.Drawing.Point(240, 53);
            this.txbArama.Name = "txbArama";
            this.txbArama.Size = new System.Drawing.Size(100, 22);
            this.txbArama.TabIndex = 29;
            this.txbArama.TextChanged += new System.EventHandler(this.txbArama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ürün Veya Müşteri Adına Göre Ara:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(252, 271);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 45);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Personel:";
            // 
            // tbxMusteri
            // 
            this.tbxMusteri.Location = new System.Drawing.Point(135, 72);
            this.tbxMusteri.Name = "tbxMusteri";
            this.tbxMusteri.Size = new System.Drawing.Size(100, 22);
            this.tbxMusteri.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Müşteri:";
            // 
            // tbxUrun
            // 
            this.tbxUrun.Location = new System.Drawing.Point(135, 29);
            this.tbxUrun.Name = "tbxUrun";
            this.tbxUrun.Size = new System.Drawing.Size(100, 22);
            this.tbxUrun.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 202);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(135, 195);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(100, 22);
            this.tbxFiyat.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Satış Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Fiyat:";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(135, 271);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(84, 45);
            this.btnGüncelle.TabIndex = 38;
            this.btnGüncelle.Text = "&Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(19, 271);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 45);
            this.btnEkle.TabIndex = 39;
            this.btnEkle.Text = "&Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(135, 155);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(100, 22);
            this.nudAdet.TabIndex = 40;
            // 
            // cbxPersonel
            // 
            this.cbxPersonel.FormattingEnabled = true;
            this.cbxPersonel.Items.AddRange(new object[] {
            "Zeynep Tuna",
            "Tuğrul İnanç",
            "Ahmet Özdemir",
            "Emel Bozok"});
            this.cbxPersonel.Location = new System.Drawing.Point(135, 113);
            this.cbxPersonel.Name = "cbxPersonel";
            this.cbxPersonel.Size = new System.Drawing.Size(100, 24);
            this.cbxPersonel.TabIndex = 41;
            this.cbxPersonel.Tag = "";
            // 
            // dtpSatisTarihi
            // 
            this.dtpSatisTarihi.CustomFormat = "yyyy-MM-dd";
            this.dtpSatisTarihi.Location = new System.Drawing.Point(135, 231);
            this.dtpSatisTarihi.Name = "dtpSatisTarihi";
            this.dtpSatisTarihi.Size = new System.Drawing.Size(201, 22);
            this.dtpSatisTarihi.TabIndex = 42;
            // 
            // gbxKayit
            // 
            this.gbxKayit.Controls.Add(this.label14);
            this.gbxKayit.Controls.Add(this.label4);
            this.gbxKayit.Controls.Add(this.dtpSatisTarihi);
            this.gbxKayit.Controls.Add(this.label1);
            this.gbxKayit.Controls.Add(this.cbxPersonel);
            this.gbxKayit.Controls.Add(this.tbxUrun);
            this.gbxKayit.Controls.Add(this.nudAdet);
            this.gbxKayit.Controls.Add(this.label2);
            this.gbxKayit.Controls.Add(this.btnEkle);
            this.gbxKayit.Controls.Add(this.tbxMusteri);
            this.gbxKayit.Controls.Add(this.btnGüncelle);
            this.gbxKayit.Controls.Add(this.label3);
            this.gbxKayit.Controls.Add(this.label6);
            this.gbxKayit.Controls.Add(this.btnSil);
            this.gbxKayit.Controls.Add(this.label7);
            this.gbxKayit.Controls.Add(this.tbxFiyat);
            this.gbxKayit.Location = new System.Drawing.Point(25, 329);
            this.gbxKayit.Name = "gbxKayit";
            this.gbxKayit.Size = new System.Drawing.Size(373, 354);
            this.gbxKayit.TabIndex = 43;
            this.gbxKayit.TabStop = false;
            this.gbxKayit.Text = "Satış Kaydı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(241, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "₺";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(1111, 9);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(126, 16);
            this.lblTarih.TabIndex = 44;
            this.lblTarih.Text = "00000000000000000";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(1204, 35);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(42, 16);
            this.lblZaman.TabIndex = 45;
            this.lblZaman.Text = "00000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Sırala:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(33, 118);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(492, 463);
            this.chart1.TabIndex = 47;
            this.chart1.Text = "chart1";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(17, 35);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(84, 45);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "&Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(133, 35);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(84, 45);
            this.btnWord.TabIndex = 48;
            this.btnWord.Text = "&Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(253, 35);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(84, 45);
            this.btnPDF.TabIndex = 49;
            this.btnPDF.Text = "&PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // gbxAktar
            // 
            this.gbxAktar.Controls.Add(this.btnPDF);
            this.gbxAktar.Controls.Add(this.btnExcel);
            this.gbxAktar.Controls.Add(this.btnWord);
            this.gbxAktar.Location = new System.Drawing.Point(490, 315);
            this.gbxAktar.Name = "gbxAktar";
            this.gbxAktar.Size = new System.Drawing.Size(358, 108);
            this.gbxAktar.TabIndex = 44;
            this.gbxAktar.TabStop = false;
            this.gbxAktar.Text = "Aktar";
            // 
            // gbxGrafik
            // 
            this.gbxGrafik.Controls.Add(this.btnGoster);
            this.gbxGrafik.Controls.Add(this.label13);
            this.gbxGrafik.Controls.Add(this.label12);
            this.gbxGrafik.Controls.Add(this.label11);
            this.gbxGrafik.Controls.Add(this.chart1);
            this.gbxGrafik.Controls.Add(this.dtpGrafikTarih2);
            this.gbxGrafik.Controls.Add(this.dtpGrafikTarih1);
            this.gbxGrafik.Location = new System.Drawing.Point(446, 442);
            this.gbxGrafik.Name = "gbxGrafik";
            this.gbxGrafik.Size = new System.Drawing.Size(600, 601);
            this.gbxGrafik.TabIndex = 48;
            this.gbxGrafik.TabStop = false;
            this.gbxGrafik.Text = "Grafik";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(497, 65);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(84, 39);
            this.btnGoster.TabIndex = 50;
            this.btnGoster.Text = "&Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(545, 16);
            this.label13.TabIndex = 56;
            this.label13.Text = "Tarih aralığı ve görmek istediğiniz ürünü üzerine tıklayarak seçtikten sonra \"Gös" +
    "ter\"i tıklayın.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Başlangıç:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Bitiş:";
            // 
            // dtpGrafikTarih2
            // 
            this.dtpGrafikTarih2.CustomFormat = "yyyy-MM-dd";
            this.dtpGrafikTarih2.Location = new System.Drawing.Point(310, 76);
            this.dtpGrafikTarih2.Name = "dtpGrafikTarih2";
            this.dtpGrafikTarih2.Size = new System.Drawing.Size(161, 22);
            this.dtpGrafikTarih2.TabIndex = 53;
            // 
            // dtpGrafikTarih1
            // 
            this.dtpGrafikTarih1.CustomFormat = "yyyy-MM-dd";
            this.dtpGrafikTarih1.Location = new System.Drawing.Point(89, 76);
            this.dtpGrafikTarih1.Name = "dtpGrafikTarih1";
            this.dtpGrafikTarih1.Size = new System.Drawing.Size(161, 22);
            this.dtpGrafikTarih1.TabIndex = 52;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(687, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Location = new System.Drawing.Point(908, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker2.TabIndex = 49;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Şu Tarihler Arası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(867, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "ve";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(1096, 49);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 30);
            this.btnTemizle.TabIndex = 50;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1256, 1055);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxGrafik);
            this.Controls.Add(this.gbxAktar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.gbxKayit);
            this.Controls.Add(this.cbxSırala);
            this.Controls.Add(this.txbArama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Satış Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.gbxKayit.ResumeLayout(false);
            this.gbxKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbxAktar.ResumeLayout(false);
            this.gbxGrafik.ResumeLayout(false);
            this.gbxGrafik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxSırala;
        private System.Windows.Forms.TextBox txbArama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cbxPersonel;
        private System.Windows.Forms.DateTimePicker dtpSatisTarihi;
        private System.Windows.Forms.GroupBox gbxKayit;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.GroupBox gbxAktar;
        private System.Windows.Forms.GroupBox gbxGrafik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpGrafikTarih2;
        private System.Windows.Forms.DateTimePicker dtpGrafikTarih1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGoster;
    }
}

