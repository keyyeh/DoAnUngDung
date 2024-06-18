using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (busTaiKhoan.CheckTK(txtEmail.Text,txtMatKhau.Text))
            {     
                frmMain frmMain = new frmMain(txtEmail.Text);
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tai khoan khong ton tai");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangKy = new frmDangKy("KS00000001");
            this.Hide();
            dangKy.ShowDialog();
            this.Show();
        }
    }
}
