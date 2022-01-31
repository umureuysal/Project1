using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Magaza;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VerileriGoruntule();
            
            
            chart1.Titles.Add("Satılan Adet - Satış Tarihi Grafiği");
        }

        public System.Data.DataTable VerileriGoruntule()
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Select * from Satislar2", baglanti);
            SqlDataReader reader = command.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(reader);
            baglanti.Close();
            return dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxMusteri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxPersonel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nudAdet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dtpSatisTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


            
        }

        private void GrafikteGoster()
        {
            try
            {
                string starihi = DateTime.Parse(dtpGrafikTarih1.Text).ToString("yyyy-MM-dd");
                string starihi2 = DateTime.Parse(dtpGrafikTarih2.Text).ToString("yyyy-MM-dd");
                DataSet ds = new DataSet();
                baglanti.Open();
                string seri = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                SqlDataAdapter adapt = new SqlDataAdapter("Select Adet,SatisTarihi from Satislar2 where Ürün like'" + seri + "' and SatisTarihi between '" + starihi + "' and '" + starihi2 + "'", baglanti);
                adapt.Fill(ds);
                chart1.DataSource = ds;
                chart1.Series.Add(seri);
                chart1.Series[seri].Color = Color.Coral;
                chart1.Series[seri].XValueMember = "SatisTarihi";
                chart1.Series[seri].YValueMembers = "Adet";
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            

        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
            decimal fiyat = Convert.ToDecimal(tbxFiyat.Text);
            string starihi = DateTime.Parse(dtpSatisTarihi.Text).ToString("yyyy-MM-dd");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Satislar2 set Ürün='" + tbxUrun.Text + "',Müsteri='" + tbxMusteri.Text + "',Personel='" + cbxPersonel.Text + "',Adet='" + Convert.ToInt16(nudAdet.Text) + "',Fiyat=@fiyat,SatisTarihi='" + starihi + "' where SatisID=@id", baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            SqlDataReader reader = komut.ExecuteReader();
            baglanti.Close();
            dataGridView1.DataSource = VerileriGoruntule();
            Temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Hata");
            }
            
        }

        private void Temizle()
        {
            tbxUrun.Clear();
            tbxMusteri.Clear();
            tbxFiyat.Clear();
            cbxPersonel.Text = "";
            nudAdet.Value = 0;
            dtpSatisTarihi.Value = DateTime.Now.Date;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                decimal fiyat = Convert.ToDecimal(tbxFiyat.Text);
                string starihi = DateTime.Parse(dtpSatisTarihi.Text).ToString("yyyy-MM-dd");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into Satislar2 values (@urunadi,@müsteri,@personel,@adet,@fiyat,@satistarihi)", baglanti);
                komut.Parameters.AddWithValue("@urunadi", tbxUrun.Text);
                komut.Parameters.AddWithValue("@müsteri", tbxMusteri.Text);
                komut.Parameters.AddWithValue("@personel", cbxPersonel.Text);
                komut.Parameters.AddWithValue("@adet", Convert.ToInt16(nudAdet.Text));
                komut.Parameters.AddWithValue("@fiyat", fiyat);
                komut.Parameters.AddWithValue("@satistarihi", starihi);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataGridView1.DataSource = VerileriGoruntule();
                Temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Satislar2 where SatisID=@id", baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.DataSource = VerileriGoruntule();
            Temizle();
        }

        private void txbArama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string select = "Select * from Satislar2 where Müsteri like '%" + txbArama.Text + "%'  or Ürün like '%" + txbArama.Text + "%' ";
            SqlCommand komut = new SqlCommand(select, baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblZaman.Text = DateTime.Now.ToShortTimeString();
        }

        private void cbxSırala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSırala.SelectedIndex == 0)
            {
                Sırala("Müsteri", "asc");
            }
            if (cbxSırala.SelectedIndex == 1)
            {
                Sırala("Müsteri", "desc");
            }
            if (cbxSırala.SelectedIndex == 2)
            {
                Sırala("SatisTarihi", "asc");
            }
            if (cbxSırala.SelectedIndex == 3)
            {
                Sırala("SatisTarihi", "desc");
            }

        }

        public void Sırala(string sutun, string yon)
        {
            baglanti.Open();
            string select = "Select * from Satislar2 order by " + sutun + " " + yon;
            SqlCommand komut = new SqlCommand(select, baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void btnWord_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int satirsayisi = dataGridView1.Rows.Count;
                int sutunsayisi = dataGridView1.Columns.Count;
                Object[,] DataArray = new object[satirsayisi + 1, sutunsayisi + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= sutunsayisi - 1; c++)
                {
                    for (r = 0; r <= satirsayisi - 1; r++)
                    {
                        DataArray[r, c] = dataGridView1.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= satirsayisi - 1; r++)
                {
                    for (int c = 0; c <= sutunsayisi - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref satirsayisi, ref sutunsayisi,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= sutunsayisi - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGridView1.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;


            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Satış Kayıt";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TarihSirala();
        }

        private void TarihSirala()
        {
            string starihi = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            string starihi2 = DateTime.Parse(dateTimePicker2.Text).ToString("yyyy-MM-dd");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Satislar2 where SatisTarihi between '" + starihi + "' and '" + starihi2 + "'", baglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            baglanti.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TarihSirala();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            VerileriGoruntule();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Satış Kayıt.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message, "Diske aktarım başarısız");
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.FormattedValue.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("İşlem Başarılı!", "Bilgi");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Hata");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!", "Bilgi");
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            GrafikteGoster();
        }

       
    }
}

