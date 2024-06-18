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
    public partial class frmCapNhat : Form
    {
        private string flag,id;
        public frmCapNhat(string flag)
        {
            InitializeComponent();
            this.flag = flag;
        }
        public frmCapNhat(string id,string flag)
        {
            InitializeComponent();
            this.flag = flag;
            this.id = id;
        }
        BUS_LoaiSP busSanPham = new BUS_LoaiSP();
        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            if (flag == "updateOK")
            {
                txtMa.Text = id;
                txtMa.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (flag == "editOK")
            {
                DTO_LoaiSP loaiSP = new DTO_LoaiSP(int.Parse(txtMa.Text),txtTen.Text);
                busSanPham.Them(loaiSP);
                MessageBox.Show("Them thanh cong");
                this.Close();
            }
            if (flag == "updateOK")
            {
                
                busSanPham.Sua(new DTO_LoaiSP(int.Parse(txtMa.Text), txtTen.Text));
                MessageBox.Show("Sua thanh cong");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
