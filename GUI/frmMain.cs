using BUS;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private string maNV;
        public frmMain(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        public frmMain()
        {
            InitializeComponent();
        }
        BUS_LoaiPhong busPhong = new BUS_LoaiPhong();
        private void frmMain_Load(object sender, EventArgs e)
        {
            //ucText phong = new ucText(maNV);
            //phong.Dock = DockStyle.Fill;
            //fluentDesignFormContainer1.Controls.Add(phong);
            //phong.BringToFront();
            cbLoaiPhong.DataSource = busPhong.Xem();
            loadLP();
            
        }
        void loadLP()
        {
            cbLoaiPhong.DisplayMember = "TENLOAIP";
            cbLoaiPhong.ValueMember = "MALOAIP";
        }
        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            ucNhanVien nhanVien = new ucNhanVien("KS00000001");
            nhanVien.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(nhanVien);
            nhanVien.BringToFront();
            panel1.Hide();
        }
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            ucText phong = new ucText(maNV,Convert.ToInt32(cbLoaiPhong.SelectedValue));
            phong.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(phong);
            phong.BringToFront();
            panel1.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            frmLoaiSP sp = new frmLoaiSP();
            sp.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemTang tang = new frmThemTang();
            tang.StartPosition = FormStartPosition.CenterScreen;
            tang.ShowDialog();
            frmMain_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmCapNhatTang tang = new frmCapNhatTang("Sua");
            tang.StartPosition=FormStartPosition.CenterScreen;
            tang.ShowDialog();
            frmMain_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmCapNhatTang tang = new frmCapNhatTang("Xoa");
            tang.StartPosition = FormStartPosition.CenterScreen;
            tang.ShowDialog();
            frmMain_Load(sender, e);
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLP();
            ucText phong = new ucText(maNV,Convert.ToInt32(cbLoaiPhong.SelectedValue));
            phong.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(phong);
            phong.BringToFront();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            frmInNhanVien nhanVien = new frmInNhanVien();
            nhanVien.ShowDialog();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            frmInSanPham sanPham = new frmInSanPham();
            sanPham.WindowState = FormWindowState.Maximized;
            sanPham.ShowDialog();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            ucDoanhThu ucDoanh = new ucDoanhThu();
            ucDoanh.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(ucDoanh);
            ucDoanh.BringToFront();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
