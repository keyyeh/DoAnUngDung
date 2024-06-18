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
        private int malp;
        private string maNV;
        public ucText(int maLp)
        {
            InitializeComponent();
            this.malp = maLp;

        }
        public ucText(string maNV, int maLp)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.malp = maLp;

        }
        BUS_Tang busTang = new BUS_Tang();
        BUS_Phong busPhong = new BUS_Phong();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        Panel panel;

        Label label,tenKH;
        string maKS,sdt;
        int maLPhong, maPhong, maTang;
        private void ucText_Load(object sender, EventArgs e)
        {

            List<DTO_Tang> tang = busTang.Xem();
            foreach (var item in tang)
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.AutoScroll = true;
                stackPanel.Width = flowLayoutPanel1.Width;
                stackPanel.Height = 120;
                
                Label lbTenLau = new Label();
                lbTenLau.Text = item.Lau;
                lbTenLau.Height = 120;
                lbTenLau.Width = 50;
                lbTenLau.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel1.Controls.Add(lbTenLau);
                flowLayoutPanel1.Controls.Add(stackPanel);
                List<DTO_Phong> phongs = busTang.CheckTang(item.Id,malp);
                foreach (var phong in phongs)
                {
                    string[] arr = new string[] { phong.MaKS, phong.MaPhong.ToString(), item.Id.ToString(),phong.MaLoaiP.ToString()};
                    panel = new Panel();
                    panel.Width = 200;
                    panel.Height = 100;
                    panel.ContextMenuStrip = contextMenuStrip1;
                    panel.Tag = arr;
                    this.panel.MouseUp += new MouseEventHandler(this.mouseUpPannel);
                    stackPanel.Controls.Add(panel);

                    label = new Label();
                    label.Dock = DockStyle.Top;
                    label.Height = 20;
                    label.Text = phong.TenPhong;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = new Font("Arial", 12);
                    label.ContextMenuStrip = contextMenuStrip1;
                    label.Tag = arr;
                    this.label.MouseUp += new MouseEventHandler(this.mouseUpLabel);
                    panel.Controls.Add(label);
                    panel.BackColor = Color.LightGreen;
                    if (busPhong.CheckPhong(phong.MaPhong))
                    {
                        DTO_KhachHang kh = busKhachHang.Lay1KhachHang(phong.MaPhong);
                        string[] arrA = new string[] { phong.MaKS, phong.MaPhong.ToString(), item.Id.ToString(), phong.MaLoaiP.ToString(), kh.Sdt};
                        panel.BackColor = Color.Aqua;
                        tenKH = new Label();
                        tenKH.Tag = arrA;
                        tenKH.ContextMenuStrip = contextMenuStrip2;
                        tenKH.AutoSize = false;
                        tenKH.Text = "Tên khách hàng: " + kh.TenKH + "\nSố người: " + phong.SucChua;
                        tenKH.Dock = DockStyle.Fill;
                        tenKH.TextAlign = ContentAlignment.MiddleLeft;
                        tenKH.Font = new Font("Arial", 8);
                        this.tenKH.MouseUp += new MouseEventHandler(this.mouseUpLabel1);
                        panel.Controls.Add(tenKH);
                    }
                    else
                    {

                        panel.BackColor = Color.LightGreen;

                    }
                    
                }

            }
        }
        private void mouseUpPannel(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                Panel p = sender as Panel;
                string[] arr = (string[])p.Tag;
                maKS = arr[0];
                maPhong = int.Parse(arr[1]);
                maTang = int.Parse(arr[2]);
                maLPhong = int.Parse(arr[3]);
            }
        }
        private void mouseUpLabel(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Label l = sender as Label;
                string[] arr = (string[])l.Tag;
                maKS = arr[0];
                maPhong = int.Parse(arr[1]);
                maTang = int.Parse(arr[2]);
                maLPhong = int.Parse(arr[3]);
            }
        }
        private void mouseUpLabel1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Label l = sender as Label;
                string[] arr = (string[])l.Tag;
                maKS = arr[0];
                maPhong = int.Parse(arr[1]);
                maTang = int.Parse(arr[2]);
                maLPhong = int.Parse(arr[3]);
                sdt = arr[4];
            }
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatPhong phong = new frmDatPhong(maNV, maPhong, maLPhong,maTang);
            phong.StartPosition = FormStartPosition.CenterScreen;
            phong.ShowDialog();
        }

        private void thêmSảnPhẩmVàDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatPhong datPhong = new frmDatPhong(maNV,maPhong, maLPhong, maTang,"edit");
            datPhong.StartPosition = FormStartPosition.CenterScreen;
            datPhong.ShowDialog();
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
            frmThemPhong ph = new frmThemPhong(maKS,maTang,maPhong,"updatePhong");
            ph.StartPosition = FormStartPosition.CenterParent;
            ph.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatPhieu xuatPhieu = new frmXuatPhieu(maPhong,maKS,sdt,maTang);
            xuatPhieu.StartPosition = FormStartPosition.CenterParent;
            xuatPhieu.ShowDialog();
        }

        private void thêmPhòngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemPhong phong = new frmThemPhong(maKS,maTang,maPhong,"editPhong");
            phong.StartPosition=FormStartPosition.CenterParent;
            phong.ShowDialog();
        }
    }
}
