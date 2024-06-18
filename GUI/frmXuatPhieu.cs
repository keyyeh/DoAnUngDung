using BUS;
using DAL;
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
        private string maKS,sdt;
        private int maPhong, maTang;
        public frmXuatPhieu(int maPhong,string maKS,string sdt,int maTang)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            this.maKS = maKS;
            this.sdt = sdt;
            this.maTang = maTang;
        }
        BUS_DatPhong busDatPhong = new BUS_DatPhong();
        BUS_Phong busPhong = new BUS_Phong();
        BUS_LoaiPhong busLoaiPhong = new BUS_LoaiPhong();
        BUS_HinhThuc busHinhThuc = new BUS_HinhThuc();
        private void button1_Click(object sender, EventArgs e)
        {
            busDatPhong.Xoa(maPhong);

            MessageBox.Show("Đã thanh toán thành công");
            this.Close();
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmInHoaDon xuatPhieu = new frmInHoaDon(sdt, maPhong);
            xuatPhieu.ShowDialog();
        }

        private void frmXuatPhieu_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busDatPhong.LayDuLieu(maPhong);
            DTO_DatPhong datPhong = busDatPhong.Lay1DatPhong(maPhong);
            DTO_Phong phong = busPhong.Lay1Phong(maTang, maPhong);
            double giaPhong = busHinhThuc.LayGiaHT(phong.MaHT);
            DateTime ngayDatPhong = datPhong.NgayDatPhong;
            DateTime ngayTraPhong = DateTime.Now;

            // Calculate the time span between the two dates
            TimeSpan timeSpan = ngayTraPhong - ngayDatPhong;
            int soNgay = (int)timeSpan.TotalDays;
            // Get the total number of hours
            int totalHours = timeSpan.Hours;
            int totalMinutes = timeSpan.Minutes;

            DTO_DatPhong dTO_DatPhong = new DTO_DatPhong(datPhong.MaHD,datPhong.SDT,maPhong,datPhong.MaSP,datPhong.NgayDatPhong,ngayTraPhong,totalHours * giaPhong);
            if (phong.MaLoaiP < 4)
            {
                busDatPhong.Sua(dTO_DatPhong);
            }
            
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

            lbGio.Text = totalHours.ToString();
            lbPhut.Text = totalMinutes.ToString();
            lbNgay.Text = soNgay.ToString();
            double datPhongs = busDatPhong.TongTien(maPhong);
            DTO_ThongTinDatPhong item = busDatPhong.InPhieu(maPhong);
            double tong = busDatPhong.TongHoaDon(sdt, maPhong, maKS);
            txtTenKH.Text = item.TenKH;
            txtSDT.Text = item.Sdt;
            lbNgayDatPhong.Text = item.NgayDatPhong.ToString();
            lbNgayTraPhong.Text = item.NgayTraPhong.ToString();
            lbTongTien.Text = (tong).ToString();
        }
    }
}
