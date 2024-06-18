using DTO;
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
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Connect conn = new cls_Connect(txbTenMayChu.Text, txbCSDL.Text);
                frmDangNhap dangNhap = new frmDangNhap();
                this.Hide();
                dangNhap.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại! Lỗi: " + ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            cbXacThuc.Text = "Windows authentication";
            loadform();
            txbCSDL.Text = "QLKHACHSAN";
        }
        void loadform()
        {
            txbTenMayChu.Text = Environment.MachineName + @"\SQLEXPRESS";
            if (cbXacThuc.Text == "Windows authentication")
            {
                lbTen.Enabled = false;
                lbMK.Enabled = false;
                txbTenNguoiDung.Enabled = false;
                txbMatKhau.Enabled = false;
            }
            else
            {
                lbTen.Enabled = true;
                lbMK.Enabled = true;
                txbTenNguoiDung.Enabled = true;
                txbMatKhau.Enabled = true;
            }
        }

    }
}
