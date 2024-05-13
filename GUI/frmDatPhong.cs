using BUS;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraCharts.Native;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class frmDatPhong : Form
    {
        private string maKS = "";
        private string maPhong = "";
        private double gia = 0;
        private string soLuong;
        public frmDatPhong(string maKS,string maPhong,double gia)
        {
            InitializeComponent();
            this.maKS = maKS;
            this.maPhong = maPhong;
            this.gia = gia;          
        }
        public frmDatPhong(string soLuong)
        {
            InitializeComponent();
            this.soLuong = soLuong;
        }
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_DatPhong busDatPhong = new BUS_DatPhong();
        BUS_SanPham busSanPham = new BUS_SanPham();
        BUS_LoaiSP busLoai = new BUS_LoaiSP();
        BUS_Phong busPhong = new BUS_Phong();
        BUS_DatMon busDatMon = new BUS_DatMon();

        DTO_KhachHang dtoKhachHang;
        DTO_DatPhong dtoDatPhong;
        int id;
        private void frmPhong_Load(object sender, EventArgs e)
        {
            cbLoaiHinh.SelectedIndex = 0;
            cbLoai.DataSource = busLoai.Xem();
            cbLoai.DisplayMember = "TENLOAI";
            cbLoai.ValueMember = "MALOAI";
            cbPhong.DataSource = busPhong.Xem();
            cbPhong.DisplayMember = "TENPHONG";
            cbPhong.ValueMember = "MAPHONG";
            cbPhong.SelectedIndex = busPhong.TimViTriPhong(maPhong);
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            DTO_KhachHang kh = busKhachHang.LayKhachHang(txtSDT.Text);
            if (kh!=null)
            {
                txtTenKH.Text = kh.TenKH;
                txtCCCD.Text = kh.CMND;
                txtDiaChi.Text = kh.DiaChi;
                txtEmail.Text = kh.Email;
            }
            
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text;
            string cccd = txtCCCD.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            bool gioiTinh = false;
            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Text == "Nam" && rb.Checked)
                {
                    gioiTinh = true;
                }
            }
            if (busKhachHang.LayKhachHang(txtSDT.Text) == null)
            {
                dtoKhachHang = new DTO_KhachHang(sdt, tenKH, cccd, gioiTinh, diaChi, email);
                busKhachHang.Them(dtoKhachHang);
            }
            dgvDSKH.DataSource = busKhachHang.Xem(txtSDT.Text);
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int viTri = e.RowIndex;
            if (viTri >= 0)
            {
                DataGridViewRow row = dgvDSKH.Rows[viTri];
                dgvPhong.DataSource = busDatPhong.Xem(row.Cells[0].Value.ToString());
            }
        }

        // Khai báo danh sách sản phẩm
        List<DTO_MucSP> sp = new List<DTO_MucSP>();

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoLuong sl = new frmSoLuong();
            sl.ShowDialog();

            if (!string.IsNullOrEmpty(sl.TextBoxValue()))
            {
                int soLuong = int.Parse(sl.TextBoxValue());

                int viTri = int.Parse(dgvSanPham.Rows[dgvSanPham.CurrentCell.RowIndex].Cells["maSP"].Value.ToString());
                DTO_SanPham sanPham = busSanPham.LayDuLieu(viTri);
                double gia = soLuong * sanPham.Gia;

                // Kiểm tra nếu DataTable đã được khởi tạo trước đó
                DataTable dt;
                if (dgvMucSP.DataSource == null)
                {
                    dt = new DataTable();
                    // Định nghĩa cấu trúc cho DataTable
                    dt.Columns.Add("colMaSp",typeof(int));
                    dt.Columns.Add("Tên sản phẩm",typeof(string));
                    dt.Columns.Add("colMaLoai", typeof(string));
                    dt.Columns.Add("Giá", typeof(double));
                    dt.Columns.Add("colDonVi", typeof(string));
                    dt.Columns.Add("Số lượng", typeof(int));
                    dt.Columns.Add("Thành tiền", typeof(double));
                }
                else
                {
                    dt = (DataTable)dgvMucSP.DataSource; // Lấy DataTable từ DataSource hiện tại
                }

               

                // Thêm dòng mới vào DataTable
                dt.Rows.Add(sanPham.MaSP,sanPham.TenSP,sanPham.MaLoai,sanPham.Gia,sanPham.DonVi,soLuong,gia);

                // Gán DataTable làm DataSource cho DataGridView
                dgvMucSP.DataSource = dt;
                dgvMucSP.Columns["colMaSp"].Visible = false;
                dgvMucSP.Columns["colMaLoai"].Visible = false;
                dgvMucSP.Columns["colDonVi"].Visible = false;
            }
        }
        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLoai.DisplayMember = "TENLOAI";
            cbLoai.ValueMember = "MALOAI";
            id = Convert.ToInt16(cbLoai.SelectedValue);
            dgvSanPham.DataSource = busSanPham.Xem(id);
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                dgvSanPham.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            cbPhong.DisplayMember = "TENPHONG";
            cbPhong.ValueMember = "MAPHONG";
            string dateInStr = dtpDateIn.Value.ToString("yyyy-MM-dd");
            string timeInStr = dtpTimeIn.Value.ToString("HH:mm:ss");
            DateTime dateTimeIn = DateTime.ParseExact(dateInStr + " " + timeInStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            string dateOutStr = dtpDateOut.Value.ToString("yyyy-MM-dd");
            string timeOutStr = dtpTimeOut.Value.ToString("HH:mm:ss");
            DateTime dateTimeOut = DateTime.ParseExact(dateOutStr + " " + timeOutStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime ngayBatDau = dtpDateIn.Value;
            DateTime ngayKetThuc = dtpDateOut.Value;
            TimeSpan khoangCach = ngayKetThuc - ngayBatDau;
            int soNgay = (int)khoangCach.TotalDays;

            dtoDatPhong = new DTO_DatPhong(maKS, sdt, maPhong, dateTimeIn, dateTimeOut, soNgay * gia);


            if (busDatPhong.Them(dtoDatPhong) == 1)
            {
                MessageBox.Show("Đặt phòng thành công", "Thông báo");
                // List để lưu trữ các giá trị của cột "colMaSp"
                List<int> maSpList = new List<int>();

                // List để lưu trữ các giá trị của cột "colThanhTien"
                List<double> thanhTienList = new List<double>();

                // Lặp qua từng dòng trong DataGridView
                foreach (DataGridViewRow row in dgvMucSP.Rows)
                {
                    // Kiểm tra nếu dòng không phải là dòng mới
                    if (!row.IsNewRow)
                    {
                        // Lấy giá trị của cột "colMaSp" từ dòng hiện tại và thêm vào danh sách
                        int maSp = int.Parse(row.Cells["colMaSp"].Value.ToString());
                        maSpList.Add(maSp);

                        // Lấy giá trị của cột "colThanhTien" từ dòng hiện tại và chuyển đổi sang kiểu double
                        double thanhTien;
                        if (double.TryParse(row.Cells["Thành tiền"].Value.ToString(), out thanhTien))
                        {
                            // Nếu chuyển đổi thành công, thêm giá trị vào danh sách
                            thanhTienList.Add(thanhTien);
                        }
                    }
                }
                // Đảm bảo rằng cả hai danh sách có cùng độ dài
                if (maSpList.Count == thanhTienList.Count)
                {
                    for (int i = 0; i < maSpList.Count; i++)
                    {
                        
                        int maSp = maSpList[i];
                        double thanhTien = thanhTienList[i];
                        DTO_DatMon dm = new DTO_DatMon(maSp, cbPhong.SelectedValue.ToString(), thanhTien);
                        busDatMon.Them(dm);
                    }
                }
                else
                {
                    // Xử lý trường hợp nếu độ dài của hai danh sách không bằng nhau
                    Console.WriteLine("Độ dài của hai danh sách không bằng nhau.");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Khách hàng đã đặt phòng");
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
