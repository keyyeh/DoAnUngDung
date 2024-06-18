using BUS;
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
    public partial class frmDangKy : Form
    {
        private string maKS;
        public frmDangKy(string maKS)
        {
            InitializeComponent();
            this.maKS = maKS;
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();

        DTO_NhanVien dtoNhanVien = null;
        private void btnTao_Click(object sender, EventArgs e)
        {
            dtoNhanVien = new DTO_NhanVien(txtTK.Text,maKS, 6,txtHo.Text,txtTen.Text);
            if(busNhanVien.Them(dtoNhanVien) >= 1)
            {
                if (busTaiKhoan.TaoTK(txtTK.Text,txtMatKhau.Text))
                {
                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();              
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
