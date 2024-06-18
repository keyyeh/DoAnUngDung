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
        private string maKS,flag;
        private int maTang, maPhong;
        public frmThemPhong(string maKS,int maTang,string flag)
        {
            InitializeComponent();
            this.maKS = maKS;
            this.maTang = maTang;
            this.flag = flag;
        }
        public frmThemPhong(string maKS, int maTang,int maPhong, string flag)
        {
            InitializeComponent();
            this.maKS = maKS;
            this.maTang = maTang;
            this.maPhong = maPhong;
            this.flag = flag;
        }
        BUS_Phong busPhong = new BUS_Phong();
        BUS_LoaiPhong busLPhong = new BUS_LoaiPhong();
        BUS_Tang busTang = new BUS_Tang();

        DTO_Phong dtoPhong;

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLoaiPhong();
            txtGia.Text = busLPhong.LayGiaPhong(Convert.ToInt32(cbLoaiPhong.SelectedValue)).ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (flag == "updatePhong")
            {
                string tenPhong = txtTenPhong.Text;
                int loaiPhong = Convert.ToInt32(cbLoaiPhong.SelectedValue);
                int sucChua = int.Parse(txtSucChua.Text);
                int maTang =Convert.ToInt32(cbTang.SelectedValue);

                dtoPhong = new DTO_Phong(maPhong, maKS,maTang, tenPhong, loaiPhong,1, sucChua);

                if (busPhong.Sua(dtoPhong) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            
        }

        private void frmThemPhong_Load(object sender, EventArgs e)
        {
            cbLoaiPhong.DataSource = busLPhong.Xem();
            loadLoaiPhong();
            if (flag == "updatePhong")
            {
                label1.Text = "SỬA PHÒNG";
                btnCapNhat.Enabled = true;
                cbTang.DataSource = busTang.XemPhong();
                cbTang.DisplayMember = "TANG1";
                cbTang.ValueMember = "MATANG";

                DTO_Phong phong = busPhong.Lay1Phong(maTang, maPhong);
                cbTang.Text = busTang.LayTenTang(phong.MaTang);
                txtTenPhong.Text = phong.TenPhong;
                cbLoaiPhong.Text = busLPhong.LayTenLPhong(phong.MaLoaiP);
                txtGia.Text = busLPhong.LayGiaPhong(Convert.ToInt32(cbLoaiPhong.SelectedValue)).ToString();
                txtSucChua.Text = phong.SucChua.ToString();
            }
            if (flag == "editPhong")
            {
                btnThem.Enabled = true;
                cbTang.DataSource = busTang.XemPhong();
                cbTang.DisplayMember = "TANG1";
                cbTang.ValueMember = "MATANG";
                cbTang.Enabled = false;

                DTO_Phong phong = busPhong.Lay1Phong(maTang, maPhong);
                cbTang.Text = busTang.LayTenTang(phong.MaTang);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadLoaiPhong()
        {           
            cbLoaiPhong.DisplayMember = "TENLOAIP";
            cbLoaiPhong.ValueMember = "MALOAIP";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (flag == "editPhong")
            {              
                loadLoaiPhong();
                string tenPhong = txtTenPhong.Text;
                int loaiPhong = Convert.ToInt32(cbLoaiPhong.SelectedValue);
                int sucChua = int.Parse(txtSucChua.Text);

                dtoPhong = new DTO_Phong(maKS, maTang, tenPhong, loaiPhong, 0, sucChua);

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
}
