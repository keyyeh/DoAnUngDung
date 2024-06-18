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
    public partial class frmCapNhatPhong : Form
    {
        private string maKS,maTang,maPhong;
        public frmCapNhatPhong(string maKS,string maTang,string maPhong)
        {
            InitializeComponent();
            this.maKS = maKS;
            this.maTang = maTang;
            this.maPhong = maPhong;
        }
        BUS_Phong busPhong = new BUS_Phong();

        BUS_Tang busTang = new BUS_Tang();
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenPhong = txtTenPhong.Text;
            string loaiPhong = txtLoaiPhong.Text;
            double gia = double.Parse(txtGia.Text);
            int sucChua = int.Parse(txtSucChua.Text);
            string maTang = cbTang.SelectedValue.ToString();

            //DTO_Phong phong = new DTO_Phong(txtMaPhong.Text,maKS,maTang,tenPhong,loaiPhong,gia,sucChua);
            //if (busPhong.Sua(phong) > 0)
            //{
            //    MessageBox.Show("Sửa thành công");
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thất bại");
            //}
        }

        private void frmCapNhatPhong_Load(object sender, EventArgs e)
        {
            cbTang.DataSource = busTang.XemPhong();
            cbTang.DisplayMember = "LAU";
            cbTang.ValueMember = "MATANG";

            //DTO_Phong phong = busPhong.Lay1Phong(maKS, maTang, maPhong);
            //txtMaPhong.Text = phong.MaPhong;
            //cbTang.Text = busTang.LayTenTang(phong.MaTang);
            //txtTenPhong.Text = phong.TenPhong;
            //txtLoaiPhong.Text = phong.LoaiPhong;
            //txtGia.Text = phong.Gia.ToString();
            //txtSucChua.Text = phong.SucChua.ToString();
        }
    }
}
