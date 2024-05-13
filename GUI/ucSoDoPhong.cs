using BUS;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucText : DevExpress.XtraEditors.XtraUserControl
    {
        public ucText()
        {
            InitializeComponent();

        }
        BUS_Tang busTang = new BUS_Tang();
        BUS_Phong busPhong = new BUS_Phong();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        Panel panel;

        Label tenKH;
        string maKS,maPhong,maTang,ma1Phong;
        double gia;
        private void ucText_Load(object sender, EventArgs e)
        {

            List<DTO_Tang> tang = busTang.Xem();
            int viTri = 0;

            var lables = tablePanel1.Controls.OfType<Label>();
            var stackPanels = tablePanel1.Controls.OfType<StackPanel>();
            
            foreach (var lable in lables)
            {
                DTO_Tang dtoTang = tang[viTri];
                lable.Text = dtoTang.Lau;
                StackPanel stackPanel = stackPanels.ElementAtOrDefault(viTri);
                stackPanel.AutoScroll = true;
                List<DTO_Phong> phong = busTang.CheckTang(dtoTang.MaTang);
                foreach (var item in phong)
                {
                    string[] arr = new string[] {item.MaKS,item.MaPhong,item.Gia.ToString(),dtoTang.MaTang};
                    panel = new Panel();
                    panel.Width = 200;
                    panel.Height = 100;
                    panel.Tag = arr;
                    panel.ContextMenuStrip = contextMenuStrip1;
                    this.panel.MouseUp += new MouseEventHandler(this.mouseUp);
                    Label tenPhong = new Label();
                    tenPhong.Text = item.TenPhong;
                    tenPhong.Dock = DockStyle.Top;
                    tenPhong.TextAlign = ContentAlignment.MiddleCenter;
                    tenPhong.Font = new Font("Arial", 12);
                    tenPhong.Height = 20;
                    tenKH = new Label();
                    if (busPhong.CheckPhong(item.MaPhong))
                    {
                        DTO_KhachHang kh = busKhachHang.Lay1KhachHang(item.MaKS, item.MaPhong);
                        panel.BackColor = Color.Aqua;
                        tenKH.Tag = item.MaPhong;
                        tenKH.ContextMenuStrip = contextMenuStrip2;
                        tenKH.AutoSize = false;
                        tenKH.Text = "Tên khách hàng: " + kh.TenKH + "\nSố người: " + item.SucChua;
                        tenKH.Dock = DockStyle.Fill;
                        tenKH.TextAlign = ContentAlignment.MiddleLeft;
                        tenKH.Font = new Font("Arial", 8);
                        this.tenKH.MouseUp += new MouseEventHandler(this.mouseUp1);
                    }
                    else
                    {
                        
                        panel.BackColor = Color.LightGreen;
                        
                    }
                    panel.Controls.Add(tenPhong);
                    panel.Controls.Add(tenKH);
                    stackPanel.Controls.Add(panel);
                }
                viTri++;
                
            }
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                Panel p = sender as Panel;
                string[] arr = (string[])p.Tag;
                maKS = arr[0];
                maPhong = arr[1];
                gia = double.Parse(arr[2]);
                maTang = arr[3];
            }
        }
        private void mouseUp1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Label l = sender as Label;
                string maPhong = l.Tag.ToString();
                ma1Phong = maPhong;
            }
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatPhong phong = new frmDatPhong(maKS, maPhong,gia);
            phong.StartPosition = FormStartPosition.CenterParent;
            phong.ShowDialog();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void xóaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (busPhong.Xoa(maPhong) > 0 )
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhatPhong ph = new frmCapNhatPhong(maKS,maTang,maPhong);
            ph.StartPosition = FormStartPosition.CenterParent;
            ph.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatPhieu xuatPhieu = new frmXuatPhieu(ma1Phong);
            xuatPhieu.StartPosition = FormStartPosition.CenterParent;
            xuatPhieu.ShowDialog();
        }

        private void thêmPhòngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemPhong phong = new frmThemPhong(maKS,maTang);
            phong.StartPosition=FormStartPosition.CenterParent;
            phong.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
