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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "101";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda101(Adi, Soyadi) values ('"+TxtAdi.Text+"', '"+TxtSoyadi.Text+"')", con);
            komut.ExecuteNonQuery();
            con.Close();
             
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "102";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda102(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "103";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda103(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "104";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda104(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "105";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda105(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "106";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda106(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "107";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda107(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "108";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda108(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            string metin = TxtOda.Text = "109";
            int sayi = Convert.ToInt32(metin);

            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into Oda109(Adi, Soyadi) values ('" + TxtAdi.Text + "', '" + TxtSoyadi.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gri renkli butonlar boş odaları gösterir.");
        }

        private void DtpCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(DtpGiris.Text);
            DateTime buyukTarih = Convert.ToDateTime(DtpCikis.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        OleDbConnection con = new OleDbConnection(" provider = microsoft.ace.oledb.12.0; data source = Pansiyon.accdb ");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //EKLE
            
            OleDbCommand komut = new OleDbCommand("insert into Musteriler(Adi, Soyadi, Cinsiyet, Tel, Mail, Tc, OdaNo, Ucret, GirisTarihi, CikisTarihi) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", con);
            con.Open();

            int odaNumarası = int.Parse(TxtOda.Text);

            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", mskTxtTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", TxtTc.Text);
            komut.Parameters.AddWithValue("@p7", odaNumarası);
            komut.Parameters.AddWithValue("@p8", txtUcret.Text);
            komut.Parameters.AddWithValue("@p9", DtpGiris.Value.ToString("dd-MM-yyyy"));
            komut.Parameters.AddWithValue("@p10", DtpCikis.Value.ToString("dd-MM-yyyy"));




            komut.ExecuteNonQuery();

            con.Close();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //101
            con.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Oda101", con);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                btn101.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
            }
            con.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }

            //102
            con.Open();
            OleDbCommand komut2 = new OleDbCommand("Select * from Oda102", con);
            OleDbDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            con.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }

            // 103
            con.Open();
            OleDbCommand komut3 = new OleDbCommand("Select * from Oda103", con);
            OleDbDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            con.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }

            // 104
            con.Open();
            OleDbCommand komut4 = new OleDbCommand("Select * from Oda104", con);
            OleDbDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            con.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }

            // 105
            con.Open();
            OleDbCommand komut5 = new OleDbCommand("Select * from Oda105", con);
            OleDbDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            con.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }

            // 106
            con.Open();
            OleDbCommand komut6 = new OleDbCommand("Select * from Oda106", con);
            OleDbDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            con.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }

            // 107
            con.Open();
            OleDbCommand komut7 = new OleDbCommand("Select * from Oda107", con);
            OleDbDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            con.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }

            // 108
            con.Open();
            OleDbCommand komut8 = new OleDbCommand("Select * from Oda108", con);
            OleDbDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            con.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn108.Enabled = false;
            }

            // 109
            con.Open();
            OleDbCommand komut9 = new OleDbCommand("Select * from Oda109", con);
            OleDbDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            con.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false;
            }
        }
    }
}
