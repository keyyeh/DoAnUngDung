using BUS;
using DevExpress.XtraEditors.Mask.Design;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class ucPhong : UserControl
    {
        public ucPhong()
        {
            InitializeComponent();
        }

        
        DTO_KhachHang dtoKhachHang;      

       
        BUS_KhachHang busKhachHang = new BUS_KhachHang();

        private void gbTTKH_Enter(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string cccd = txtCMND.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            bool gioiTinh = false;

            foreach (System.Windows.Forms.RadioButton rb in groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>())
            {
                if (rb.Checked)
                {
                    if (rb.Text == "Nam")
                    {
                        gioiTinh = true;
                    }
                    else if (rb.Text == "Nữ")
                    {
                        gioiTinh = false;
                    }
                    break; // Thoát vòng lặp sau khi tìm thấy RadioButton được chọn
                }
            }

            dtoKhachHang = new DTO_KhachHang(maKH, tenKH, cccd, gioiTinh, diaChi, email, sdt);

            if (busKhachHang.Them(dtoKhachHang) == 1)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
           
        }

        
    }
}
