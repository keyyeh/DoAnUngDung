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
    public partial class frmXuatPhieu : Form
    {
        string maKS = "";
        string maPhong = "";
        string maKH = "";

        BUS_KhachSan busKhachSan = new BUS_KhachSan();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_Phong busPhong = new BUS_Phong();

        public frmXuatPhieu(string maKS,string maPhong, string maKH)
        {
            InitializeComponent();
            this.maKS = maKS;
            this.maPhong = maPhong;
            this.maKH = maKH;
        }

        private void frmXuatPhieu_Load(object sender, EventArgs e)
        {
            DTO_KhachSan khachSan = busKhachSan.LayDuLieu(maKS);
            DTO_Phong phong = busPhong.Lay1Phong(maKS,maPhong);
            DTO_KhachHang khachHang = busKhachHang.Lay1KhachHang(maKS, maPhong);

            txtMaKS.Text = khachSan.MaKS;
            txtTenKS.Text = khachSan.TenKS;
            txtPhong.Text = phong.TenPhong;
            if (khachHang != null)
            {
                txtMaKH.Text = khachHang.MaKH;
                txtTenKH.Text = khachHang.TenKH;
                txtSDT.Text = khachHang.Sdt;
            }
            
        }
    }
}
