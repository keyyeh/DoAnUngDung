using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucNhanVien : UserControl
    {
        private string maKS;
        public ucNhanVien(string maKS)
        {
            InitializeComponent();
            this.maKS = maKS;
        }
        BUS_ChucVu busChucVu = new BUS_ChucVu();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (var opnDlg = new OpenFileDialog())
            {
                opnDlg.Filter = "Png Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
                if (opnDlg.ShowDialog() == DialogResult.OK)
                {
                    // Đọc hình ảnh từ tệp đã chọn
                    Image image = Image.FromFile(opnDlg.FileName);

                    // Gán hình ảnh cho PictureBox
                    pictureBox1.Image = image;
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            int chucVu = Convert.ToInt32(cbChucVu.SelectedValue);
            string diaChi = rtbDiaChi.Text;
            byte[] img = imageToByteArray(pictureBox1.Image);

            DTO_NhanVien nhanVien = new DTO_NhanVien(maNV, maKS, chucVu, ho, ten, sdt, diaChi, ngaySinh, img);
            if (busNhanVien.Them(nhanVien) > 0)
            {
                MessageBox.Show("Them thanh cong");
                dgvNhanVien.DataSource = busNhanVien.Xem();
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            cbChucVu.DataSource = busChucVu.Xem();
            cbChucVu.DisplayMember = "TENCV";
            cbChucVu.ValueMember = "MACV";
            dgvNhanVien.DataSource = busNhanVien.Xem();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int viTri = e.RowIndex;
            if (viTri >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[viTri];
                DTO_NhanVien nv = busNhanVien.LayNhanVien(row.Cells[0].Value.ToString());
                txtMaNV.Text = nv.MaNV;
                txtHo.Text = nv.HoNV;
                txtTen.Text = nv.TenNV;
                txtSDT.Text = nv.Sdt;
                if (nv.Image.Length > 0)
                {
                    //Tạo một MemoryStream từ dữ liệu byte
                    using (MemoryStream ms = new MemoryStream(nv.Image))
                    {
                        // Sử dụng phương thức FromStream của lớp Image để tạo một đối tượng hình ảnh từ MemoryStream
                        Image image = Image.FromStream(ms);

                        // Đặt hình ảnh vào pictureBox1
                        pictureBox1.Image = image;
                    }
                    dtpNgaySinh.Value = nv.NgaySinh;
                }
                rtbDiaChi.Text = nv.DiaChi;
                cbChucVu.Text = busChucVu.LayTenCV(nv.MaChucVu);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            int chucVu = Convert.ToInt32(cbChucVu.SelectedValue);
            string diaChi = rtbDiaChi.Text;
            byte[] img = imageToByteArray(pictureBox1.Image);

            DTO_NhanVien nhanVien = new DTO_NhanVien(maNV, maKS, chucVu, ho, ten, sdt, diaChi, ngaySinh, img);
            if (busNhanVien.Sua(nhanVien) == 1)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busNhanVien.Xoa(txtMaNV.Text) == 1)
            {
                MessageBox.Show("Xoa thanh cong");
                txtMaNV.Clear();
                txtHo.Clear();
                txtTen.Clear();
                txtSDT.Clear();
                rtbDiaChi.Clear();
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }
    }
}
