using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Pansiyon
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(" provider = microsoft.ace.oledb.12.0; data source = Pansiyon.accdb ");

        void listele()
        {
            OleDbCommand komut = new OleDbCommand("select * from Musteriler", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            TxtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskTxtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtTc.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtOda.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            DtpGiris.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            DtpCikis.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SİL
            OleDbCommand komut = new OleDbCommand("delete from Musteriler where Adi =@p1", con);

            con.Open();
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show(TxtAdi.Text + "  kayıt silindi");
            }
            else
                MessageBox.Show("Silme işlemi başarısız ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();

            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //TextBoxları temizle
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            mskTxtTel.Clear(); 
            TxtMail.Text = "";
            TxtTc.Clear();
            TxtOda.Clear();
            txtUcret.Clear();
            DtpGiris.Text = "";
            DtpCikis.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GÜNCELLE
            OleDbCommand komut = new OleDbCommand("update Musteriler set GirisTarihi=@p1, CikisTarihi=@p2 where Adi = @p3", con);
            con.Open();
            komut.Parameters.AddWithValue("@p1", DtpGiris.Value.ToString("dd-MM-yyyy"));
            komut.Parameters.AddWithValue("@p2", DtpCikis.Value.ToString("dd-MM-yyyy"));
            komut.Parameters.AddWithValue("@p3", TxtAdi.Text);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show(TxtAdi.Text + " kayıt güncellendi");
            }
            else
                MessageBox.Show("Güncelleme işlemi başarısız ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();

            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ARA 
            OleDbCommand komut = new OleDbCommand("select * from Musteriler where Adi like '%"+textBox1.Text+"%'", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
