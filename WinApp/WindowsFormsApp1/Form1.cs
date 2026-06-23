using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text =txtA.Text + " + " + txtB.Text + " = " + tong + "";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu + "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
            txtA.Text = "";
            txtB.Text = "";
        }
    }
}
