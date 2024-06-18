using BUS;
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
    public partial class ucDoanhThu : UserControl
    {
        public ucDoanhThu()
        {
            InitializeComponent();
        }
        BUS_HoaDon hoaDon = new BUS_HoaDon();
        private void btnKhoangNgay_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dateTimePicker1.Value;
            DateTime denNgay = dateTimePicker2.Value;

            dgvThongKe.DataSource = hoaDon.BaoCaoTheoKhoangNgay(tuNgay,denNgay);
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                // Kiểm tra xem cell và giá trị của cột "Thành tiền" có null không
                if (row.Cells["TongTien"] != null && row.Cells["TongTien"].Value != null)
                {
                    // Lấy giá trị của cột "Thành tiền" từ dòng hiện tại và chuyển đổi sang kiểu double
                    double thanhTien;
                    if (double.TryParse(row.Cells["TongTien"].Value.ToString(), out thanhTien))
                    {
                        // Nếu chuyển đổi thành công, thêm giá trị vào biến tongTien
                        tongTien += thanhTien;
                    }
                }
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmInThongKe inThongKe = new frmInThongKe(dateTimePicker1.Value,dateTimePicker2.Value,"Tuan",cbThang.SelectedIndex);
            inThongKe.WindowState = FormWindowState.Maximized;
            inThongKe.ShowDialog();
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = hoaDon.BaoCaoTheoKhoangNgay(cbThang.SelectedIndex + 1);
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                // Kiểm tra xem cell và giá trị của cột "Thành tiền" có null không
                if (row.Cells["TongTien"] != null && row.Cells["TongTien"].Value != null)
                {
                    // Lấy giá trị của cột "Thành tiền" từ dòng hiện tại và chuyển đổi sang kiểu double
                    double thanhTien;
                    if (double.TryParse(row.Cells["TongTien"].Value.ToString(), out thanhTien))
                    {
                        // Nếu chuyển đổi thành công, thêm giá trị vào biến tongTien
                        tongTien += thanhTien;
                    }
                }
            }
            txtTongTien.Text = tongTien.ToString() + "VND";
        }
    }
}
