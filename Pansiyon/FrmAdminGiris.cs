using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();          
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre Hatalı");
            }
        }
    }
}
