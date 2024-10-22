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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(" provider = microsoft.ace.oledb.12.0; data source = Pansiyon.accdb ");

        

        private void FrmOdalar_Load(object sender, EventArgs e)
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
            if(btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
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
            }
        }       
    }
}
