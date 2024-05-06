using BUS;
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
    public partial class frmPhong : Form
    {
        private string maKS = "";
        private string maPhong = "";
        public frmPhong(string maKS,string maPhong)
        {
            InitializeComponent();
            this.maKS = maKS;
            this.maPhong = maPhong;

           
        }
        BUS_KhachSan busKhachSan = new BUS_KhachSan();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_DatPhong busDatPhong = new BUS_DatPhong();

        DTO_KhachHang dtoKhachHang;
        DTO_DatPhong dtoDatPhong;
        private void frmPhong_Load(object sender, EventArgs e)
        {
            cbLoaiHinh.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sdt = txtSDT.Text;


           
            string dateInStr = dtpDateIn.Value.ToString("yyyy-MM-dd");
            string timeInStr = dtpTimeIn.Value.ToString("HH:mm:ss");
            DateTime dateTimeIn = DateTime.ParseExact(dateInStr + " " + timeInStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            string dateOutStr = dtpDateOut.Value.ToString("yyyy-MM-dd");
            string timeOutStr = dtpTimeOut.Value.ToString("HH:mm:ss");
            DateTime dateTimeOut = DateTime.ParseExact(dateOutStr + " " + timeOutStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            dtoDatPhong = new DTO_DatPhong(maKS, sdt, maPhong, dateTimeIn, dateTimeOut);
            

            if (busDatPhong.Them(dtoDatPhong) == 1)
            {
                MessageBox.Show("Đặt phòng thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Khách hàng đã đặt phòng");
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            

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
    }
}
