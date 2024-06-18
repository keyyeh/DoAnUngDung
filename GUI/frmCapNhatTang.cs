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
    public partial class frmCapNhatTang : Form
    {
        private string flag;
        public frmCapNhatTang(string flag)
        {
            InitializeComponent();
            this.flag = flag;
        }
        BUS_Tang busTang = new BUS_Tang();
        private void btnOk_Click(object sender, EventArgs e)
        {
            DTO_Tang tang = new DTO_Tang(int.Parse(txtMa.Text),txtTen.Text);
            if (flag == "Sua")
            {
                if (busTang.Sua(tang) == 1)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
            }
            if (flag == "Xoa")
            {
                txtTen.Enabled = false;
                try
                {
                    if (MessageBox.Show("Xác nhận xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        busTang.Xoa(int.Parse(txtMa.Text));
                        MessageBox.Show("Xoa thanh cong");
                    }
                }
                catch
                {
                    MessageBox.Show("Khu vực còn dữ liệu không thể xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void frmCapNhatTang_Load(object sender, EventArgs e)
        {
            cbTang.DataSource = busTang.XemPhong();
            loadCBTang();
        }
        void loadCBTang()
        {
            cbTang.DisplayMember = "TANG";
            cbTang.ValueMember = "MATANG";
        }

        private void cbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBTang();
            DTO_Tang tang = busTang.Lay1Tang(Convert.ToInt32(cbTang.SelectedValue));
            txtMa.Text = tang.Id.ToString();
            txtTen.Text = tang.Lau;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
