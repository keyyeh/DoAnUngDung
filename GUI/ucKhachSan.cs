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
    public partial class ucKhachSan : UserControl
    {
        Timer timer = new Timer();
        public ucKhachSan()
        {
            InitializeComponent();
            InitializeClock();
        }
        DTO_Phong dtoPhong;
        DTO_KhachSan dtoKhachSan;
        DTO_KhachHang dtoKhachHang;
        DTO_DatPhong dtoDatPhong;

        BUS_Phong busPhong = new BUS_Phong();
        BUS_KhachSan busKhachSan = new BUS_KhachSan();
        BUS_DatPhong busDatPhong = new BUS_DatPhong();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();

        Panel panel;
        Label label;
        PictureBox pic;
        private void ucKhachSan_Load(object sender, EventArgs e)
        {
            List<DTO_Phong> xem = busPhong.LayDuLieu();

            foreach (var item in xem)
            {
                //Lưu 2 giá trị mã khách sạn và mã phòng vào trong Tag
                string[] ma = new string[] { item.MaKS, item.MaPhong };

                pic = new PictureBox();
                panel = new Panel();
                label = new Label();
                pic.Image = Properties.Resources.room;
                pic.Dock = DockStyle.Top;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Height = 80;
                pic.Tag = ma;
                label.AutoSize = false;
                label.Text = item.TenPhong;
                label.Dock = DockStyle.Bottom;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Height = 20;
                panel.Height = 100;
                panel.Width = 100;
                panel.Controls.Add(pic);
                panel.Controls.Add(label);
                pic.DoubleClick += new System.EventHandler(this.double_room);
                flowLayoutPanel1.Controls.Add(panel);
            }
            string[] maKS = (string[])pic.Tag;
            dgvDatPhong.DataSource = busDatPhong.Xem(maKS[0]);

        }

        private void double_room(object sender, EventArgs e)
        {
            
            // Trả về đối tượng control
            PictureBox pic = sender as PictureBox;
            Label lb = sender as Label;

            //Truy xuất các giá trị của Tag
            string[] layStr = (string[])pic.Tag;
            string maKS = layStr[0];
            string maPhong = layStr[1];

            // Lấy dữ liệu của 1 khách sạn
            DTO_KhachSan ks = busKhachSan.LayDuLieu(maKS);
            txtMaKS.Text = ks.MaKS;
            txtTenKS.Text = ks.TenKS;

            // Lấy dữ liệu của 1 phòng
            DTO_Phong phong = busPhong.Lay1Phong(maKS, maPhong);
            txtMaPhong.Text = phong.MaPhong;
            txtTenPhong.Text = phong.TenPhong;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void InitializeClock()
        {
            // Set timer interval to 1 second
            timer.Interval = 1000;
            // Add event handler for tick event
            timer.Tick += Timer_Tick;
            // Start the timer
            timer.Start();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            

            string maKS = txtMaKS.Text;
            DTO_KhachSan ks = busKhachSan.LayDuLieu(maKS);
            string tenKS = txtTenKS.Text;
            string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string cccd = txtCCCD.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diaChi = rtbDiaChi.Text;
            bool gioiTinh = false;

            foreach(RadioButton rb in groupBox1.Controls)
            {
                if (rb.Text == "Nam" && rb.Checked)
                {
                    gioiTinh = true;
                }
            }
            
            dtoKhachHang = new DTO_KhachHang(maKH, tenKH,cccd,gioiTinh,diaChi,email,sdt);
            dtoDatPhong = new DTO_DatPhong(maKS, maKH, maPhong, DateTime.Now);

            if (busKhachHang.Them(dtoKhachHang) == 1 && busDatPhong.Them(dtoDatPhong) == 1 )
            {
                MessageBox.Show("Đặt phòng thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thất bại!!!!!");
            }
            
            

        }
    }
}
