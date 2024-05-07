using BUS;
using DAL;
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
        private string maPhong;
        public frmXuatPhieu(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }
        BUS_DatPhong busDatPhong = new BUS_DatPhong();
        private void btnIn_Click(object sender, EventArgs e)
        {
            busDatPhong.Xoa(maPhong);
            
        }

        private void frmXuatPhieu_Load(object sender, EventArgs e)
        {
            IEnumerable<DTO_ThongTinDatPhong> datPhong = busDatPhong.InPhieu(maPhong);
            foreach (var item in datPhong)
            {
                txtMaKS.Text = item.MaKS;
                txtTenKS.Text = item.TenKS;
                txtTenKH.Text = item.TenKH;
                txtSDT.Text = item.Sdt;
                lbNgayDatPhong.Text = item.NgayDatPhong.ToString();
                lbNgayTraPhong.Text = item.NgayTraPhong.ToString();
                lbTongTien.Text = item.TongTien.ToString();
            }
        }
    }
}
