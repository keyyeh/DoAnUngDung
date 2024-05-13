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
    public partial class frmThemPhong : Form
    {
        private string maKS, maTang;
        public frmThemPhong(string maKS,string maTang)
        {
            InitializeComponent();
            this.maKS = maKS;
            this.maTang = maTang;
        }
        BUS_Phong busPhong = new BUS_Phong();
        BUS_Tang busTang = new BUS_Tang();

        DTO_Phong dtoPhong;

        private void frmPhong_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            string loaiPhong = txtLoaiPhong.Text;
            double gia = double.Parse(txtGia.Text);
            int sucChua = int.Parse(txtSucChua.Text);

            dtoPhong = new DTO_Phong(maPhong, maKS, maTang, tenPhong, loaiPhong, gia, sucChua);

            if (busPhong.Them(dtoPhong) > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
