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
        BUS_DatMon busDatMon = new BUS_DatMon();
        private void btnIn_Click(object sender, EventArgs e)
        {
            busDatPhong.Xoa(maPhong);
            busDatMon.Xoa(maPhong);
        }

        private void frmXuatPhieu_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busDatMon.LayDuLieu(maPhong);
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvSP.Rows)
            {
                // Kiểm tra xem cell và giá trị của cột "Thành tiền" có null không
                if (row.Cells["Thành tiền"] != null && row.Cells["Thành tiền"].Value != null)
                {
                    // Lấy giá trị của cột "Thành tiền" từ dòng hiện tại và chuyển đổi sang kiểu double
                    double thanhTien;
                    if (double.TryParse(row.Cells["Thành tiền"].Value.ToString(), out thanhTien))
                    {
                        // Nếu chuyển đổi thành công, thêm giá trị vào biến tongTien
                        tongTien += thanhTien;
                    }
                }
            }


            IEnumerable<DTO_ThongTinDatPhong> datPhong = busDatPhong.InPhieu(maPhong);
            foreach (var item in datPhong)
            {
                txtMaKS.Text = item.MaKS;
                txtTenKS.Text = item.TenKS;
                txtTenKH.Text = item.TenKH;
                txtSDT.Text = item.Sdt;
                lbNgayDatPhong.Text = item.NgayDatPhong.ToString();
                lbNgayTraPhong.Text = item.NgayTraPhong.ToString();
                lbTongTien.Text = (item.TongTien + tongTien).ToString();
            }
            
        }
    }
}
