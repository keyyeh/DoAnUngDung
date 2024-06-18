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
    public partial class frmThemSanPham : Form
    {
        private int id;
        private string flag;
        public frmThemSanPham(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public frmThemSanPham(int id,string flag)
        {
            InitializeComponent();
            this.id = id;
            this.flag = flag;
        }
        BUS_SanPham busSanPham = new BUS_SanPham();
        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            if (flag == "Sua")
            {
                DTO_SanPham sp = busSanPham.LayDuLieu(id);
                txtMaSP.Text = sp.MaSP.ToString();
                txtMaSP.Enabled = false;
                txtTenSP.Text = sp.TenSP;
                txtGia.Text = sp.Gia.ToString();
                txtDonVi.Text = sp.DonVi;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (flag == "Them")
            {
                DTO_SanPham sp = new DTO_SanPham(int.Parse(txtMaSP.Text),id,txtTenSP.Text,txtDonVi.Text,double.Parse(txtGia.Text));

                if (busSanPham.Them(sp) >= 1)
                {
                    MessageBox.Show("Them thanh cong", "thong bao", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }

                this.Close();
            }
            if (flag == "Sua")
            {
                DTO_SanPham sp = new DTO_SanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, txtDonVi.Text, double.Parse(txtGia.Text));
                busSanPham.Sua(sp);
                MessageBox.Show("Sua thanh cong", "thong bao", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
